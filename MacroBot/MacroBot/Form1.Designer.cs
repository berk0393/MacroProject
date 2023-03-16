
namespace MacroBot
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstbxRecord = new System.Windows.Forms.ListBox();
            this.tbActionList = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbReadedData = new System.Windows.Forms.TabPage();
            this.txtReadedData = new System.Windows.Forms.TextBox();
            this.pnlReadScreen = new System.Windows.Forms.TabPage();
            this.btnRectangleEdit = new System.Windows.Forms.Button();
            this.btnRectangleCancel = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtClick3 = new System.Windows.Forms.TextBox();
            this.txtClick2 = new System.Windows.Forms.TextBox();
            this.txtClick1 = new System.Windows.Forms.TextBox();
            this.txtClick0 = new System.Windows.Forms.TextBox();
            this.txtSearchedText = new System.Windows.Forms.TextBox();
            this.txtRecH = new System.Windows.Forms.TextBox();
            this.txtRecY = new System.Windows.Forms.TextBox();
            this.txtRecW = new System.Windows.Forms.TextBox();
            this.txtRecX = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSaveRectangle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblHata = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRecordRectangle = new System.Windows.Forms.Button();
            this.pnlMouse = new System.Windows.Forms.TabPage();
            this.pnlMouseEdit = new System.Windows.Forms.Panel();
            this.btnEditMouseCancel = new System.Windows.Forms.Button();
            this.btnMouseEdit = new System.Windows.Forms.Button();
            this.pnlWaitingSecondPanel = new System.Windows.Forms.Panel();
            this.label27 = new System.Windows.Forms.Label();
            this.txtWaitingSecond = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.drpActionType = new System.Windows.Forms.ComboBox();
            this.btnRecord = new System.Windows.Forms.Button();
            this.pnlMacroSettings = new System.Windows.Forms.TabPage();
            this.lblMacroStopInfo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRepeatWaitingTimeInfo = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lblRepeatNumberInfo = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lblExeNameInfo = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtWaitingTime = new System.Windows.Forms.TextBox();
            this.txtRepeatNumber = new System.Windows.Forms.TextBox();
            this.txtExeName = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblMacroStart = new System.Windows.Forms.Label();
            this.lblWarningInfoSave = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnAllProgramClear = new System.Windows.Forms.Button();
            this.btnMacroSettingSave = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tblControl = new System.Windows.Forms.TabControl();
            this.tbActionList.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tbReadedData.SuspendLayout();
            this.pnlReadScreen.SuspendLayout();
            this.pnlMouse.SuspendLayout();
            this.pnlMouseEdit.SuspendLayout();
            this.pnlWaitingSecondPanel.SuspendLayout();
            this.pnlMacroSettings.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tblControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstbxRecord
            // 
            this.lstbxRecord.FormattingEnabled = true;
            this.lstbxRecord.Location = new System.Drawing.Point(5, 3);
            this.lstbxRecord.Name = "lstbxRecord";
            this.lstbxRecord.Size = new System.Drawing.Size(439, 498);
            this.lstbxRecord.TabIndex = 0;
            this.lstbxRecord.SelectedIndexChanged += new System.EventHandler(this.lstbxRecord_SelectedIndexChanged);
            // 
            // tbActionList
            // 
            this.tbActionList.Controls.Add(this.tabPage1);
            this.tbActionList.Controls.Add(this.tbReadedData);
            this.tbActionList.Location = new System.Drawing.Point(807, 23);
            this.tbActionList.Name = "tbActionList";
            this.tbActionList.SelectedIndex = 0;
            this.tbActionList.Size = new System.Drawing.Size(458, 533);
            this.tbActionList.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lstbxRecord);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(450, 507);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Aksiyon Listesi";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tbReadedData
            // 
            this.tbReadedData.Controls.Add(this.txtReadedData);
            this.tbReadedData.Location = new System.Drawing.Point(4, 22);
            this.tbReadedData.Name = "tbReadedData";
            this.tbReadedData.Padding = new System.Windows.Forms.Padding(3);
            this.tbReadedData.Size = new System.Drawing.Size(450, 507);
            this.tbReadedData.TabIndex = 1;
            this.tbReadedData.Text = "Okunan Datalar";
            this.tbReadedData.UseVisualStyleBackColor = true;
            // 
            // txtReadedData
            // 
            this.txtReadedData.Location = new System.Drawing.Point(7, 7);
            this.txtReadedData.Multiline = true;
            this.txtReadedData.Name = "txtReadedData";
            this.txtReadedData.ReadOnly = true;
            this.txtReadedData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReadedData.Size = new System.Drawing.Size(437, 494);
            this.txtReadedData.TabIndex = 0;
            this.txtReadedData.TextChanged += new System.EventHandler(this.txtReadedData_TextChanged);
            // 
            // pnlReadScreen
            // 
            this.pnlReadScreen.Controls.Add(this.btnRectangleEdit);
            this.pnlReadScreen.Controls.Add(this.btnRectangleCancel);
            this.pnlReadScreen.Controls.Add(this.label20);
            this.pnlReadScreen.Controls.Add(this.label19);
            this.pnlReadScreen.Controls.Add(this.txtClick3);
            this.pnlReadScreen.Controls.Add(this.txtClick2);
            this.pnlReadScreen.Controls.Add(this.txtClick1);
            this.pnlReadScreen.Controls.Add(this.txtClick0);
            this.pnlReadScreen.Controls.Add(this.txtSearchedText);
            this.pnlReadScreen.Controls.Add(this.txtRecH);
            this.pnlReadScreen.Controls.Add(this.txtRecY);
            this.pnlReadScreen.Controls.Add(this.txtRecW);
            this.pnlReadScreen.Controls.Add(this.txtRecX);
            this.pnlReadScreen.Controls.Add(this.label18);
            this.pnlReadScreen.Controls.Add(this.label17);
            this.pnlReadScreen.Controls.Add(this.label16);
            this.pnlReadScreen.Controls.Add(this.label15);
            this.pnlReadScreen.Controls.Add(this.label14);
            this.pnlReadScreen.Controls.Add(this.label13);
            this.pnlReadScreen.Controls.Add(this.label12);
            this.pnlReadScreen.Controls.Add(this.label11);
            this.pnlReadScreen.Controls.Add(this.label10);
            this.pnlReadScreen.Controls.Add(this.btnSaveRectangle);
            this.pnlReadScreen.Controls.Add(this.label5);
            this.pnlReadScreen.Controls.Add(this.lblHata);
            this.pnlReadScreen.Controls.Add(this.label4);
            this.pnlReadScreen.Controls.Add(this.label3);
            this.pnlReadScreen.Controls.Add(this.label2);
            this.pnlReadScreen.Controls.Add(this.label1);
            this.pnlReadScreen.Controls.Add(this.btnRecordRectangle);
            this.pnlReadScreen.Location = new System.Drawing.Point(4, 22);
            this.pnlReadScreen.Name = "pnlReadScreen";
            this.pnlReadScreen.Padding = new System.Windows.Forms.Padding(3);
            this.pnlReadScreen.Size = new System.Drawing.Size(767, 507);
            this.pnlReadScreen.TabIndex = 1;
            this.pnlReadScreen.Text = "Ekran Okuma";
            this.pnlReadScreen.UseVisualStyleBackColor = true;
            // 
            // btnRectangleEdit
            // 
            this.btnRectangleEdit.BackColor = System.Drawing.Color.Orange;
            this.btnRectangleEdit.ForeColor = System.Drawing.Color.White;
            this.btnRectangleEdit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRectangleEdit.Location = new System.Drawing.Point(158, 114);
            this.btnRectangleEdit.Name = "btnRectangleEdit";
            this.btnRectangleEdit.Size = new System.Drawing.Size(100, 23);
            this.btnRectangleEdit.TabIndex = 30;
            this.btnRectangleEdit.Text = "Yeni Dikdörtgen Çiz";
            this.btnRectangleEdit.UseVisualStyleBackColor = false;
            this.btnRectangleEdit.Visible = false;
            this.btnRectangleEdit.Click += new System.EventHandler(this.btnRectangleEdit_Click);
            // 
            // btnRectangleCancel
            // 
            this.btnRectangleCancel.BackColor = System.Drawing.Color.Red;
            this.btnRectangleCancel.ForeColor = System.Drawing.Color.White;
            this.btnRectangleCancel.Location = new System.Drawing.Point(264, 114);
            this.btnRectangleCancel.Name = "btnRectangleCancel";
            this.btnRectangleCancel.Size = new System.Drawing.Size(100, 23);
            this.btnRectangleCancel.TabIndex = 29;
            this.btnRectangleCancel.Text = "İptal";
            this.btnRectangleCancel.UseVisualStyleBackColor = false;
            this.btnRectangleCancel.Click += new System.EventHandler(this.btnRectangleCancel_Click);
            // 
            // label20
            // 
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label20.Location = new System.Drawing.Point(4, 255);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(758, 2);
            this.label20.TabIndex = 28;
            // 
            // label19
            // 
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label19.Location = new System.Drawing.Point(3, 162);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(758, 2);
            this.label19.TabIndex = 27;
            // 
            // txtClick3
            // 
            this.txtClick3.Location = new System.Drawing.Point(587, 211);
            this.txtClick3.Name = "txtClick3";
            this.txtClick3.Size = new System.Drawing.Size(100, 20);
            this.txtClick3.TabIndex = 25;
            // 
            // txtClick2
            // 
            this.txtClick2.Location = new System.Drawing.Point(408, 211);
            this.txtClick2.Name = "txtClick2";
            this.txtClick2.Size = new System.Drawing.Size(100, 20);
            this.txtClick2.TabIndex = 26;
            // 
            // txtClick1
            // 
            this.txtClick1.Location = new System.Drawing.Point(237, 211);
            this.txtClick1.Name = "txtClick1";
            this.txtClick1.Size = new System.Drawing.Size(100, 20);
            this.txtClick1.TabIndex = 24;
            // 
            // txtClick0
            // 
            this.txtClick0.Location = new System.Drawing.Point(72, 211);
            this.txtClick0.Name = "txtClick0";
            this.txtClick0.Size = new System.Drawing.Size(100, 20);
            this.txtClick0.TabIndex = 23;
            // 
            // txtSearchedText
            // 
            this.txtSearchedText.Location = new System.Drawing.Point(461, 31);
            this.txtSearchedText.Multiline = true;
            this.txtSearchedText.Name = "txtSearchedText";
            this.txtSearchedText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSearchedText.Size = new System.Drawing.Size(226, 44);
            this.txtSearchedText.TabIndex = 11;
            // 
            // txtRecH
            // 
            this.txtRecH.Location = new System.Drawing.Point(262, 59);
            this.txtRecH.Name = "txtRecH";
            this.txtRecH.Size = new System.Drawing.Size(102, 20);
            this.txtRecH.TabIndex = 4;
            // 
            // txtRecY
            // 
            this.txtRecY.Location = new System.Drawing.Point(89, 58);
            this.txtRecY.Name = "txtRecY";
            this.txtRecY.Size = new System.Drawing.Size(100, 20);
            this.txtRecY.TabIndex = 3;
            // 
            // txtRecW
            // 
            this.txtRecW.Location = new System.Drawing.Point(262, 13);
            this.txtRecW.Name = "txtRecW";
            this.txtRecW.Size = new System.Drawing.Size(103, 20);
            this.txtRecW.TabIndex = 2;
            // 
            // txtRecX
            // 
            this.txtRecX.Location = new System.Drawing.Point(89, 13);
            this.txtRecX.Name = "txtRecX";
            this.txtRecX.Size = new System.Drawing.Size(100, 20);
            this.txtRecX.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(539, 214);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(42, 13);
            this.label18.TabIndex = 22;
            this.label18.Text = "Click 4:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(359, 211);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 13);
            this.label17.TabIndex = 21;
            this.label17.Text = "Click 3:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(188, 211);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 13);
            this.label16.TabIndex = 20;
            this.label16.Text = "Click 2:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(23, 211);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 13);
            this.label15.TabIndex = 19;
            this.label15.Text = "Click 1:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 183);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "Seçilen Pixel Alanları";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(458, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Taranacak Kelimeler";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(17, 418);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(477, 50);
            this.label12.TabIndex = 16;
            this.label12.Text = "Text\'de İstenilen Kelimeleri Virgül İle Yazın. \r\n\'Okunacak Ekranı Kaydet\' Tuşuna " +
    "Basın";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(17, 349);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(652, 50);
            this.label11.TabIndex = 15;
            this.label11.Text = "Okunacak Yeri Dikdörtgen Olacak Şekilde Farenin Sol Tık İle\r\nBelirleyin.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(17, 295);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(342, 25);
            this.label10.TabIndex = 14;
            this.label10.Text = "\'Dikdörtgen Çiz\' Tuşuna Basın. ";
            // 
            // btnSaveRectangle
            // 
            this.btnSaveRectangle.BackColor = System.Drawing.Color.Lime;
            this.btnSaveRectangle.Enabled = false;
            this.btnSaveRectangle.Location = new System.Drawing.Point(461, 114);
            this.btnSaveRectangle.Name = "btnSaveRectangle";
            this.btnSaveRectangle.Size = new System.Drawing.Size(226, 23);
            this.btnSaveRectangle.TabIndex = 13;
            this.btnSaveRectangle.Text = "Okunacak Ekranı Kaydet";
            this.btnSaveRectangle.UseVisualStyleBackColor = false;
            this.btnSaveRectangle.Click += new System.EventHandler(this.btnSaveRectangle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(458, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "ekadi1,ekadi2,ekadi3";
            // 
            // lblHata
            // 
            this.lblHata.AutoSize = true;
            this.lblHata.Location = new System.Drawing.Point(-1, 215);
            this.lblHata.Name = "lblHata";
            this.lblHata.Size = new System.Drawing.Size(0, 13);
            this.lblHata.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Y Coordinate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "X Coordinate";
            // 
            // btnRecordRectangle
            // 
            this.btnRecordRectangle.BackColor = System.Drawing.Color.Lime;
            this.btnRecordRectangle.Location = new System.Drawing.Point(158, 114);
            this.btnRecordRectangle.Name = "btnRecordRectangle";
            this.btnRecordRectangle.Size = new System.Drawing.Size(100, 23);
            this.btnRecordRectangle.TabIndex = 0;
            this.btnRecordRectangle.Text = "Dikdörtgen Çiz";
            this.btnRecordRectangle.UseVisualStyleBackColor = false;
            this.btnRecordRectangle.Click += new System.EventHandler(this.btnRecordRectangle_Click);
            // 
            // pnlMouse
            // 
            this.pnlMouse.Controls.Add(this.pnlMouseEdit);
            this.pnlMouse.Controls.Add(this.pnlWaitingSecondPanel);
            this.pnlMouse.Controls.Add(this.label9);
            this.pnlMouse.Controls.Add(this.label8);
            this.pnlMouse.Controls.Add(this.drpActionType);
            this.pnlMouse.Controls.Add(this.btnRecord);
            this.pnlMouse.Location = new System.Drawing.Point(4, 22);
            this.pnlMouse.Name = "pnlMouse";
            this.pnlMouse.Padding = new System.Windows.Forms.Padding(3);
            this.pnlMouse.Size = new System.Drawing.Size(767, 507);
            this.pnlMouse.TabIndex = 0;
            this.pnlMouse.Text = "Fare Hareketleri";
            this.pnlMouse.UseVisualStyleBackColor = true;
            // 
            // pnlMouseEdit
            // 
            this.pnlMouseEdit.Controls.Add(this.btnEditMouseCancel);
            this.pnlMouseEdit.Controls.Add(this.btnMouseEdit);
            this.pnlMouseEdit.Location = new System.Drawing.Point(110, 64);
            this.pnlMouseEdit.Name = "pnlMouseEdit";
            this.pnlMouseEdit.Size = new System.Drawing.Size(170, 29);
            this.pnlMouseEdit.TabIndex = 8;
            this.pnlMouseEdit.Visible = false;
            // 
            // btnEditMouseCancel
            // 
            this.btnEditMouseCancel.BackColor = System.Drawing.Color.Red;
            this.btnEditMouseCancel.ForeColor = System.Drawing.Color.White;
            this.btnEditMouseCancel.Location = new System.Drawing.Point(92, 0);
            this.btnEditMouseCancel.Name = "btnEditMouseCancel";
            this.btnEditMouseCancel.Size = new System.Drawing.Size(75, 29);
            this.btnEditMouseCancel.TabIndex = 1;
            this.btnEditMouseCancel.Text = "İptal";
            this.btnEditMouseCancel.UseVisualStyleBackColor = false;
            this.btnEditMouseCancel.Click += new System.EventHandler(this.btnEditMouseCancel_Click);
            // 
            // btnMouseEdit
            // 
            this.btnMouseEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMouseEdit.ForeColor = System.Drawing.Color.White;
            this.btnMouseEdit.Location = new System.Drawing.Point(0, 0);
            this.btnMouseEdit.Name = "btnMouseEdit";
            this.btnMouseEdit.Size = new System.Drawing.Size(75, 29);
            this.btnMouseEdit.TabIndex = 0;
            this.btnMouseEdit.Text = "Düzenle";
            this.btnMouseEdit.UseVisualStyleBackColor = false;
            this.btnMouseEdit.Click += new System.EventHandler(this.btnMouseEdit_Click);
            // 
            // pnlWaitingSecondPanel
            // 
            this.pnlWaitingSecondPanel.Controls.Add(this.label27);
            this.pnlWaitingSecondPanel.Controls.Add(this.txtWaitingSecond);
            this.pnlWaitingSecondPanel.Location = new System.Drawing.Point(253, 6);
            this.pnlWaitingSecondPanel.Name = "pnlWaitingSecondPanel";
            this.pnlWaitingSecondPanel.Size = new System.Drawing.Size(289, 52);
            this.pnlWaitingSecondPanel.TabIndex = 7;
            this.pnlWaitingSecondPanel.Visible = false;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(3, 20);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(139, 13);
            this.label27.TabIndex = 5;
            this.label27.Text = "Bekleme Süresi (Milisecond)";
            // 
            // txtWaitingSecond
            // 
            this.txtWaitingSecond.Location = new System.Drawing.Point(167, 20);
            this.txtWaitingSecond.Name = "txtWaitingSecond";
            this.txtWaitingSecond.Size = new System.Drawing.Size(100, 20);
            this.txtWaitingSecond.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(3, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(727, 25);
            this.label9.TabIndex = 4;
            this.label9.Text = "\'Kayıt Aç\' Tuşuna Basın. İşlem Yapılması İstenilen Yere Sol Tık Atın.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "İşlem Türü";
            // 
            // drpActionType
            // 
            this.drpActionType.FormattingEnabled = true;
            this.drpActionType.Location = new System.Drawing.Point(110, 25);
            this.drpActionType.Name = "drpActionType";
            this.drpActionType.Size = new System.Drawing.Size(121, 21);
            this.drpActionType.TabIndex = 2;
            this.drpActionType.SelectedIndexChanged += new System.EventHandler(this.drpActionType_SelectedIndexChanged);
            // 
            // btnRecord
            // 
            this.btnRecord.BackColor = System.Drawing.Color.Lime;
            this.btnRecord.ForeColor = System.Drawing.Color.Black;
            this.btnRecord.Location = new System.Drawing.Point(110, 64);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRecord.Size = new System.Drawing.Size(121, 23);
            this.btnRecord.TabIndex = 1;
            this.btnRecord.Text = "Kayıt Aç";
            this.btnRecord.UseVisualStyleBackColor = false;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // pnlMacroSettings
            // 
            this.pnlMacroSettings.Controls.Add(this.lblMacroStopInfo);
            this.pnlMacroSettings.Controls.Add(this.panel1);
            this.pnlMacroSettings.Controls.Add(this.label22);
            this.pnlMacroSettings.Controls.Add(this.txtWaitingTime);
            this.pnlMacroSettings.Controls.Add(this.txtRepeatNumber);
            this.pnlMacroSettings.Controls.Add(this.txtExeName);
            this.pnlMacroSettings.Controls.Add(this.label21);
            this.pnlMacroSettings.Controls.Add(this.btnStop);
            this.pnlMacroSettings.Controls.Add(this.lblMacroStart);
            this.pnlMacroSettings.Controls.Add(this.lblWarningInfoSave);
            this.pnlMacroSettings.Controls.Add(this.btnStart);
            this.pnlMacroSettings.Controls.Add(this.btnAllProgramClear);
            this.pnlMacroSettings.Controls.Add(this.btnMacroSettingSave);
            this.pnlMacroSettings.Controls.Add(this.label7);
            this.pnlMacroSettings.Controls.Add(this.label6);
            this.pnlMacroSettings.Location = new System.Drawing.Point(4, 22);
            this.pnlMacroSettings.Name = "pnlMacroSettings";
            this.pnlMacroSettings.Padding = new System.Windows.Forms.Padding(3);
            this.pnlMacroSettings.Size = new System.Drawing.Size(767, 507);
            this.pnlMacroSettings.TabIndex = 2;
            this.pnlMacroSettings.Text = "Macro Ayarları";
            this.pnlMacroSettings.UseVisualStyleBackColor = true;
            // 
            // lblMacroStopInfo
            // 
            this.lblMacroStopInfo.AutoSize = true;
            this.lblMacroStopInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblMacroStopInfo.ForeColor = System.Drawing.Color.Red;
            this.lblMacroStopInfo.Location = new System.Drawing.Point(214, 279);
            this.lblMacroStopInfo.Name = "lblMacroStopInfo";
            this.lblMacroStopInfo.Size = new System.Drawing.Size(116, 16);
            this.lblMacroStopInfo.TabIndex = 13;
            this.lblMacroStopInfo.Text = "F8 İle Macro Durur";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblRepeatWaitingTimeInfo);
            this.panel1.Controls.Add(this.label26);
            this.panel1.Controls.Add(this.lblRepeatNumberInfo);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.lblExeNameInfo);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Location = new System.Drawing.Point(403, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 142);
            this.panel1.TabIndex = 12;
            // 
            // lblRepeatWaitingTimeInfo
            // 
            this.lblRepeatWaitingTimeInfo.AutoSize = true;
            this.lblRepeatWaitingTimeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRepeatWaitingTimeInfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRepeatWaitingTimeInfo.Location = new System.Drawing.Point(207, 100);
            this.lblRepeatWaitingTimeInfo.Name = "lblRepeatWaitingTimeInfo";
            this.lblRepeatWaitingTimeInfo.Size = new System.Drawing.Size(0, 15);
            this.lblRepeatWaitingTimeInfo.TabIndex = 1;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label26.ForeColor = System.Drawing.Color.Red;
            this.label26.Location = new System.Drawing.Point(20, 100);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(187, 15);
            this.label26.TabIndex = 1;
            this.label26.Text = "İşlem Arası Bekleme Süresi:";
            // 
            // lblRepeatNumberInfo
            // 
            this.lblRepeatNumberInfo.AutoSize = true;
            this.lblRepeatNumberInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRepeatNumberInfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRepeatNumberInfo.Location = new System.Drawing.Point(114, 73);
            this.lblRepeatNumberInfo.Name = "lblRepeatNumberInfo";
            this.lblRepeatNumberInfo.Size = new System.Drawing.Size(0, 15);
            this.lblRepeatNumberInfo.TabIndex = 1;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label25.ForeColor = System.Drawing.Color.Red;
            this.label25.Location = new System.Drawing.Point(20, 73);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(94, 15);
            this.label25.TabIndex = 1;
            this.label25.Text = "Tekrar Sayısı:";
            // 
            // lblExeNameInfo
            // 
            this.lblExeNameInfo.AutoSize = true;
            this.lblExeNameInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblExeNameInfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblExeNameInfo.Location = new System.Drawing.Point(79, 46);
            this.lblExeNameInfo.Name = "lblExeNameInfo";
            this.lblExeNameInfo.Size = new System.Drawing.Size(0, 15);
            this.lblExeNameInfo.TabIndex = 1;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label24.ForeColor = System.Drawing.Color.Red;
            this.label24.Location = new System.Drawing.Point(20, 46);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(59, 15);
            this.label24.TabIndex = 1;
            this.label24.Text = "Exe Adı:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label23.Location = new System.Drawing.Point(19, 4);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(127, 20);
            this.label23.TabIndex = 0;
            this.label23.Text = "Mevcut Ayarlar";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.ForeColor = System.Drawing.Color.Red;
            this.label22.Location = new System.Drawing.Point(13, 157);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(301, 16);
            this.label22.TabIndex = 11;
            this.label22.Text = "Tekrarlar Arası Bekleme Süresi (milisecond cinsi)";
            // 
            // txtWaitingTime
            // 
            this.txtWaitingTime.Location = new System.Drawing.Point(149, 125);
            this.txtWaitingTime.Name = "txtWaitingTime";
            this.txtWaitingTime.Size = new System.Drawing.Size(100, 20);
            this.txtWaitingTime.TabIndex = 10;
            this.txtWaitingTime.Text = "50";
            // 
            // txtRepeatNumber
            // 
            this.txtRepeatNumber.Location = new System.Drawing.Point(149, 77);
            this.txtRepeatNumber.Name = "txtRepeatNumber";
            this.txtRepeatNumber.Size = new System.Drawing.Size(100, 20);
            this.txtRepeatNumber.TabIndex = 3;
            // 
            // txtExeName
            // 
            this.txtExeName.Location = new System.Drawing.Point(149, 31);
            this.txtExeName.Name = "txtExeName";
            this.txtExeName.Size = new System.Drawing.Size(100, 20);
            this.txtExeName.TabIndex = 0;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(13, 120);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(101, 26);
            this.label21.TabIndex = 9;
            this.label21.Text = "İşlem Arası Bekleme\r\nSüresi\r\n";
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.Location = new System.Drawing.Point(217, 244);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(100, 23);
            this.btnStop.TabIndex = 8;
            this.btnStop.Text = "Macro Durdur";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblMacroStart
            // 
            this.lblMacroStart.BackColor = System.Drawing.Color.Black;
            this.lblMacroStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMacroStart.ForeColor = System.Drawing.Color.White;
            this.lblMacroStart.Location = new System.Drawing.Point(9, 369);
            this.lblMacroStart.Name = "lblMacroStart";
            this.lblMacroStart.Size = new System.Drawing.Size(342, 20);
            this.lblMacroStart.TabIndex = 7;
            this.lblMacroStart.Text = "Macro Durumu";
            // 
            // lblWarningInfoSave
            // 
            this.lblWarningInfoSave.AutoSize = true;
            this.lblWarningInfoSave.BackColor = System.Drawing.Color.Red;
            this.lblWarningInfoSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWarningInfoSave.ForeColor = System.Drawing.Color.White;
            this.lblWarningInfoSave.Location = new System.Drawing.Point(9, 323);
            this.lblWarningInfoSave.Name = "lblWarningInfoSave";
            this.lblWarningInfoSave.Size = new System.Drawing.Size(180, 20);
            this.lblWarningInfoSave.TabIndex = 7;
            this.lblWarningInfoSave.Text = "Bilgiler Kayıt Edilmedi";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnStart.Enabled = false;
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(111, 244);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 23);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Macro Başlat";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnAllProgramClear
            // 
            this.btnAllProgramClear.BackColor = System.Drawing.Color.Red;
            this.btnAllProgramClear.ForeColor = System.Drawing.Color.Snow;
            this.btnAllProgramClear.Location = new System.Drawing.Point(111, 204);
            this.btnAllProgramClear.Name = "btnAllProgramClear";
            this.btnAllProgramClear.Size = new System.Drawing.Size(100, 23);
            this.btnAllProgramClear.TabIndex = 5;
            this.btnAllProgramClear.Text = "Her Şeyi Temizle";
            this.btnAllProgramClear.UseVisualStyleBackColor = false;
            this.btnAllProgramClear.Click += new System.EventHandler(this.btnAllProgramClear_Click);
            // 
            // btnMacroSettingSave
            // 
            this.btnMacroSettingSave.BackColor = System.Drawing.Color.Yellow;
            this.btnMacroSettingSave.ForeColor = System.Drawing.Color.Black;
            this.btnMacroSettingSave.Location = new System.Drawing.Point(217, 204);
            this.btnMacroSettingSave.Name = "btnMacroSettingSave";
            this.btnMacroSettingSave.Size = new System.Drawing.Size(100, 23);
            this.btnMacroSettingSave.TabIndex = 4;
            this.btnMacroSettingSave.Text = "Bilgileri Kaydet";
            this.btnMacroSettingSave.UseVisualStyleBackColor = false;
            this.btnMacroSettingSave.Click += new System.EventHandler(this.btnMacroSettingSave_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tekrar Sayısı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "İlgili Exe Adı (task manager)";
            // 
            // tblControl
            // 
            this.tblControl.Controls.Add(this.pnlMacroSettings);
            this.tblControl.Controls.Add(this.pnlMouse);
            this.tblControl.Controls.Add(this.pnlReadScreen);
            this.tblControl.Location = new System.Drawing.Point(12, 23);
            this.tblControl.Name = "tblControl";
            this.tblControl.SelectedIndex = 0;
            this.tblControl.Size = new System.Drawing.Size(775, 533);
            this.tblControl.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 568);
            this.Controls.Add(this.tbActionList);
            this.Controls.Add(this.tblControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tbActionList.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tbReadedData.ResumeLayout(false);
            this.tbReadedData.PerformLayout();
            this.pnlReadScreen.ResumeLayout(false);
            this.pnlReadScreen.PerformLayout();
            this.pnlMouse.ResumeLayout(false);
            this.pnlMouse.PerformLayout();
            this.pnlMouseEdit.ResumeLayout(false);
            this.pnlWaitingSecondPanel.ResumeLayout(false);
            this.pnlWaitingSecondPanel.PerformLayout();
            this.pnlMacroSettings.ResumeLayout(false);
            this.pnlMacroSettings.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tblControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstbxRecord;
        private System.Windows.Forms.TabControl tbActionList;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tbReadedData;
        private System.Windows.Forms.TextBox txtReadedData;
        private System.Windows.Forms.TabPage pnlReadScreen;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtClick3;
        private System.Windows.Forms.TextBox txtClick2;
        private System.Windows.Forms.TextBox txtClick1;
        private System.Windows.Forms.TextBox txtClick0;
        private System.Windows.Forms.TextBox txtSearchedText;
        private System.Windows.Forms.TextBox txtRecH;
        private System.Windows.Forms.TextBox txtRecY;
        private System.Windows.Forms.TextBox txtRecW;
        private System.Windows.Forms.TextBox txtRecX;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSaveRectangle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblHata;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRecordRectangle;
        private System.Windows.Forms.TabPage pnlMouse;
        private System.Windows.Forms.Panel pnlMouseEdit;
        private System.Windows.Forms.Button btnEditMouseCancel;
        private System.Windows.Forms.Button btnMouseEdit;
        private System.Windows.Forms.Panel pnlWaitingSecondPanel;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtWaitingSecond;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox drpActionType;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.TabPage pnlMacroSettings;
        private System.Windows.Forms.Label lblMacroStopInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRepeatWaitingTimeInfo;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lblRepeatNumberInfo;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lblExeNameInfo;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtWaitingTime;
        private System.Windows.Forms.TextBox txtRepeatNumber;
        private System.Windows.Forms.TextBox txtExeName;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblMacroStart;
        private System.Windows.Forms.Label lblWarningInfoSave;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnAllProgramClear;
        private System.Windows.Forms.Button btnMacroSettingSave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tblControl;
        private System.Windows.Forms.Button btnRectangleCancel;
        private System.Windows.Forms.Button btnRectangleEdit;
    }
}

