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

        private string JsonPath
        {
            get
            {
                string pp = Application.StartupPath + "\\Data";
                if (Directory.Exists(pp) == false) Directory.CreateDirectory(pp);
                string fp = pp + "\\SessionData.json";
                if (File.Exists(fp) == false)
                    File.WriteAllText(fp, JsonConvert.SerializeObject(Data));
                return fp;
            }
        }

        public void InitLoad()
        {
            string jsonStr = File.ReadAllText(JsonPath);
            Data = JsonConvert.DeserializeObject<List<SessionModel>>(jsonStr);
        }

        public void Save()
        {
            File.WriteAllText(JsonPath, JsonConvert.SerializeObject(Data));
        }
    }
}
