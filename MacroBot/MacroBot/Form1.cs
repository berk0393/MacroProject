using MacroBot.Model;
using MacroBot.Repository;
using Gma.System.MouseKeyHook;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

using static MacroBot.MouseEvent;
using MacroBot.Helper;
using MacroBot.Repository.RectangleRep;
using MacroBot.Repository.ScreenDraw;

namespace MacroBot
{
    public partial class Form1 : Form
    {
        #region Variables

        private bool recordIsActive = false;

        private bool recordRectangleCreate = false;

        private bool isEditAction = false;

        private bool macroRuning = false;


        private int repeatNumber = 0;

        private int repeatAfterSleepMilisecond = 0;

        private int actionQueue = 0;

        private int screadReadID = 1;

        private int rectangleCornerCount = 0;

        private int actionListLastSelectedIndex = -1;

        private string exeName = string.Empty;


        private CreatedRectangleInfo rectangleInfo = null;

        private List<RectangleCooridant> rectangleDrawingCoordiantList = null;

        private RunMacro rm = null;

        private Thread runMacroThread = null;

        private ActionRepository _actionRepository = null;

        private RectangleRepository _rectangleRepository = null;

        private ExeProcesses _exeProcesses = null;

        private BotActionList editBotAction = null;

        private DrawRepository drawScreen = null;



        private IKeyboardMouseEvents keyboardMouseEvents;

        #endregion

        public Form1()
        {
            try
            {
                InitializeComponent();

                //Keyhook
                createHook();
                keyboardMouseEvents.MouseClick += MouseClickAll;
                //keyboardMouseEvents.KeyUp += KeyboardOnKeyUp;

                //Action Repository
                _actionRepository = new ActionRepository();
                addActionType();


                //Exe Proccess
                _exeProcesses = new ExeProcesses();

                //Macro Instance
                rm = new RunMacro();

                //Rectangle Info
                _rectangleRepository = new RectangleRepository();
                rectangleInfo = new CreatedRectangleInfo();
                rectangleDrawingCoordiantList = new List<RectangleCooridant>();
                drawScreen = new DrawRepository();

                //Thread Instance
                createRunMacroThreadInstance();

                clearOlderFiles();



            }
            catch (Exception ex)
            {
                showAlert(ex.Message);
                enabledAllButton();
            }
        }

        #region Rectangle Functions

        /// <summary>
        /// Seçilen Dikdörtgenin Bilgilerini Inputlara Yazar
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="w"></param>
        /// <param name="h"></param>
        private void addRectangleInfoTextbox(int x, int y, int w, int h)
        {
            txtRecX.Text = x.ToString();
            txtRecY.Text = y.ToString();
            txtRecW.Text = w.ToString();
            txtRecH.Text = h.ToString();
        }

        /// <summary>
        /// Dikdörtgen İçin Seçilen 4 Nokta İşleminden Sonra İlgili Kontrol Değişkenini false yapar
        /// </summary>
        private void closeRectangleRecord()
        {
            recordRectangleCreate = false;
        }

        /// <summary>
        /// Dikdörtgen Bilgi Textboxlarını Siler
        /// </summary>
        private void clearRectangleInfoTextbox()
        {
            txtRecX.Text = String.Empty;
            txtRecY.Text = String.Empty;
            txtRecW.Text = String.Empty;
            txtRecH.Text = String.Empty;
        }

        /// <summary>
        /// Dikdörtgen oluşturmaya dair her şeyi temizler
        /// </summary>
        private void clearRectangle()
        {
            rectangleInfo = new CreatedRectangleInfo();
            enabledAllButton();
            btnSaveRectangle.Enabled = false;
            clearRectangleInfoTextbox();
            rectangleDrawingCoordiantList.Clear();
            txtSearchedText.Clear();
        }

        #endregion

        #region Button Functions

        /// <summary>
        /// Tüm Buttonları Disabled Eder
        /// </summary>
        private void disabledAllButton()
        {
            btnRecord.Enabled = false;
            btnRecordRectangle.Enabled = false;
            btnAllProgramClear.Enabled = false;
            btnMacroSettingSave.Enabled = false;
        }

        /// <summary>
        /// İlgili Tüm Buttonları Açar
        /// </summary>
        private void enabledAllButton()
        {
            btnRecord.Enabled = true;
            btnRecordRectangle.Enabled = true;
            btnAllProgramClear.Enabled = true;
            btnMacroSettingSave.Enabled = true;
        }

        private void startRectangleRecord()
        {
            closeMouseRecord();
            disabledAllButton();
            recordRectangleCreate = true;
            exeForegroundWindow();
            txtSearchedText.Clear();
        }

        #endregion

        #region Clean Functions

        /// <summary>
        /// Tüm program fonksiyonlarını sıfırlar
        /// </summary>
        private void clearAllProgramFunction()
        {
            actionQueue = 0;
            screadReadID = 1;
            lstbxRecord.Items.Clear();
            txtReadedData.Clear();
            clearRectangle();
            resetAllObject();
            enabledAllButton();
            macroEditDataClear();

        }

        /// <summary>
        /// Coordinant textboxlarını sıfırlar
        /// </summary>
        private void clearCoordinateTextboxes()
        {
            for (int i = 0; i < 4; i++)
            {
                string name = "txtClick" + (i);

                TextBox txt = (TextBox)pnlReadScreen.Controls.Find(name, true)[0];

                if (txt != null)
                    txt.Clear();
            }
        }

        /// <summary>
        /// Macronun edit için tasarlanan değişkenlerini sıfırlar
        /// </summary>
        private void macroEditDataClear()
        {
            editBotAction = null;
            actionListLastSelectedIndex = -1;
            lstbxRecord.SelectedIndex = -1;
            isEditAction = false;
            btnMouseEdit.Enabled = true;
            mouseFunctionEditScreen(false);
            rectangleFunctionEditScreen(false);

            if (recordIsActive)
                recordIsActive = false;

            if (recordRectangleCreate)
                recordRectangleCreate = false;

            drpActionType.SelectedIndex = 1;
            clearRectangle();
        }

        /// <summary>
        /// Screenshoot ları siler
        /// </summary>
        private void clearOlderFiles()
        {
            MacroHelper.removeFiles(rm._screenshotService.getImagesFilePath());
        }

        /// <summary>
        /// Sistemde ki tüm objeleri sıfırlar
        /// </summary>
        private void resetAllObject()
        {
            _exeProcesses = new ExeProcesses();
            rm = new RunMacro();
            _actionRepository = new ActionRepository();
            _rectangleRepository = new RectangleRepository();
            rectangleInfo = new CreatedRectangleInfo();
            rectangleDrawingCoordiantList = new List<RectangleCooridant>();
        }

        #endregion

        #region Mouse Keyboard Functions

        /// <summary>
        /// Fare ve Klavye Eventleri
        /// </summary>
        private void createHook()
        {
            keyboardMouseEvents = Hook.GlobalEvents();
        }

        /// <summary>
        /// Fare Hareketi
        /// </summary>
        /// <returns></returns>
        private POINT getMousePoint()
        {
            POINT outMousePoint;
            if (MouseEvent.GetCursorPos(out outMousePoint))
            {
                return outMousePoint;
            }
            else throw new Exception("Pointer Bulunamadı");
        }

        /// <summary>
        /// Fare Hareketi Kayıt Sonrası İlgili Kontrol Değişkenini false yapar
        /// </summary>
        private void closeMouseRecord()
        {
            recordIsActive = false;
        }

        /// <summary>
        /// Fare kayıt işlemi için formu ayarlar
        /// </summary>
        /// <param name="isWaitingEvent"></param>
        private void mouseRecordButtonFunction(bool isWaitingEvent)
        {
            if (isWaitingEvent)
            {
                waitingEventAdd();
                return;
            }

            recordIsActive = true;
            disabledAllButton();
            exeForegroundWindow();
        }

        /// <summary>
        /// Mouse Event Function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MouseClickAll(object sender, MouseEventArgs e)
        {
            try
            {
                if (recordIsActive)
                {
                    POINT mousePoint = getMousePoint();
                    string selectedActionTypeName = drpActionType.Text;
                    int selectedActionTypeID = Convert.ToInt32(drpActionType.SelectedValue);

                    if (isEditAction)
                    {
                        editListBox(selectedActionTypeName, selectedActionTypeID, mousePoint.X, mousePoint.Y);
                        macroEditDataClear();
                        mouseFunctionEditScreen(false);
                    }
                    else addListBox(selectedActionTypeName, selectedActionTypeID, mousePoint.X, mousePoint.Y);


                    closeMouseRecord();
                    enabledAllButton();
                    _exeProcesses.getMyScreen();
                }

                if (recordRectangleCreate)
                {
                    POINT mousePoint = getMousePoint();
                    rectangleCornerCount++;

                    rectangleDrawingCoordiantList.Add(new RectangleCooridant() { xCoordinate = mousePoint.X, yCoordinate = mousePoint.Y });

                    fillCoordinateTextboxes(rectangleCornerCount, mousePoint.X, mousePoint.Y);

                    if (rectangleCornerCount == 4)
                    {
                        rectangleInfo = _rectangleRepository.defineRectangle(rectangleDrawingCoordiantList);
                        addRectangleInfoTextbox(rectangleInfo.xCoordinate, rectangleInfo.yCoordinate, rectangleInfo.width, rectangleInfo.height);
                        closeRectangleRecord();
                        enabledAllButton();
                        rectangleCornerCount = 0;
                        btnSaveRectangle.Enabled = true;
                        rectangleDrawingCoordiantList.Clear();
                        _exeProcesses.getMyScreen();
                    }
                }
            }
            catch (Exception ex)
            {
                showAlert(ex.Message);
            }
        }

        private void KeyboardOnKeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (macroRuning)
                {
                    if (e.KeyCode.ToString() == "F8")
                    {
                        btnStop.PerformClick();
                    }
                }
            }
            catch (Exception ex)
            {
                showAlert(ex.Message);
            }
        }

        #endregion

        #region Form Interface 

        /// <summary>
        /// Formun Select'ine İşlem Türlerini Basar
        /// </summary>
        private void addActionType()
        {
            drpActionType.DataSource = _actionRepository.getActionList().Where(a => a.visibleMouseEvent == true).ToList();
            drpActionType.DisplayMember = nameof(ActionTypeModel.typeName);
            drpActionType.ValueMember = nameof(ActionTypeModel.typeID);
        }

        /// <summary>
        /// İlgili Textbox a koordinant bilgileri girilir
        /// </summary>
        /// <param name="index"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        private void fillCoordinateTextboxes(int index, int x, int y)
        {
            string name = "txtClick" + (index - 1);

            TextBox txt = (TextBox)pnlReadScreen.Controls.Find(name, true)[0];

            if (txt != null)
                txt.Text = x.ToString() + " " + y.ToString();
        }

        /// <summary>
        /// Macro status label'i doldurulur
        /// </summary>
        /// <param name="text"></param>
        private void macroStatusText(string text)
        {
            lblMacroStart.Text = text;
        }

        /// <summary>
        /// Macro Ayarlarını formun bilgilendirme ekranına yazar
        /// </summary>
        private void setMacroSettingsInfo()
        {
            lblExeNameInfo.Text = exeName;
            lblRepeatNumberInfo.Text = repeatNumber.ToString();
            lblRepeatWaitingTimeInfo.Text = repeatAfterSleepMilisecond.ToString() + " Milisecond";
        }

        private void showEditMouseInfo()
        {
            tblControl.SelectTab(pnlMouse);

            clearRectangle();

            drpActionType.SelectedValue = editBotAction.actionID;

            if (editBotAction.actionID == (int)EnumActionType.Bekle)
                txtWaitingSecond.Text = editBotAction.waitingSecond.ToString();
        }

        private void showEditScreenReadInfo()
        {
            tblControl.SelectTab(pnlReadScreen);

            drpActionType.SelectedIndex = 1;

            ScreenReadActionList screenReadData = _actionRepository.screenReadActionList.Where(a => a.recordID == editBotAction.screenReadID).FirstOrDefault();

            addRectangleInfoTextbox(screenReadData.xCoordinate, screenReadData.yCoordinate, screenReadData.width, screenReadData.height);

            string searchedData = string.Join(",", screenReadData.ekListesi);

            txtSearchedText.Text = searchedData;
        }

        private void mouseFunctionEditScreen(bool editFunctionOpen)
        {
            if (editFunctionOpen)
            {
                pnlMouseEdit.Visible = true;
                btnRecord.Visible = false;
            }
            else
            {
                pnlMouseEdit.Visible = false;
                btnRecord.Visible = true;
            }
        }

        private void rectangleFunctionEditScreen(bool editFunctionOpen)
        {
            if (editFunctionOpen)
            {

                btnRecordRectangle.Visible = false;
                btnRectangleEdit.Visible = true;

                btnSaveRectangle.Text = "Okunacak Ekranı Güncelle";
                btnSaveRectangle.BackColor = Color.Orange;
            }
            else
            {
                btnRecordRectangle.Visible = true;
                btnRectangleEdit.Visible = false;

                btnSaveRectangle.Text = "Okunacak Ekranı Kaydet";
                btnSaveRectangle.BackColor = Color.Lime;
            }
        }

        #endregion

        #region Thread Functions

        /// <summary>
        /// Fonksiyon için yeni macro açar
        /// </summary>
        private void createRunMacroThreadInstance()
        {
            runMacroThread = new Thread(macroRunFunction);
            runMacroThread.IsBackground = true;
        }

        /// <summary>
        /// Açılan thread durdurulur
        /// </summary>
        private void stopRunMacroThread()
        {
            if (runMacroThread != null)
                runMacroThread.Abort();

            macroRuning = false;
        }

        /// <summary>
        /// Eğer bir data okunmuşsa bunu yazar.
        /// </summary>
        /// <param name="data"></param>
        private void addReadedData(string data)
        {
            txtReadedData.Text += data;
            txtReadedData.Text += Environment.NewLine;
            txtReadedData.Text += "------------------";
            txtReadedData.Text += Environment.NewLine;
        }

        #endregion

        #region Macro CRUD functions

        /// <summary>
        /// İşlem Listesine İşlemi Yazdırır Ve Aksiyon Listesini Doldurur
        /// </summary>
        /// <param name="actionTypeName"></param>
        /// <param name="actionTypeValue"></param>
        /// <param name="xPoint"></param>
        /// <param name="yPoint"></param>
        /// <param name="screenReadID"></param>
        private void addListBox(string actionTypeName, int actionTypeValue, int xPoint, int yPoint, int screenReadID = 0, int waitingSecond = 0)
        {
            if (actionTypeValue == 0)
            {
                clearAllProgramFunction();
                showAlert("İşlem Türü Yanlış: ID:" + actionTypeValue);
            }

            _actionRepository.addActionList(actionQueue, xPoint, yPoint, actionTypeValue, screenReadID, waitingSecond);

            lstbxRecord.Items.Add(new { value = actionQueue, Name = actionTypeName + " - Coordinate: x:" + xPoint + " y:" + yPoint + " ActionID:" + actionTypeValue });

            actionQueue++;
        }

        private void editListBox(string actionTypeName, int actionTypeValue, int xPoint, int yPoint, int screenReadID = 0, int waitingSecond = 0)
        {
            int selectedIndex = editBotAction.actionQueue;

            lstbxRecord.Items[selectedIndex] = new { value = selectedIndex, Name = actionTypeName + " - Coordinate: x:" + xPoint + " y:" + yPoint + " ActionID:" + actionTypeValue };

            _actionRepository.editActionList(selectedIndex, xPoint, yPoint, actionTypeValue, screenReadID, waitingSecond);
        }

        /// <summary>
        /// Bekleme eventini işlem sırasına ekler
        /// </summary>
        private void waitingEventAdd()
        {
            EnumActionType actionType = EnumActionType.Bekle;

            int second = 0;
            string _txtSecodn = txtWaitingSecond.Text;


            if (!string.IsNullOrWhiteSpace(_txtSecodn))
                second = Convert.ToInt32(txtWaitingSecond.Text);

            addListBox(actionType.GetDisplayName(), (int)actionType, 0, 0, 0, second);
        }



        #endregion

        #region Methods

        /// <summary>
        /// Macroyu Çalıştıran Fonksiyom
        /// </summary>
        private void macroRunFunction()
        {
            bool macroFinishStatus = true;

            for (int i = 0; i < repeatNumber; i++)
            {
                MacroResult macroResult = rm.runMacro(_actionRepository.actionList, _actionRepository.screenReadActionList);

                dataReadControl(macroResult);

                if (!macroResult.continueStatus)
                {
                    if (macroResult.findSearchedWord)
                        macroStatusText("Kelime Bulundu");
                    else macroStatusText("Macro Durduruldu");

                    macroFinishStatus = false;
                    break;
                }

                Thread.Sleep(repeatAfterSleepMilisecond);
            }

            if (macroFinishStatus)
                macroStatusText("Macro Tamamlandı");

            enabledAllButton();

            stopRunMacroThread();


        }

        /// <summary>
        /// Herhangi bir bilginin okunup okunmadığını belirten fonksiyon.
        /// </summary>
        /// <param name="macroResult"></param>
        private void dataReadControl(MacroResult macroResult)
        {
            if (macroResult.readedDataList.Count > 0)
            {
                foreach (string item in macroResult.readedDataList)
                {
                    addReadedData(item);
                }
            }
        }

        /// <summary>
        /// Ekranı Öne Getirir
        /// </summary>
        private void exeForegroundWindow()
        {
            _exeProcesses.ekranionegetir();
        }

        /// <summary>
        /// Hata Mesajları İçin
        /// </summary>
        /// <param name="text"></param>
        private void showAlert(string text)
        {
            MessageBox.Show(text, "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            enabledAllButton();
        }
        #endregion

        #region Events

        /// <summary>
        /// Fare Click İşlemi Başlatıcı
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRecord_Click(object sender, EventArgs e)
        {
            if (drpActionType.SelectedValue.ToString() == ((int)EnumActionType.Bekle).ToString())
                mouseRecordButtonFunction(true);
            else mouseRecordButtonFunction(false);
        }



        /// <summary>
        /// Dikdörtgen Click İşlemi Başlatıcısı
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRecordRectangle_Click(object sender, EventArgs e)
        {
            startRectangleRecord();
        }

        /// <summary>
        /// Oluşturulan Dikdörtgeni Kayıt Eder Ve Aksiyon Listesine Alır
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveRectangle_Click(object sender, EventArgs e)
        {
            try
            {
                EnumActionType actionType = EnumActionType.EkranOku;

                string ekler = txtSearchedText.Text;

                List<string> eklerList = new List<string>();

                if (!string.IsNullOrWhiteSpace(ekler))
                {
                    eklerList = ekler.Split(',').ToList();
                }

                if (isEditAction)
                {
                    editListBox(actionType.GetDisplayName(), (int)actionType, rectangleInfo.xCoordinate, rectangleInfo.yCoordinate, editBotAction.screenReadID);

                    _actionRepository.editScreenReadList(editBotAction.screenReadID, eklerList, rectangleInfo.xCoordinate, rectangleInfo.yCoordinate, rectangleInfo.width, rectangleInfo.height);

                    macroEditDataClear();
                }
                else
                {
                    _actionRepository.addScreenReadList(screadReadID, eklerList, rectangleInfo.xCoordinate, rectangleInfo.yCoordinate, rectangleInfo.width, rectangleInfo.height);

                    addListBox(actionType.GetDisplayName(), (int)actionType, rectangleInfo.xCoordinate, rectangleInfo.yCoordinate, screadReadID);

                    screadReadID++;
                }

                clearRectangle();
                enabledAllButton();
                clearCoordinateTextboxes();
            }
            catch (Exception ex)
            {
                clearRectangle();
                showAlert(ex.Message);
            }
        }

        /// <summary>
        /// Macro Ayarlarını Kayıt Eder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMacroSettingSave_Click(object sender, EventArgs e)
        {
            try
            {
                exeName = txtExeName.Text;

                repeatNumber = Convert.ToInt32(txtRepeatNumber.Text);

                if (!string.IsNullOrWhiteSpace(txtWaitingTime.Text))
                    repeatAfterSleepMilisecond = Convert.ToInt32(txtWaitingTime.Text);

                _exeProcesses.setProccess(exeName);

                lblWarningInfoSave.Text = "Bilgiler Kayıt Edildi. İşleme Devam Edebilirsiniz";
                lblWarningInfoSave.BackColor = Color.FromArgb(50, 205, 50);

                btnStart.Enabled = true;
                setMacroSettingsInfo();
            }
            catch (Exception ex)
            {
                showAlert(ex.Message);
            }


            //ChromeRivals
        }

        /// <summary>
        /// Programı Temizler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAllProgramClear_Click(object sender, EventArgs e)
        {
            clearAllProgramFunction();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (runMacroThread.ThreadState != ThreadState.Running)
                {
                    macroStatusText("Macro Başlatıldı");
                    disabledAllButton();

                    if (runMacroThread.ThreadState == ThreadState.Aborted || runMacroThread.ThreadState == ThreadState.Stopped)
                        createRunMacroThreadInstance();

                    runMacroThread.Start();

                    macroRuning = true;
                }

            }
            catch (Exception ex)
            {
                showAlert(ex.Message);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            macroStatusText("Macro Durduruldu");
            enabledAllButton();
            stopRunMacroThread();
        }

        private void txtReadedData_TextChanged(object sender, EventArgs e)
        {
            txtReadedData.SelectionStart = txtReadedData.TextLength;
            txtReadedData.ScrollToCaret();
            txtReadedData.Refresh();
        }

        private void drpActionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (drpActionType.SelectedValue.ToString() == ((int)EnumActionType.Bekle).ToString())
            {
                pnlWaitingSecondPanel.Visible = true;
            }
            else
            {
                pnlWaitingSecondPanel.Visible = false;
            }
        }

        private void lstbxRecord_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isEditAction)
                return;

            editBotAction = null;

            int selectedIndex = lstbxRecord.SelectedIndex;

            if (actionListLastSelectedIndex == selectedIndex)
            {
                macroEditDataClear();
                mouseFunctionEditScreen(false);
                drawScreen.cleandraw();
                return;
            }

            if (actionListLastSelectedIndex != -1)
                drawScreen.cleandraw();


            actionListLastSelectedIndex = selectedIndex;

            editBotAction = _actionRepository.actionList.Where(a => a.actionQueue == selectedIndex).FirstOrDefault();


            if (editBotAction.actionID == (int)EnumActionType.EkranOku)
            {
                showEditScreenReadInfo();
                rectangleFunctionEditScreen(true);

                ScreenReadActionList screenAction = _actionRepository.getScreenAction(editBotAction.screenReadID);

                if (screenAction != null)
                    drawScreen.drawRectangleInScreen(screenAction.xCoordinate, screenAction.yCoordinate, screenAction.width, screenAction.height);
            }
            else
            {
                mouseFunctionEditScreen(true);
                showEditMouseInfo();
                drawScreen.drawPointInScreen(editBotAction.xCoordinate, editBotAction.yCoordinate);
            }
        }

        private void btnRectangleCancel_Click(object sender, EventArgs e)
        {
            clearRectangle();
            enabledAllButton();
            clearCoordinateTextboxes();
            closeRectangleRecord();

            if (isEditAction && recordRectangleCreate)
                macroEditDataClear();
        }

        private void btnRectangleEdit_Click(object sender, EventArgs e)
        {
            startRectangleRecord();
            isEditAction = true;
        }


        private void btnMouseEdit_Click(object sender, EventArgs e)
        {
            if (drpActionType.SelectedValue.ToString() == ((int)EnumActionType.Bekle).ToString())
                mouseRecordButtonFunction(true);
            else
            {
                isEditAction = true;
                mouseRecordButtonFunction(false);
            }

            btnMouseEdit.Enabled = false;
        }

        private void btnEditMouseCancel_Click(object sender, EventArgs e)
        {
            macroEditDataClear();
        }
        #endregion
    }
}


