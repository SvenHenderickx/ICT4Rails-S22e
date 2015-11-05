using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.OracleClient;

namespace RemiseHavestraat
{
    public class Database
    {
        #region Fields
        string connString = "User Id=PTS10;Password=PTS10;Data Source= //localhost:1521/XE;"; 
        OracleConnection conn;
        OracleCommand cmd;
        #endregion

        #region Initialisatie
        public Database()
        {
            conn = new OracleConnection();
            conn.ConnectionString = connString;
            cmd = conn.CreateCommand();
        }
        #endregion

        #region Methodes
        public bool OpenVerbinding()
        {
            try
            {
                conn.ConnectionString = connString;
                conn.Open();
                Console.WriteLine("Succes");
                return true;
            }
            catch
            {
                Console.WriteLine("Fail");
                return false;
            }
        }

        public Account LogIn(string gebruikersNaam, string wachtWoord)
        {
            try
            {
                OpenVerbinding();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT Wachtwoord, Rol FROM Account WHERE Inlognaam = " + gebruikersNaam + ";";
                OracleDataReader reader = cmd.ExecuteReader();
                string wachtwoord;
                string rol;

                while (reader.Read())
                {
                    wachtwoord = (string)reader["Wachtwoord"];
                    rol = (string)reader["rol"];
                    if (wachtWoord == wachtwoord)
                    {
                        return new Account(gebruikersNaam, );
                    }
                }
                
                return null;
            }
            catch
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
            
        }
        #endregion
    }
}
