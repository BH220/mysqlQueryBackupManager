using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mysqlQueryBackupManager
{
    public class SessionManager
    {
        private static SessionManager instance;

        public List<SessionModel> Data = new List<SessionModel>();
        public static SessionManager Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new SessionManager();
                    instance.InitLoad();
                }
                return instance;
            }
        }

        public void InitLoad()
        {
            string pp = Application.StartupPath + "\\Data";
            if(Directory.Exists(pp) == false) Directory.CreateDirectory(pp);
            string fp = pp + "\\SessionData.json";
            if(File.Exists(fp) == false)
            {
                List<SessionModel> data = new List<SessionModel>();
                File.WriteAllText(fp, JsonConvert.SerializeObject(data));
            }
            string jsonStr = File.ReadAllText(fp);
            Data = JsonConvert.DeserializeObject<List<SessionModel>>(jsonStr);
        }
    }
}
