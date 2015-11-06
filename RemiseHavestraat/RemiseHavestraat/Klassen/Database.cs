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

        public List<Medewerker> HaalOpMedewerkers()
        {
            
            try
            {
                OpenVerbinding();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT \"Naam\", \"Functie\" FROM \"Medewerker\"";
                OracleDataReader reader = cmd.ExecuteReader();
                string naam;
                string functie;
                List<Medewerker> alleMedewerkers = new List<Medewerker>();
                
                while (reader.Read())
                {
                    naam = (string)reader["Naam"];
                    functie = (string)reader["Functie"];
                    if (functie == "Schoonmaker")
                    {
                        alleMedewerkers.Add(new Medewerker(naam, 0));
                    }
                    if (functie == "Technicus")
                    {
                        alleMedewerkers.Add(new Medewerker(naam, 1));
                    }
                    if (functie == "Beheerder")
                    {
                        alleMedewerkers.Add(new Medewerker(naam, 3));
                    }
                    if (functie == "Bestuurder")
                    {
                        alleMedewerkers.Add(new Medewerker(naam, 4));
                    }
                    if (functie == "WagenparkBeheerder")
                    {
                        alleMedewerkers.Add(new Medewerker(naam, 2));
                    }
                }
                return alleMedewerkers;
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

        public List<Tram> HaalOpTrams()
        {

            try
            {
                OpenVerbinding();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT \"ID\", \"Nummer\", \"Lijn_ID\", \"Type\", \"Lengte\", \"Status\" FROM \"Tram\"";
                OracleDataReader reader = cmd.ExecuteReader();
                int id;
                int nummer;
                int lijnId;
                string type;
                int lengte;
                string status;

                List<Tram> alleTrams = new List<Tram>();

                while (reader.Read())
                {
                    id = (int)reader["ID"];
                    nummer = (int)reader["Nummer"];
                    lijnId = (int)reader["Lijn_ID"];
                    type = (string)reader["Type"];
                    lengte = (int)reader["Lengte"];
                    status = (string)reader["Status"];
                    int typeInt;
                    switch (type)
                    {
                        case "Dubbelkop":
                            typeInt = 1;
                            break;
                        case "Opleidingstrams":
                            typeInt = 2;
                            break;
                        case "ElfG":
                            typeInt = 3;
                            break;
                        case "TwaalG":
                            typeInt = 4;
                            break;
                        default:
                            typeInt = 0;
                            break;
                    }
                    if (status == "Defect")
                    {
                        alleTrams.Add(new Tram(id, nummer, lijnId, typeInt, lengte, 0));
                    }
                    if (status == "Schoonmaak")
                    {
                        alleTrams.Add(new Tram(id, nummer, lijnId, typeInt, lengte, 1));
                    }
                    if (status == "Dienst")
                    {
                        alleTrams.Add(new Tram(id, nummer, lijnId, typeInt, lengte, 2));
                    }
                    if (status == "Remise")
                    {
                        alleTrams.Add(new Tram(id, nummer, lijnId, typeInt, lengte, 3));
                    }
                }
                return alleTrams;
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
        public List<Spoor> HaalOpSporen()
        {

            try
            {
                OpenVerbinding();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT \"ID\", \"Remise_ID\", \"Nummer\" FROM \"Spoor\"";
                OracleDataReader reader = cmd.ExecuteReader();
                int id;
                int remiseid;
                int nummer;

                List<Spoor> alleSporen = new List<Spoor>();

                while (reader.Read())
                {
                    id = (int)reader["ID"];
                    remiseid = (int)reader["Remise_ID"];
                    nummer = (int)reader["Nummer"];
                    alleSporen.Add(new Spoor(id, remiseid, nummer));
                }            
                return alleSporen;
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

        public List<Beurt> HaalOpSchoonmaakBeurten()
        {
            try
            {
                OpenVerbinding();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT \"ID\", \"Remise_ID\", \"Nummer\" FROM \"Spoor\" WHERE Type = 'KLEINE SCHOONMAAK' OR TYPE = 'GROTE SCHOONMAAK'";
                OracleDataReader reader = cmd.ExecuteReader();
                int id;
                int remiseid;
                int nummer;

                List<Beurt> alleSchoonmaakBeurten = new List<Beurt>();

                while (reader.Read())
                {
                    id = (int)reader["ID"];
                    remiseid = (int)reader["Remise_ID"];
                    nummer = (int)reader["Nummer"];
                    
                }
                return alleSchoonmaakBeurten;
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

        public bool UpdateTramStatus(int tramnummer, string tramstatus)
        {
            try
                {
                    OpenVerbinding();
                    cmd.Connection = conn;
                    cmd.CommandText  = "UPDATE \"Tram\" SET \"Status\" = '" + tramstatus + "' WHERE \"ID\" = '" + tramnummer + "'";
                    OracleDataReader reader = cmd.ExecuteReader();
                }
                    
            
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }

        public bool VerwijderTramSegment(int tramnummer)
        {
            try
            {
                OpenVerbinding();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM \"Segment\" WHERE \"Tram_ID\" = '" + tramnummer + "'";
                OracleDataReader reader = cmd.ExecuteReader();
            }


            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }
            
        #endregion
    }
}
