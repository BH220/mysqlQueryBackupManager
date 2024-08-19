namespace mysqlQueryBackupManager
{
    partial class frmMain
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ctlWork1 = new mysqlQueryBackupManager.ctlWork();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ctlHistory1 = new mysqlQueryBackupManager.ctlHistory();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ctlSetting1 = new mysqlQueryBackupManager.ctlSetting();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(927, 696);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ctlWork1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(919, 670);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "작업";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ctlWork1
            // 
            this.ctlWork1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlWork1.Location = new System.Drawing.Point(3, 3);
            this.ctlWork1.Name = "ctlWork1";
            this.ctlWork1.Size = new System.Drawing.Size(913, 664);
            this.ctlWork1.TabIndex = 0;
            this.ctlWork1.Load += new System.EventHandler(this.ctkWork1_Load);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ctlHistory1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(919, 670);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "이력";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ctlHistory1
            // 
            this.ctlHistory1.Location = new System.Drawing.Point(0, 0);
            this.ctlHistory1.Name = "ctlHistory1";
            this.ctlHistory1.Size = new System.Drawing.Size(920, 670);
            this.ctlHistory1.TabIndex = 0;
            this.ctlHistory1.Load += new System.EventHandler(this.ctkHistory1_Load);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ctlSetting1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(919, 670);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "설정";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ctlSetting1
            // 
            this.ctlSetting1.Location = new System.Drawing.Point(0, 0);
            this.ctlSetting1.Name = "ctlSetting1";
            this.ctlSetting1.Size = new System.Drawing.Size(920, 670);
            this.ctlSetting1.TabIndex = 0;
            this.ctlSetting1.Load += new System.EventHandler(this.ctlSetting1_Load);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 696);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmMain";
            this.Text = "MySQL DB Query 백업";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private ctlWork ctlWork1;
        private ctlHistory ctlHistory1;
        private ctlSetting ctlSetting1;
    }
}

