using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;


namespace RemiseHavestraat
{
    class Database
    {
        #region Fields
        private OracleConnection conn;
        string gebruiker = "system";
        string wachtwoord = "Sasuke611";
        #endregion

        #region Initialisatie
        public Database()
        {
            
        }

        public void OpenVerbinding()
        {
            try
            {
                conn.ConnectionString = "User Id=" + gebruiker + ";Password=" + wachtwoord + ";Data Source=" + " //localhost:1521/xe" + ";";
                conn.Open();
                Console.WriteLine("Succes!");
            }
            catch
            {
                Console.WriteLine("Failed!");
            }
        }
        #endregion
    }
}
