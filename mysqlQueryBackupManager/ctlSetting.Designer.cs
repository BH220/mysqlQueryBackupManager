namespace mysqlQueryBackupManager
{
    partial class ctlSetting
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gridSetting = new System.Windows.Forms.DataGridView();
            this.colSessionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbKey = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.cmbDay = new System.Windows.Forms.ComboBox();
            this.chkSat = new System.Windows.Forms.CheckBox();
            this.chkFri = new System.Windows.Forms.CheckBox();
            this.chkThr = new System.Windows.Forms.CheckBox();
            this.chkWen = new System.Windows.Forms.CheckBox();
            this.chkTue = new System.Windows.Forms.CheckBox();
            this.chkMon = new System.Windows.Forms.CheckBox();
            this.chkSun = new System.Windows.Forms.CheckBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.cmbMinute = new System.Windows.Forms.ComboBox();
            this.cmbHour = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.cmbRepeat = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbSavePath = new System.Windows.Forms.TextBox();
            this.btnSelectSaveFolder = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.tbIgnoreTable = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbNouseSsh = new System.Windows.Forms.RadioButton();
            this.rbUseSsh = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbHost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUserId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSelectPemPpk = new System.Windows.Forms.Button();
            this.tbUserPw = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.tbSshLocalPort = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbSshPemPpk = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbSshHost = new System.Windows.Forms.TextBox();
            this.tbSshUserId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbSshPort = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSetting)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gridSetting);
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Panel2MinSize = 432;
            this.splitContainer1.Size = new System.Drawing.Size(920, 670);
            this.splitContainer1.SplitterDistance = 478;
            this.splitContainer1.TabIndex = 3;
            // 
            // gridSetting
            // 
            this.gridSetting.AllowUserToAddRows = false;
            this.gridSetting.AllowUserToDeleteRows = false;
            this.gridSetting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSetting.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSessionName,
            this.colHost});
            this.gridSetting.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gridSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSetting.Location = new System.Drawing.Point(0, 0);
            this.gridSetting.MultiSelect = false;
            this.gridSetting.Name = "gridSetting";
            this.gridSetting.ReadOnly = true;
            this.gridSetting.RowHeadersVisible = false;
            this.gridSetting.RowTemplate.Height = 23;
            this.gridSetting.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSetting.Size = new System.Drawing.Size(478, 637);
            this.gridSetting.TabIndex = 0;
            this.gridSetting.DataSourceChanged += new System.EventHandler(this.gridSetting_DataSourceChanged);
            this.gridSetting.CurrentCellChanged += new System.EventHandler(this.gridSetting_CurrentCellChanged);
            // 
            // colSessionName
            // 
            this.colSessionName.DataPropertyName = "Name";
            this.colSessionName.HeaderText = "세션이름";
            this.colSessionName.Name = "colSessionName";
            this.colSessionName.ReadOnly = true;
            // 
            // colHost
            // 
            this.colHost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colHost.DataPropertyName = "HostName";
            this.colHost.HeaderText = "호스트";
            this.colHost.Name = "colHost";
            this.colHost.ReadOnly = true;
            this.colHost.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnNew);
            this.flowLayoutPanel1.Controls.Add(this.btnDel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 637);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(478, 33);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(3, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 24;
            this.btnNew.Text = "신규";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(84, 3);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 25;
            this.btnDel.Text = "삭제";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbKey);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 670);
            this.panel1.TabIndex = 0;
            // 
            // lbKey
            // 
            this.lbKey.Location = new System.Drawing.Point(44, 561);
            this.lbKey.Name = "lbKey";
            this.lbKey.Size = new System.Drawing.Size(80, 21);
            this.lbKey.TabIndex = 48;
            this.lbKey.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbKey.Visible = false;
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(6, 561);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(32, 21);
            this.label19.TabIndex = 47;
            this.label19.Text = "Key:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label19.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.cmbDay);
            this.groupBox3.Controls.Add(this.chkSat);
            this.groupBox3.Controls.Add(this.chkFri);
            this.groupBox3.Controls.Add(this.chkThr);
            this.groupBox3.Controls.Add(this.chkWen);
            this.groupBox3.Controls.Add(this.chkTue);
            this.groupBox3.Controls.Add(this.chkMon);
            this.groupBox3.Controls.Add(this.chkSun);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.cmbMinute);
            this.groupBox3.Controls.Add(this.cmbHour);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.cmbRepeat);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 429);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(438, 126);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "스케줄링 정보";
            // 
            // label23
            // 
            this.label23.Location = new System.Drawing.Point(211, 43);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(25, 21);
            this.label23.TabIndex = 4;
            this.label23.Text = "일";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbDay
            // 
            this.cmbDay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDay.FormattingEnabled = true;
            this.cmbDay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cmbDay.Location = new System.Drawing.Point(130, 44);
            this.cmbDay.Name = "cmbDay";
            this.cmbDay.Size = new System.Drawing.Size(76, 20);
            this.cmbDay.TabIndex = 3;
            // 
            // chkSat
            // 
            this.chkSat.AutoSize = true;
            this.chkSat.Enabled = false;
            this.chkSat.Location = new System.Drawing.Point(381, 72);
            this.chkSat.Name = "chkSat";
            this.chkSat.Size = new System.Drawing.Size(36, 16);
            this.chkSat.TabIndex = 12;
            this.chkSat.Text = "토";
            this.chkSat.UseVisualStyleBackColor = true;
            // 
            // chkFri
            // 
            this.chkFri.AutoSize = true;
            this.chkFri.Enabled = false;
            this.chkFri.Location = new System.Drawing.Point(339, 72);
            this.chkFri.Name = "chkFri";
            this.chkFri.Size = new System.Drawing.Size(36, 16);
            this.chkFri.TabIndex = 11;
            this.chkFri.Text = "금";
            this.chkFri.UseVisualStyleBackColor = true;
            // 
            // chkThr
            // 
            this.chkThr.AutoSize = true;
            this.chkThr.Enabled = false;
            this.chkThr.Location = new System.Drawing.Point(297, 72);
            this.chkThr.Name = "chkThr";
            this.chkThr.Size = new System.Drawing.Size(36, 16);
            this.chkThr.TabIndex = 10;
            this.chkThr.Text = "목";
            this.chkThr.UseVisualStyleBackColor = true;
            // 
            // chkWen
            // 
            this.chkWen.AutoSize = true;
            this.chkWen.Enabled = false;
            this.chkWen.Location = new System.Drawing.Point(255, 72);
            this.chkWen.Name = "chkWen";
            this.chkWen.Size = new System.Drawing.Size(36, 16);
            this.chkWen.TabIndex = 9;
            this.chkWen.Text = "수";
            this.chkWen.UseVisualStyleBackColor = true;
            // 
            // chkTue
            // 
            this.chkTue.AutoSize = true;
            this.chkTue.Enabled = false;
            this.chkTue.Location = new System.Drawing.Point(213, 72);
            this.chkTue.Name = "chkTue";
            this.chkTue.Size = new System.Drawing.Size(36, 16);
            this.chkTue.TabIndex = 8;
            this.chkTue.Text = "화";
            this.chkTue.UseVisualStyleBackColor = true;
            // 
            // chkMon
            // 
            this.chkMon.AutoSize = true;
            this.chkMon.Enabled = false;
            this.chkMon.Location = new System.Drawing.Point(172, 72);
            this.chkMon.Name = "chkMon";
            this.chkMon.Size = new System.Drawing.Size(36, 16);
            this.chkMon.TabIndex = 7;
            this.chkMon.Text = "월";
            this.chkMon.UseVisualStyleBackColor = true;
            // 
            // chkSun
            // 
            this.chkSun.AutoSize = true;
            this.chkSun.Enabled = false;
            this.chkSun.Location = new System.Drawing.Point(130, 72);
            this.chkSun.Name = "chkSun";
            this.chkSun.Size = new System.Drawing.Size(36, 16);
            this.chkSun.TabIndex = 6;
            this.chkSun.Text = "일";
            this.chkSun.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(323, 96);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(25, 21);
            this.label20.TabIndex = 17;
            this.label20.Text = "분";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(211, 96);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(25, 21);
            this.label21.TabIndex = 15;
            this.label21.Text = "시";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbMinute
            // 
            this.cmbMinute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMinute.FormattingEnabled = true;
            this.cmbMinute.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cmbMinute.Location = new System.Drawing.Point(242, 96);
            this.cmbMinute.Name = "cmbMinute";
            this.cmbMinute.Size = new System.Drawing.Size(75, 20);
            this.cmbMinute.TabIndex = 16;
            // 
            // cmbHour
            // 
            this.cmbHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHour.FormattingEnabled = true;
            this.cmbHour.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cmbHour.Location = new System.Drawing.Point(130, 96);
            this.cmbHour.Name = "cmbHour";
            this.cmbHour.Size = new System.Drawing.Size(75, 20);
            this.cmbHour.TabIndex = 14;
            // 
            // label25
            // 
            this.label25.Location = new System.Drawing.Point(6, 96);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(118, 21);
            this.label25.TabIndex = 13;
            this.label25.Text = "시간";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(6, 70);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(118, 21);
            this.label22.TabIndex = 5;
            this.label22.Text = "요일";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbRepeat
            // 
            this.cmbRepeat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbRepeat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRepeat.FormattingEnabled = true;
            this.cmbRepeat.Items.AddRange(new object[] {
            "선 택",
            "한 번",
            "매 월",
            "매 주",
            "매 일"});
            this.cmbRepeat.Location = new System.Drawing.Point(130, 17);
            this.cmbRepeat.Name = "cmbRepeat";
            this.cmbRepeat.Size = new System.Drawing.Size(298, 20);
            this.cmbRepeat.TabIndex = 1;
            this.cmbRepeat.SelectedIndexChanged += new System.EventHandler(this.cmbRepeat_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(6, 44);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(118, 21);
            this.label18.TabIndex = 2;
            this.label18.Text = "일";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(6, 17);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(118, 21);
            this.label17.TabIndex = 0;
            this.label17.Text = "반복주기";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.Dock = System.Windows.Forms.DockStyle.Top;
            this.label16.Location = new System.Drawing.Point(0, 419);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(438, 10);
            this.label16.TabIndex = 33;
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.tbSavePath);
            this.groupBox2.Controls.Add(this.btnSelectSaveFolder);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.tbIgnoreTable);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 343);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(438, 76);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "저장 정보";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(6, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 21);
            this.label12.TabIndex = 0;
            this.label12.Text = "저장경로";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbSavePath
            // 
            this.tbSavePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSavePath.Location = new System.Drawing.Point(130, 17);
            this.tbSavePath.Name = "tbSavePath";
            this.tbSavePath.ReadOnly = true;
            this.tbSavePath.Size = new System.Drawing.Size(208, 21);
            this.tbSavePath.TabIndex = 2;
            // 
            // btnSelectSaveFolder
            // 
            this.btnSelectSaveFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectSaveFolder.Location = new System.Drawing.Point(344, 16);
            this.btnSelectSaveFolder.Name = "btnSelectSaveFolder";
            this.btnSelectSaveFolder.Size = new System.Drawing.Size(84, 23);
            this.btnSelectSaveFolder.TabIndex = 1;
            this.btnSelectSaveFolder.Text = "폴더선택";
            this.btnSelectSaveFolder.UseVisualStyleBackColor = true;
            this.btnSelectSaveFolder.Click += new System.EventHandler(this.btnSelectSaveFolder_Click);
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(6, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 21);
            this.label13.TabIndex = 3;
            this.label13.Text = "제외 테이블";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbIgnoreTable
            // 
            this.tbIgnoreTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbIgnoreTable.Location = new System.Drawing.Point(130, 44);
            this.tbIgnoreTable.Name = "tbIgnoreTable";
            this.tbIgnoreTable.Size = new System.Drawing.Size(298, 21);
            this.tbIgnoreTable.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.Dock = System.Windows.Forms.DockStyle.Top;
            this.label15.Location = new System.Drawing.Point(0, 333);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(438, 10);
            this.label15.TabIndex = 32;
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbNouseSsh);
            this.groupBox1.Controls.Add(this.rbUseSsh);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.tbHost);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbUserId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnSelectPemPpk);
            this.groupBox1.Controls.Add(this.tbUserPw);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.tbPort);
            this.groupBox1.Controls.Add(this.tbSshLocalPort);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tbSshPemPpk);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbSshHost);
            this.groupBox1.Controls.Add(this.tbSshUserId);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbSshPort);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 323);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DB 정보";
            // 
            // rbNouseSsh
            // 
            this.rbNouseSsh.AutoSize = true;
            this.rbNouseSsh.Location = new System.Drawing.Point(228, 154);
            this.rbNouseSsh.Name = "rbNouseSsh";
            this.rbNouseSsh.Size = new System.Drawing.Size(71, 16);
            this.rbNouseSsh.TabIndex = 12;
            this.rbNouseSsh.TabStop = true;
            this.rbNouseSsh.Text = "사용안함";
            this.rbNouseSsh.UseVisualStyleBackColor = true;
            this.rbNouseSsh.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbUseSsh
            // 
            this.rbUseSsh.AutoSize = true;
            this.rbUseSsh.Location = new System.Drawing.Point(130, 154);
            this.rbUseSsh.Name = "rbUseSsh";
            this.rbUseSsh.Size = new System.Drawing.Size(47, 16);
            this.rbUseSsh.TabIndex = 11;
            this.rbUseSsh.TabStop = true;
            this.rbUseSsh.Text = "사용";
            this.rbUseSsh.UseVisualStyleBackColor = true;
            this.rbUseSsh.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "세션이름";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.Location = new System.Drawing.Point(130, 17);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(298, 21);
            this.tbName.TabIndex = 1;
            // 
            // tbHost
            // 
            this.tbHost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHost.Location = new System.Drawing.Point(130, 44);
            this.tbHost.Name = "tbHost";
            this.tbHost.Size = new System.Drawing.Size(298, 21);
            this.tbHost.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "호스트명/IP";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbUserId
            // 
            this.tbUserId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUserId.Location = new System.Drawing.Point(130, 71);
            this.tbUserId.Name = "tbUserId";
            this.tbUserId.Size = new System.Drawing.Size(298, 21);
            this.tbUserId.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "User ID";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSelectPemPpk
            // 
            this.btnSelectPemPpk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectPemPpk.Location = new System.Drawing.Point(344, 259);
            this.btnSelectPemPpk.Name = "btnSelectPemPpk";
            this.btnSelectPemPpk.Size = new System.Drawing.Size(84, 23);
            this.btnSelectPemPpk.TabIndex = 20;
            this.btnSelectPemPpk.Text = "파일선택";
            this.btnSelectPemPpk.UseVisualStyleBackColor = true;
            this.btnSelectPemPpk.Click += new System.EventHandler(this.btnSelectPemPpk_Click);
            // 
            // tbUserPw
            // 
            this.tbUserPw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUserPw.Location = new System.Drawing.Point(130, 98);
            this.tbUserPw.Name = "tbUserPw";
            this.tbUserPw.PasswordChar = '*';
            this.tbUserPw.Size = new System.Drawing.Size(298, 21);
            this.tbUserPw.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "User PW";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(6, 287);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 21);
            this.label11.TabIndex = 22;
            this.label11.Text = "로컬 포트";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbPort
            // 
            this.tbPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPort.Location = new System.Drawing.Point(130, 125);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(298, 21);
            this.tbPort.TabIndex = 9;
            this.tbPort.TextChanged += new System.EventHandler(this.tbNumber_TextChanged);
            this.tbPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumber_KeyPress);
            // 
            // tbSshLocalPort
            // 
            this.tbSshLocalPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSshLocalPort.Location = new System.Drawing.Point(130, 287);
            this.tbSshLocalPort.Name = "tbSshLocalPort";
            this.tbSshLocalPort.Size = new System.Drawing.Size(298, 21);
            this.tbSshLocalPort.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Port";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(6, 260);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 21);
            this.label10.TabIndex = 19;
            this.label10.Text = "개인키 파일";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbSshPemPpk
            // 
            this.tbSshPemPpk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSshPemPpk.Location = new System.Drawing.Point(130, 260);
            this.tbSshPemPpk.Name = "tbSshPemPpk";
            this.tbSshPemPpk.ReadOnly = true;
            this.tbSshPemPpk.Size = new System.Drawing.Size(208, 21);
            this.tbSshPemPpk.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "SSH 터널링";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(6, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 21);
            this.label9.TabIndex = 17;
            this.label9.Text = "SSH UserID";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbSshHost
            // 
            this.tbSshHost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSshHost.Location = new System.Drawing.Point(130, 179);
            this.tbSshHost.Name = "tbSshHost";
            this.tbSshHost.Size = new System.Drawing.Size(298, 21);
            this.tbSshHost.TabIndex = 14;
            // 
            // tbSshUserId
            // 
            this.tbSshUserId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSshUserId.Location = new System.Drawing.Point(130, 233);
            this.tbSshUserId.Name = "tbSshUserId";
            this.tbSshUserId.Size = new System.Drawing.Size(298, 21);
            this.tbSshUserId.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(6, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "SSH Host";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(6, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 21);
            this.label8.TabIndex = 15;
            this.label8.Text = "SSH Port";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbSshPort
            // 
            this.tbSshPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSshPort.Location = new System.Drawing.Point(130, 206);
            this.tbSshPort.Name = "tbSshPort";
            this.tbSshPort.Size = new System.Drawing.Size(298, 21);
            this.tbSshPort.TabIndex = 16;
            this.tbSshPort.TextChanged += new System.EventHandler(this.tbNumber_TextChanged);
            this.tbSshPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumber_KeyPress);
            // 
            // label14
            // 
            this.label14.Dock = System.Windows.Forms.DockStyle.Top;
            this.label14.Location = new System.Drawing.Point(0, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(438, 10);
            this.label14.TabIndex = 31;
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(130, 561);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ctlSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "ctlSetting";
            this.Size = new System.Drawing.Size(920, 670);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSetting)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView gridSetting;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSessionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHost;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cmbDay;
        private System.Windows.Forms.CheckBox chkSat;
        private System.Windows.Forms.CheckBox chkFri;
        private System.Windows.Forms.CheckBox chkThr;
        private System.Windows.Forms.CheckBox chkWen;
        private System.Windows.Forms.CheckBox chkTue;
        private System.Windows.Forms.CheckBox chkMon;
        private System.Windows.Forms.CheckBox chkSun;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cmbMinute;
        private System.Windows.Forms.ComboBox cmbHour;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cmbRepeat;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbSavePath;
        private System.Windows.Forms.Button btnSelectSaveFolder;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbIgnoreTable;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNouseSsh;
        private System.Windows.Forms.RadioButton rbUseSsh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbHost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUserId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSelectPemPpk;
        private System.Windows.Forms.TextBox tbUserPw;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.TextBox tbSshLocalPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbSshPemPpk;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbSshHost;
        private System.Windows.Forms.TextBox tbSshUserId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbSshPort;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbKey;
        private System.Windows.Forms.Label label19;
    }
}
