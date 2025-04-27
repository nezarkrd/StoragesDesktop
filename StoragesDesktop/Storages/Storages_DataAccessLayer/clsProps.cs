using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storages_DataAccessLayer
{
    public class clsProps
    {
        public string ServerName { get; set; }
        public string DataBase  { get; set; }
        public string UserNameDB { get; set; }
        public string PasswordDB { get; set; }
        public bool CheckShow { get; set; }


       public  clsProps()
        {
            ServerName = Properties.Settings.Default.SERVERNAME;
            DataBase = Properties.Settings.Default.DATABASE;
            UserNameDB= Properties.Settings.Default.USERNAMEDB;
            PasswordDB= Properties.Settings.Default.PASSWORDDB;
            CheckShow= Properties.Settings.Default.CheckShow;
        }


        public clsProps(string servername,string database,string usenamedb,string passworddb,bool checkshow)
        {
            ServerName = servername;
            DataBase = database;
            UserNameDB = usenamedb;
            PasswordDB = passworddb;
            CheckShow = checkshow;

            Properties.Settings.Default.SERVERNAME= ServerName;
            Properties.Settings.Default.DATABASE = DataBase;
            Properties.Settings.Default.USERNAMEDB= UserNameDB;
            Properties.Settings.Default.PASSWORDDB = PasswordDB;
            Properties.Settings.Default.CheckShow = CheckShow;
            Properties.Settings.Default.Save();

        }


        public void getcheckshow(bool checkshow)
        {
            CheckShow = checkshow;
            Properties.Settings.Default.CheckShow = CheckShow;
            Properties.Settings.Default.Save();
        }
    }
}
