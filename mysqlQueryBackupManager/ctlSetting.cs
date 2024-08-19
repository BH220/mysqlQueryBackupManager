using BH_Library.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mysqlQueryBackupManager
{
    public partial class ctlSetting : UserControl
    {
        int rowIdx = -1;
        List<SessionModel> datasource = new List<SessionModel>();
        public ctlSetting()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
#if DEBUG
            label19.Visible = lbKey.Visible = true;
#endif
            LoadData();
        }

        #region 데이터 로드
        public void LoadData()
        {
            gridSetting.DataSource = null;
            datasource = SessionManager.Instance.Data;
            gridSetting.DataSource = datasource;
            gridSetting.Refresh();
            if(datasource.Count == 0)
                btnNew_Click(null, null);
        }
        #endregion

        #region 버튼 이벤트
        private void btnNew_Click(object sender, EventArgs e)
        {
            List<GroupBox> groups = new List<GroupBox>()
            {
                groupBox1, groupBox2, groupBox3
            };
            groups.ForEach(x =>
            {
                foreach (Control ctl in x.Controls)
                {
                    try
                    {
                        TextBox tb = (TextBox)ctl;
                        if (tb != null)
                        {
                            tb.Text = "";
                        }
                    }catch { }
                }
            });
            rbNouseSsh.Checked = true;
            cmbRepeat.SelectedIndex = 0;
            lbKey.Text = string.Empty;
            tbName.Focus();

            
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (BhMsgBox.Confirm("삭제하시겠습니까?", "삭제") == DialogResult.OK)
            {
                MessageBox.Show("삭제처리");
            }
        }

        private void btnSelectPemPpk_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "PPK or PEM Files (*.ppk;*.pem)|*.ppk;*.pem";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    tbSshPemPpk.Text = ofd.FileName;
                }
            }
        }

        private void btnSelectSaveFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    tbSavePath.Text = fbd.SelectedPath;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SessionModel sm = null;
            if (string.IsNullOrEmpty(lbKey.Text))
            {//신규
                sm = new SessionModel();
                if (datasource.Count == 0)
                    sm.Seq = 1;
                else 
                    sm.Seq = datasource.Max(x => x.Seq) + 1;
            }
            else
            {//업데이트
                sm = datasource[rowIdx];
            }

            sm.Name = tbName.Text;
            sm.HostName = tbHost.Text;
            sm.UserId = tbUserId.Text;
            sm.UserPw = tbUserPw.Text;
            sm.Port = tbPort.Text.ToIntEx();
            sm.UseSsh = rbUseSsh.Checked;
            sm.SshHost = tbSshHost.Text;
            sm.SshPort = tbSshPort.Text.ToIntEx();
            sm.SshUserId = tbSshUserId.Text;
            sm.SshPemKey = tbSshPemPpk.Text;
            sm.SshLocalPort = tbSshLocalPort.Text.ToIntEx();
            sm.SavePath = tbSavePath.Text;
            sm.IgnoreTable = tbIgnoreTable.Text;
            sm.RepeatType = (RepeatTypes)cmbRepeat.SelectedIndex;
            sm.Day = cmbDay.SelectedIndex;
            sm.IsSunDay = chkSun.Checked;
            sm.IsMonDay = chkMon.Checked;
            sm.IsTueDay = chkTue.Checked;
            sm.IsWebDay = chkWen.Checked;
            sm.IsThrDay = chkThr.Checked;
            sm.IsFriDay = chkFri.Checked;
            sm.IsSatDay = chkSat.Checked;
            sm.Hour = cmbHour.SelectedIndex;
            sm.Minute = cmbMinute.SelectedIndex;

            if (string.IsNullOrEmpty(lbKey.Text))
                datasource.Add(sm);

            SessionManager.Instance.Data = datasource;
            SessionManager.Instance.Save();

            MessageBox.Show("저장되었습니다.", "저장", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
        }
        #endregion

        #region 기타 이벤트
        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            tbSshHost.Enabled
               = tbSshPort.Enabled
               = tbSshLocalPort.Enabled
               = tbSshPemPpk.Enabled
               = tbSshUserId.Enabled
               = btnSelectPemPpk.Enabled
               = rbUseSsh.Checked;
            if(rbNouseSsh.Checked)
            {
                tbSshHost.Text
               = tbSshPort.Text
               = tbSshLocalPort.Text
               = tbSshPemPpk.Text
               = tbSshUserId.Text
               = "";
            }
        }

        private void cmbRepeat_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<CheckBox> lstChk = new List<CheckBox>() { chkSun, chkMon, chkTue, chkWen, chkThr, chkFri, chkSat };
            List<ComboBox> lstTime = new List<ComboBox>() { cmbHour, cmbMinute };
            if(cmbRepeat.SelectedIndex == 0)
            {//선 택
                lstChk.ForEach(x => {
                    x.Enabled = false;
                    x.Checked = false;
                });
                lstTime.ForEach(x => {
                    x.Enabled = false;
                    x.SelectedIndex = -1;
                });
                cmbDay.SelectedIndex = -1;
                cmbDay.Enabled = false;
            }
            else if (cmbRepeat.SelectedIndex == 1 || cmbRepeat.SelectedIndex == 2 )
            {//한 번 || 매 월
                lstChk.ForEach(x => {
                    x.Enabled = false;
                    x.Checked = false;
                });
                lstTime.ForEach(x => {
                    x.Enabled = true;
                    x.SelectedIndex = -1;
                });
                cmbDay.SelectedIndex = -1;
                cmbDay.Enabled = true;
            }
            else if (cmbRepeat.SelectedIndex == 3)
            {//매 주
                lstChk.ForEach(x => {
                    x.Enabled = true;
                    x.Checked = false;
                });
                lstTime.ForEach(x => {
                    x.Enabled = true;
                    x.SelectedIndex = -1;
                });
                cmbDay.SelectedIndex = -1;
                cmbDay.Enabled = false;
            }
            else if (cmbRepeat.SelectedIndex == 4)
            {//매 일

                lstChk.ForEach(x => {
                    x.Enabled = false;
                    x.Checked = false;
                });
                lstTime.ForEach(x => {
                    x.Enabled = true;
                    x.SelectedIndex = -1;
                });
                cmbDay.SelectedIndex = -1;
                cmbDay.Enabled = false;
            }
        }

        private void tbNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 숫자와 제어 문자(백스페이스)만 허용
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // 숫자나 제어 문자가 아니면 입력을 무시
            }
        }

        private void tbNumber_TextChanged(object sender, EventArgs e)
        {
            // 정수만 포함되도록 텍스트를 필터링
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                string newText = "";
                foreach (char c in textBox.Text)
                {
                    if (char.IsDigit(c)) // 숫자만 허용
                    {
                        newText += c;
                    }
                }

                if (textBox.Text != newText)
                {
                    int selectionStart = textBox.SelectionStart - (textBox.Text.Length - newText.Length);
                    textBox.Text = newText;
                    textBox.SelectionStart = Math.Max(0, selectionStart);
                }
            }
        }
        #endregion

        #region 사용자 정의 이벤트
        private void FocusedRowChanged(int rowIndex)
        {
            if (datasource.Count <= rowIndex) return;
            SetInfo(datasource[rowIndex]);
            
        }

        private void SetInfo(SessionModel sm)
        {
            tbName.Text = sm.Name;
            tbHost.Text = sm.HostName;
            tbUserId.Text = sm.UserId; 
            tbUserPw.Text = sm.UserPw;
            tbPort.Text = sm.Port.ToString();

            tbSshHost.Text = sm.SshHost;
            tbSshLocalPort.Text = sm.SshLocalPort.ToString();
            tbSshUserId.Text = sm.SshUserId;
            tbSshPemPpk.Text = sm.SshPemKey;
            tbSshPort.Text = sm.SshPort.ToString();

            if (sm.UseSsh)
                rbUseSsh.Checked = true;
            else
                rbNouseSsh.Checked = true;
            tbSavePath.Text = sm.SavePath;
            tbIgnoreTable.Text = sm.IgnoreTable;

            if(sm.Day > 0)
                cmbDay.SelectedIndex = sm.Day - 1;
            else
                cmbDay.SelectedIndex = - 1;
            if(sm.Hour > 0)
                cmbHour.SelectedIndex = sm.Hour - 1;
            else 
                cmbHour.SelectedIndex = - 1;
            if(sm.Minute > 0)
                cmbMinute.SelectedIndex = sm.Minute - 1;
            else 
                cmbMinute.SelectedIndex = - 1;

            cmbRepeat.SelectedIndex = (int)sm.RepeatType;
            lbKey.Text = sm.Seq.ToString();
        }
        #endregion

        #region 그리드 이벤트
        private void gridSetting_CurrentCellChanged(object sender, EventArgs e)
        {
            if (gridSetting.CurrentRow != null)
            {
                if(rowIdx != gridSetting.CurrentRow.Index)
                {
                    rowIdx = gridSetting.CurrentRow.Index;
                    FocusedRowChanged(rowIdx);
                }
            }
        }

        private void gridSetting_DataSourceChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn dgc in gridSetting.Columns)
            {
                if(dgc.DataPropertyName == "Name")
                {
                    dgc.HeaderText = "세션이름";
                }
                else if(dgc.DataPropertyName == "HostName")
                {
                    dgc.HeaderText = "호스트";
                    dgc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                else 
                {
                    dgc.Visible = false;
                }
            }
        }
        #endregion
    }
}
