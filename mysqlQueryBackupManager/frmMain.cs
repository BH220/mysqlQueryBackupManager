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

        private void ctkWork1_Load(object sender, EventArgs e)
        {

        }

        private void ctkHistory1_Load(object sender, EventArgs e)
        {

        }

        private void ctlSetting1_Load(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
                ctlWork1.LoadData();
            else if (tabControl1.SelectedIndex == 1)
                ctlHistory1.LoadData();
            else if (tabControl1.SelectedIndex == 2)
                ctlSetting1.LoadData();
        }



        /*
        protected override void OnLoad(EventArgs e)
        {
            SessionData = SessionManager.Instance.Data;
            gridSetting.DataSource = SessionData;
            base.OnLoad(e);
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


        private void LoadSettingInfo(SessionModel sessionInfo)
        {
            tbHost.Focus();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void gridSetting_DataSourceChanged(object sender, EventArgs e)
        {
            
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
            rbNouseSsh.Checked = true;
            cmbRepeat.SelectedIndex = 0;
        }
        */
    }
}




