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
        string connString = "User Id=dbi311092;Password=DAhEQlt6nE;Data Source= //192.168.15.50:1521/fhictora;"; 
        OracleConnection conn;
        OracleCommand cmd;
        public Account account;
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
                cmd.CommandText = "SELECT \"Wachtwoord\", \"Rol\" FROM \"Account\" WHERE \"Inlognaam\" = '" + gebruikersNaam + "'";
                OracleDataReader reader = cmd.ExecuteReader();
                string wachtwoord;
                string rol;

                while (reader.Read())
                {
                    wachtwoord = (string)reader["Wachtwoord"];
                    rol = (string)reader["Rol"];

                    if (wachtWoord == wachtwoord)
                    {
                        Console.WriteLine("Welkom: " + gebruikersNaam);
                        return account = new Account(gebruikersNaam, EnumMedewerkerRol.Beheerder);
                    }
                }
                
                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
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
