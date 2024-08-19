using BH_Library.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mysqlQueryBackupManager
{
    public partial class frmMain : Form
    {
        List<SessionModel> SessionData = new List<SessionModel>();
        public frmMain()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            SessionData = SessionManager.Instance.Data;
            gridSetting.DataSource = SessionData;
            base.OnLoad(e);
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

        private void rbUseSsh_CheckedChanged(object sender, EventArgs e)
        {
            InitSshControl(false, true);
        }

        private void rbNouseSsh_CheckedChanged(object sender, EventArgs e)
        {
            InitSshControl(false, false);
        }

        private void InitSshControl(bool init = false, bool enabled = false)
        {
            tbSshHost.Enabled
               = tbSshPort.Enabled
               = tbSshUserId.Enabled
               = tbSshPemPpk.Enabled
               = tbSshLocalPort.Enabled
               = enabled;
            if(init)
            {
                tbSshHost.Text
               = tbSshPort.Text
               = tbSshUserId.Text
               = tbSshPemPpk.Text
               = tbSshLocalPort.Text
               = "";
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
            using(FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if(fbd.ShowDialog() == DialogResult.OK)
                {
                    tbSavePath.Text = fbd.SelectedPath;
                }
            }
        }

        private void cmbRepeat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRepeat.SelectedIndex == 0)
            {//선택
                cmbDay.SelectedIndex
                    = cmbHour.SelectedIndex
                    = cmbMinute.SelectedIndex
                    = -1;
                cmbDay.Enabled
                    = cmbHour.Enabled
                    = cmbMinute.Enabled
                    = false;
                chkSun.Checked = chkMon.Checked = chkTue.Checked = chkWen.Checked = chkThr.Checked = chkFri.Checked = chkSat.Checked = false;
                chkSun.Enabled = chkMon.Enabled = chkTue.Enabled = chkWen.Enabled = chkThr.Enabled = chkFri.Enabled = chkSat.Enabled = false;
            }
            else if (cmbRepeat.SelectedIndex == 1)
            {//한번
                cmbDay.SelectedIndex
                    = cmbHour.SelectedIndex
                    = cmbMinute.SelectedIndex
                    = -1;
                cmbDay.Enabled = false;
                cmbHour.Enabled
                = cmbMinute.Enabled
                = true;
                chkSun.Checked = chkMon.Checked = chkTue.Checked = chkWen.Checked = chkThr.Checked = chkFri.Checked = chkSat.Checked = false;
                chkSun.Enabled = chkMon.Enabled = chkTue.Enabled = chkWen.Enabled = chkThr.Enabled = chkFri.Enabled = chkSat.Enabled = false;
            }
            else if (cmbRepeat.SelectedIndex == 2)
            {//매월
                cmbDay.SelectedIndex
                    = cmbHour.SelectedIndex
                    = cmbMinute.SelectedIndex
                    = -1;
                cmbDay.Enabled = false;
                    cmbHour.Enabled
                    = cmbMinute.Enabled
                    = true;
                chkSun.Checked = chkMon.Checked = chkTue.Checked = chkWen.Checked = chkThr.Checked = chkFri.Checked = chkSat.Checked = false;
                chkSun.Enabled = chkMon.Enabled = chkTue.Enabled = chkWen.Enabled = chkThr.Enabled = chkFri.Enabled = chkSat.Enabled = false;
            }
            else if (cmbRepeat.SelectedIndex == 3)
            {//매주
                cmbDay.SelectedIndex
                    = cmbHour.SelectedIndex
                    = cmbMinute.SelectedIndex
                    = -1;
                cmbDay.Enabled = false;
                    cmbHour.Enabled
                    = cmbMinute.Enabled
                    = true;
                chkSun.Checked = chkMon.Checked = chkTue.Checked = chkWen.Checked = chkThr.Checked = chkFri.Checked = chkSat.Checked = true;
                chkSun.Enabled = chkMon.Enabled = chkTue.Enabled = chkWen.Enabled = chkThr.Enabled = chkFri.Enabled = chkSat.Enabled = true;
            }
            else if (cmbRepeat.SelectedIndex == 4)
            {//매일
                cmbDay.SelectedIndex
                    = cmbHour.SelectedIndex
                    = cmbMinute.SelectedIndex
                    = -1;
                cmbDay.Enabled = false;
                cmbHour.Enabled
                = cmbMinute.Enabled
                = true;
                chkSun.Checked = chkMon.Checked = chkTue.Checked = chkWen.Checked = chkThr.Checked = chkFri.Checked = chkSat.Checked = true;
                chkSun.Enabled = chkMon.Enabled = chkTue.Enabled = chkWen.Enabled = chkThr.Enabled = chkFri.Enabled = chkSat.Enabled = true;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if(BhMsgBox.Confirm("삭제하시겠습니까?", "삭제") == DialogResult.OK)
            {
                MessageBox.Show("삭제처리");
            }
        }

        private void LoadSettingInfo(SessionModel sessionInfo)
        {
            tbHost.Focus();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void gridSetting_DataSourceChanged(object sender, EventArgs e)
        {
            foreach(DataGridViewColumn dgc in gridSetting.Columns)
            {
                if(!( dgc.DataPropertyName == "Name" || dgc.DataPropertyName == "HostName"))
                {
                    dgc.Visible = false;
                }
            }
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 2)
            {
                if (SessionData.Count > 0)
                {
                    LoadSettingInfo(SessionData[0]);
                }
                else
                {
                    btnNew_Click(null, null);
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }
    }
}




