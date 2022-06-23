using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLFramWork
{
    internal class DataBaseBuilder
    {
        private string DBname;
        private string Server;
        private bool Integrated_Securit;
        private string UserName;
        private string Password;

        private List<string> Tables_Names;

        public DataBaseBuilder DBName(string name)
        {
            this.DBname = name;
            return this;
        }

        public DataBaseBuilder ServerName(string Server)
        {
            this.Server = Server;
            return this;
        }

        public DataBaseBuilder IntegratedSecurity(bool val)
        {
            this.Integrated_Securit = val;
            return this;
        }

        public DataBaseBuilder Username(string Name)
        {
            this.UserName = Name; 
            return this;
        }

        public DataBaseBuilder UserPassword(string pass)
        {
            this.Password = pass;
            return this;    
        }

        public DataBaseBuilder TablesNames(List<string> names)
        {
            this.Tables_Names = names;
            return this;
        }


        public DataBase Build()
        {
            return new DataBase(this.DBname, this.Server, this.Integrated_Securit, this.UserName, this.Password, this.Tables_Names);
        }

    }
}
