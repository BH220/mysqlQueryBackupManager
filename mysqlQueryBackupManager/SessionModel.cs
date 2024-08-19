namespace mysqlQueryBackupManager
{
    public class SessionModel
    {
        public int Seq { get; set; }
        public string Name { get; set; }
        public string HostName { get; set; }
        public string UserId { get; set; }
        public string UserPw { get; set; }
        public int Port { get; set; }
        public bool UseSsh { get; set; }
        public string SshHost{ get; set; }
        public int SshPort { get; set; }
        public string SshUserId { get; set; }
        public string SshPemKey { get; set; }
        public int SshLocalPort { get; set; }
        public string SavePath { get; set; }
        public string IgnoreTable { get; set; }
        public RepeatTypes RepeatType { get; set; }
        public int Day { get; set; }
        public bool IsSunDay { get; set; }
        public bool IsMonDay { get; set; }
        public bool IsTueDay { get; set; }
        public bool IsWebDay { get; set; }
        public bool IsThrDay { get; set; }
        public bool IsFriDay { get; set; }
        public bool IsSatDay { get; set; }
        public int Hour { get; set; }
        public int Minute { get; set; }
        public bool Deleted { get; set; }
    }
}