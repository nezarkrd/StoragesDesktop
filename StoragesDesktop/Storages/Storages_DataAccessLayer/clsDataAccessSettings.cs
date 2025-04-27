using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storages_DataAccessLayer
{
    public class clsDataAccessSettings
    {
        
        public static string ConnectionString = "Server="+ Properties.Settings.Default.SERVERNAME + ";Database="+ Properties.Settings.Default.DATABASE + ";User Id="+ Properties.Settings.Default.USERNAMEDB + ";password="+ Properties.Settings.Default.PASSWORDDB + "";
    }
}
