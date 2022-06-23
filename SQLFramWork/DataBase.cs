namespace SQLFramWork
{
    public class DataBase
    {
        private string DBname;
        private string Server;
        private bool   Integrated_Securit;
        private string UserName;
        private string Password;

        private List<string> Tables_Names;

        public DataBase(string dBname, string server, bool integrated_Securit, string userName, string password, List<string> tables_Names)
        {
            DBname = dBname;
            Server = server;
            Integrated_Securit = integrated_Securit;
            UserName = userName;
            Password = password;
            Tables_Names = tables_Names;
        }

        public string DBName { get => DBname; }
        public string ServerName { get => Server; }
        public bool IntegratedSecurit { get => Integrated_Securit; }
        public string Username { get => UserName; }
        public string UserPassword { get => Password; }
        public List<string> TablesNames { get => Tables_Names; }

    }
}