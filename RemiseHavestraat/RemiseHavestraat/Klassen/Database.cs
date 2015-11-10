using System;
using System.Collections.Generic;
using System.Data;
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
                        if (rol.ToLower() == "beheerder")
                        {
                            return account = new Account(gebruikersNaam, EnumMedewerkerRol.Beheerder);
                        }
                        else if (rol.ToLower() == "wagenparkbeheerder")
                        {
                            return account = new Account(gebruikersNaam, EnumMedewerkerRol.WagenparkBeheerder);
                        }
                        else if (rol.ToLower() == "schoonmaker")
                        {
                            return account = new Account(gebruikersNaam, EnumMedewerkerRol.Schoonmaker);
                        }
                        else if (rol.ToLower() == "technicus")
                        {
                            return account = new Account(gebruikersNaam, EnumMedewerkerRol.Technicus);
                        }
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

        public List<Medewerker> HaalOpMedewerkers(string medewerkerfunctie)
        {

            try
            {
                OpenVerbinding();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT \"Naam\", \"Functie\" FROM \"Medewerker\" WHERE \"Functie\" = '" + medewerkerfunctie + "'";
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

        public List<Medewerker> ZoekMedewerkers(List<int> medewerkersids)
        {

            try
            {
                OpenVerbinding();
                cmd.Connection = conn;
                List<Medewerker> alleMedewerkers = new List<Medewerker>();
                foreach (int i in medewerkersids)
                {
                    cmd.CommandText = "SELECT \"Naam\", \"Functie\" FROM \"Medewerker\" WHERE \"ID\" = '" + i + "'";
                    OracleDataReader reader = cmd.ExecuteReader();
                    string naam;
                    string functie;

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
                //cmd.CommandText = "SELECT \"ID\", \"Nummer\", \"Lijn_ID\", \"Type\", \"Lengte\", \"Status\" FROM \"Tram\"";
                cmd.CommandText = "SELECT * FROM \"Tram\"";
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

                    id = Convert.ToInt32(reader["id"]);
                    nummer = Convert.ToInt32(reader["nummer"]);
                    if( Int32.TryParse(reader["lijn_id"].ToString(),out lijnId) == false) lijnId = -1;
                    type = reader["type"].ToString();
                    lengte = Convert.ToInt32(reader["lengte"]);
                    status = reader["status"].ToString();
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

        public List<Tram> InfoSpoor(int spoor)
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
                    id = Convert.ToInt32(reader["id"]);
                    remiseid = Convert.ToInt32(reader["remise_id"]);
                    nummer = Convert.ToInt32(reader["nummer"]);
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

        /*
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
          */
        public bool UpdateSpoor(int spoornummer)
        {
            try
            {
                OpenVerbinding();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE \"Spoor\" SET \"Nummer\" = '" + spoornummer + "' WHERE \"Nummer\" = '" + spoornummer + "'";
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




        #region Stored procedures

        public bool PlaatsTram(int tramNr, int spoorNr, int segmentNr)
        {
            var cmds = new OracleCommand("PLAATSTRAM",conn);
            cmds.CommandType = CommandType.StoredProcedure;

            cmds.Parameters.Add("p_tramNr", OracleType.Number).Value = tramNr;
            cmds.Parameters.Add("p_spoorNr", OracleType.Number).Value = spoorNr;
            cmds.Parameters.Add("p_segmentNr", OracleType.Number).Value = segmentNr;

            cmds.Parameters.Add("p_geslaagd_out", OracleType.Number, 1);
            cmds.Parameters["p_geslaagd_out"].Direction = ParameterDirection.Output;

            OpenVerbinding();

            using (var da = new OracleDataAdapter(cmds))
            {
                cmds.ExecuteNonQuery();
            }

            //VERBINDING SLUITEN
            conn.Close();
            cmds.Dispose();

            //RETURN VALUE
            if (cmds.Parameters["p_geslaagd_out"].Value.ToString() == "1")
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool BlokkeerSegment(int spoorNr, int segmentNr)
        {
           var cmds = new OracleCommand("BLOKKEERSEGMENT", conn);
            cmds.CommandType = CommandType.StoredProcedure;

            
            cmds.Parameters.Add("p_spoorNr", OracleType.Number).Value = spoorNr;
            cmds.Parameters.Add("p_segmentNr", OracleType.Number).Value = segmentNr;

            cmds.Parameters.Add("p_geslaagd_out", OracleType.Number, 1);
            cmds.Parameters["p_geslaagd_out"].Direction = ParameterDirection.Output;

            OpenVerbinding();

            using (var da = new OracleDataAdapter(cmds))
            {
                cmds.ExecuteNonQuery();
            }

            //VERBINDING SLUITEN
            conn.Close();
            cmds.Dispose();

            //RETURN VALUE
            if (cmds.Parameters["p_geslaagd_out"].Value.ToString() == "1")
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool VerwijderTram(int tramNr)
        {
            var cmds = new OracleCommand("VERWIJDERTRAM", conn);
            cmds.CommandType = CommandType.StoredProcedure;

            cmds.Parameters.Add("p_tramNr", OracleType.Number).Value = tramNr;
            cmds.Parameters.Add("p_geslaagd_out", OracleType.Number, 1);
            cmds.Parameters["p_geslaagd_out"].Direction = ParameterDirection.Output;


            OpenVerbinding();

            using (var da = new OracleDataAdapter(cmds))
            {
                cmds.ExecuteNonQuery();
            }


            //VERBINDING SLUITEN
            conn.Close();
            cmds.Dispose();

            cmds.Parameters["p_geslaagd_out"].Value.ToString();

            //RETURN VALUE
            if (cmds.Parameters["p_geslaagd_out"].Value.ToString() == "1")
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void ResetOverzicht()
        {
           var cmds = new OracleCommand("RESETOVERZICHT", conn);
            cmds.CommandType = CommandType.StoredProcedure;

            OpenVerbinding();

            using (var da = new OracleDataAdapter(cmds))
            {
                cmds.ExecuteNonQuery();
            }

            //VERBINDING SLUITEN
            conn.Close();
            cmds.Dispose();
        }


        public void Simulatie()
        {
            var cmds = new OracleCommand("SIMULATIE", conn);
            cmds.CommandType = CommandType.StoredProcedure;

            OpenVerbinding();

            using (var da = new OracleDataAdapter(cmds))
            {
                cmds.ExecuteNonQuery();
            }

            //VERBINDING SLUITEN
            conn.Close();
            cmds.Dispose();
        }

         public bool MaakReservering(int tramNr,int spoorNr)
         {
            var cmds = new OracleCommand("MAAKRESERVERING", conn);
            cmds.CommandType = CommandType.StoredProcedure;
            
            cmds.Parameters.Add("p_tramNr", OracleType.Number).Value = tramNr;
            cmds.Parameters.Add("p_spoorNr", OracleType.Number).Value = spoorNr;

            cmds.Parameters.Add("p_geslaagd_out", OracleType.Number, 1);
            cmds.Parameters["p_geslaagd_out"].Direction = ParameterDirection.Output;

            OpenVerbinding();

            using (var da = new OracleDataAdapter(cmds))
            {
                cmds.ExecuteNonQuery();
            }

            //VERBINDING SLUITEN
            conn.Close();
            cmds.Dispose();

            //RETURN VALUE
            if (cmds.Parameters["p_geslaagd_out"].Value.ToString() == "1")
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        #region METHODES GIJS

        public List<Segment> HaalSegmentenOp()
        {
            try
            {
                OpenVerbinding();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM \"Segment\"";
                OracleDataReader reader = cmd.ExecuteReader();
                int id;
                int spoorID;
                int nummer;
                int tramID;
                int blokkade;
                int beschikbaar;

                List<Segment> alleSegmenten = new List<Segment>();

                while (reader.Read())
                {
                    spoorID = Convert.ToInt32(reader["spoor_id"]);
                    nummer = Convert.ToInt32(reader["nummer"]);
                    if( Int32.TryParse(reader["tram_id"].ToString(),out tramID) == false) tramID = -1;
                    blokkade = Convert.ToInt32(reader["blokkade"]);
                    beschikbaar = Convert.ToInt32(reader["beschikbaar"]);
                    
                    alleSegmenten.Add(new Segment(spoorID,nummer,tramID,blokkade,beschikbaar));
                  
                }
                return alleSegmenten;
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


        public List<Segment> HaalSegmentenRandomOp()
        {
            try
            {
                OpenVerbinding();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM (SELECT * FROM \"Segment\" ORDER BY \"Nummer\", dbms_random.value)";
                OracleDataReader reader = cmd.ExecuteReader();
                int id;
                int spoorID;
                int nummer;
                int tramID;
                int blokkade;
                int beschikbaar;

                List<Segment> alleSegmenten = new List<Segment>();

                while (reader.Read())
                {
                    spoorID = Convert.ToInt32(reader["spoor_id"]);
                    nummer = Convert.ToInt32(reader["nummer"]);
                    if (Int32.TryParse(reader["tram_id"].ToString(), out tramID) == false) tramID = -1;
                    blokkade = Convert.ToInt32(reader["blokkade"]);
                    beschikbaar = Convert.ToInt32(reader["beschikbaar"]);

                    alleSegmenten.Add(new Segment(spoorID, nummer, tramID, blokkade, beschikbaar));

                }
                return alleSegmenten;
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


        public List<Reservering> HaalReserveringenOp()
        {
            try
            {
                OpenVerbinding();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM (SELECT * FROM \"Reservering\"";
                OracleDataReader reader = cmd.ExecuteReader();

                int spoorID;
                int tramID;

                List<Reservering> reserveringen = new List<Reservering>();

                while (reader.Read())
                {
                    spoorID = Convert.ToInt32(reader["spoor_id"]);
                    tramID = Convert.ToInt32(reader["tram_id"]);

                    reserveringen.Add(new Reservering(tramID, spoorID));

                }
                return reserveringen;
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
        #endregion
    }

}

