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

namespace MacroBot
{
    public partial class Form1 : Form
    {
        private bool recordIsActive = false;

        private bool recordRectangleCreate = false;

        private ActionRepository _actionRepository = null;

        private ExeProcesses _exeProcesses = null;

        private int actionQueue = 0;

        private int screadReadID = 1;

        private int rectangleCornerCount = 0;

        private CreatedRectangleInfo rectangleInfo = null;

        private List<RectangleCooridant> rectangleDrawingCoordiantList = null;

        private string exeName = string.Empty;

        private int repeatNumber = 0;

        private int repeatAfterSleepMilisecond = 0;

        private RunMacro rm = null;

        private Thread runMacroThread = null;

        public Form1()
        {
            try
            {
                InitializeComponent();
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                _actionRepository = new ActionRepository();
                addActionType();
                Hook.GlobalEvents().MouseClick += MouseClickAll;
                _exeProcesses = new ExeProcesses();
                rm = new RunMacro();
                rectangleInfo = new CreatedRectangleInfo();
                rectangleDrawingCoordiantList = new List<RectangleCooridant>();
                createRunMacroThreadInstance();
                clearOlderFiles();

            }
            catch (Exception ex)
            {
                showAlert(ex.Message);
                enabledAllButton();
            }
        }

        #region Methods

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
        /// Fare Hareketi Kayıt Sonrası İlgili Kontrol Değişkenini false yapar
        /// </summary>
        private void closeMouseRecord()
        {
            recordIsActive = false;
        }

        /// <summary>
        /// Dikdörtgen İçin Seçilen 4 Nokta İşleminden Sonra İlgili Kontrol Değişkenini false yapar
        /// </summary>
        private void closeRectangleRecord()
        {
            recordRectangleCreate = false;
        }

        /// <summary>
        /// İşlem Listesine İşlemi Yazdırır Ve Aksiyon Listesini Doldurur
        /// </summary>
        /// <param name="actionTypeName"></param>
        /// <param name="actionTypeValue"></param>
        /// <param name="xPoint"></param>
        /// <param name="yPoint"></param>
        /// <param name="screenReadID"></param>
        private void addListBox(string actionTypeName, int actionTypeValue, int xPoint, int yPoint, int screenReadID = 0)
        {
            if (actionTypeValue == 0)
            {
                clearAllProgramFunction();
                showAlert("İşlem Türü Yanlış: ID:" + actionTypeValue);
            }

            _actionRepository.addActionList(actionQueue, xPoint, yPoint, actionTypeValue, screenReadID);

            lstbxRecord.Items.Add(new { value = actionQueue, Name = actionTypeName + " - Coordinate: x:" + xPoint + " y:" + yPoint + " ActionID:" + actionTypeValue });

            actionQueue++;
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
        }

        private void exeForegroundWindow()
        {
            _exeProcesses.ekranionegetir();
        }

        private void showAlert(string text)
        {
            MessageBox.Show(text, "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            enabledAllButton();
        }

        private void macroRunFunction()
        {
            bool macroFinishStatus = true;

            for (int i = 0; i < repeatNumber; i++)
            {
                var macroResult = rm.runMacro(_actionRepository.actionList, _actionRepository.screenReadActionList);

                if (macroResult.readedDataList.Count > 0)
                {
                    foreach (string item in macroResult.readedDataList)
                    {
                        addReadedData(item);
                    }
                }

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

        private void resetAllObject()
        {
            _exeProcesses = new ExeProcesses();
            rm = new RunMacro();
            _actionRepository = new ActionRepository();
            rectangleInfo = new CreatedRectangleInfo();
            rectangleDrawingCoordiantList = new List<RectangleCooridant>();
        }

        private void clearAllProgramFunction()
        {
            actionQueue = 0;
            screadReadID = 1;
            lstbxRecord.Items.Clear();
            txtReadedData.Clear();
            clearRectangle();
            resetAllObject();
            enabledAllButton();
        }

        private void fillCoordinateTextboxes(int index, int x, int y)
        {
            string name = "txtClick" + (index - 1);

            TextBox txt = (TextBox)pnlReadScreen.Controls.Find(name, true)[0];

            if (txt != null)
                txt.Text = x.ToString() + " " + y.ToString();
        }

        private void addReadedData(string data)
        {
            txtReadedData.Text += data;
            txtReadedData.Text += Environment.NewLine;
            txtReadedData.Text += "------------------";
            txtReadedData.Text += Environment.NewLine;
        }

        public void findedWord()
        {
            macroStatusText("Kelime Bulundu");
        }

        private void macroStatusText(string text)
        {
            lblMacroStart.Text = text;
        }

        private void createRunMacroThreadInstance()
        {
            runMacroThread = new Thread(macroRunFunction);
            runMacroThread.IsBackground = true;
        }

        private void stopRunMacroThread()
        {
            if (runMacroThread != null)
                runMacroThread.Abort();
        }

        private void clearOlderFiles()
        {
            MacroHelper.removeFiles(rm._screenshotService.getImagesFilePath());
        }

        private void setMacroSettingsInfo()
        {
            lblExeNameInfo.Text = exeName;
            lblRepeatNumberInfo.Text = repeatNumber.ToString();
            lblRepeatWaitingTimeInfo.Text = repeatAfterSleepMilisecond.ToString() + " Milisecond";
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

                    addListBox(selectedActionTypeName, selectedActionTypeID, mousePoint.X, mousePoint.Y);

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

                        rectangleInfo = _actionRepository.defineRectangle(rectangleDrawingCoordiantList);
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

        /// <summary>
        /// Dikdörtgen Click İşlemi Başlatıcısı
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRecordRectangle_Click(object sender, EventArgs e)
        {
            closeMouseRecord();
            disabledAllButton();
            recordRectangleCreate = true;
            exeForegroundWindow();
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
                string ekler = textBox1.Text;

                List<string> eklerList = new List<string>();

                if (!string.IsNullOrWhiteSpace(ekler))
                {
                    eklerList = ekler.Split(',').ToList();
                }

                _actionRepository.addScreenReadList(screadReadID, eklerList, rectangleInfo.xCoordinate, rectangleInfo.yCoordinate, rectangleInfo.width, rectangleInfo.height);

                addListBox("Ekran Oku", 5, rectangleInfo.xCoordinate, rectangleInfo.yCoordinate, screadReadID);

                screadReadID++;

                clearRectangle();
                enabledAllButton();
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
                }

            }
            catch (Exception ex)
            {
                showAlert(ex.Message);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            stopRunMacroThread();
        }

        private void txtReadedData_TextChanged(object sender, EventArgs e)
        {
            txtReadedData.SelectionStart = txtReadedData.TextLength;
            txtReadedData.ScrollToCaret();
            txtReadedData.Refresh();
        }

        #endregion




    }
}


