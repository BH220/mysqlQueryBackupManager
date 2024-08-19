namespace mysqlQueryBackupManager
{
    partial class ctlWork
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
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.gridWorking = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnStartForce = new System.Windows.Forms.Button();
            this.btnStopForce = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridWorking)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.gridWorking);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.textBox16);
            this.splitContainer2.Panel2.Controls.Add(this.flowLayoutPanel2);
            this.splitContainer2.Size = new System.Drawing.Size(920, 670);
            this.splitContainer2.SplitterDistance = 395;
            this.splitContainer2.TabIndex = 4;
            // 
            // gridWorking
            // 
            this.gridWorking.AllowUserToAddRows = false;
            this.gridWorking.AllowUserToDeleteRows = false;
            this.gridWorking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridWorking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.gridWorking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridWorking.Location = new System.Drawing.Point(0, 0);
            this.gridWorking.Name = "gridWorking";
            this.gridWorking.ReadOnly = true;
            this.gridWorking.RowTemplate.Height = 23;
            this.gridWorking.Size = new System.Drawing.Size(395, 670);
            this.gridWorking.TabIndex = 0;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "상태";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "세션이름";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "호스트";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // textBox16
            // 
            this.textBox16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox16.Location = new System.Drawing.Point(0, 33);
            this.textBox16.Multiline = true;
            this.textBox16.Name = "textBox16";
            this.textBox16.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox16.Size = new System.Drawing.Size(521, 637);
            this.textBox16.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnStartForce);
            this.flowLayoutPanel2.Controls.Add(this.btnStopForce);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(521, 33);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // btnStartForce
            // 
            this.btnStartForce.Location = new System.Drawing.Point(3, 3);
            this.btnStartForce.Name = "btnStartForce";
            this.btnStartForce.Size = new System.Drawing.Size(75, 23);
            this.btnStartForce.TabIndex = 0;
            this.btnStartForce.Text = "시작";
            this.btnStartForce.UseVisualStyleBackColor = true;
            // 
            // btnStopForce
            // 
            this.btnStopForce.Location = new System.Drawing.Point(84, 3);
            this.btnStopForce.Name = "btnStopForce";
            this.btnStopForce.Size = new System.Drawing.Size(75, 23);
            this.btnStopForce.TabIndex = 1;
            this.btnStopForce.Text = "중지";
            this.btnStopForce.UseVisualStyleBackColor = true;
            // 
            // ctkWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer2);
            this.Name = "ctkWork";
            this.Size = new System.Drawing.Size(920, 670);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridWorking)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView gridWorking;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnStartForce;
        private System.Windows.Forms.Button btnStopForce;
    }
}
