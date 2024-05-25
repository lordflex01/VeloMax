using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeloMax
{
    public class Clients
    {
        public int IDCLIENT { get; set; }
        public string ADRESSE { get; set; }
        public string TELEPHONE { get; set; }
        public string COURRIEL { get; set; }


        //Creation de la methode Save pour sauvegarder le client
        public void Save()

        {
            //Si le client existe deja il fait la mis à jour 
            if (IDCLIENT > 0)
                Updateclient();
            //Sinon il crée un nouveau client
            else
                Addclient();
        }

        //Ca c'est la methode pour mettre a jour le client
        private void Updateclient()
        {
            try
            {
                DBConnection dbCon = new DBConnection();
                dbCon.Server = "127.0.0.1";
                dbCon.DatabaseName = "Velomax";
                dbCon.UserName = "root";
                dbCon.Password = "";

                if (dbCon.IsConnect())
                {
                    String sqlString = "UPDATE client SET adresse = ?adresse, telephone = ?tel, courriel = ?email WHERE IDCLIENT = ?id";
                    sqlString = Tools.PrepareLigne(sqlString, "?id", Tools.PrepareChamp(IDCLIENT.ToString(), "Nombre"));
                    sqlString = Tools.PrepareLigne(sqlString, "?adresse", Tools.PrepareChamp(ADRESSE, "Chaine"));
                    sqlString = Tools.PrepareLigne(sqlString, "?tel", Tools.PrepareChamp(TELEPHONE, "Chaine"));
                    sqlString = Tools.PrepareLigne(sqlString, "?email", Tools.PrepareChamp(COURRIEL, "Chaine"));
                    var cmd = new MySqlCommand(sqlString, dbCon.Connection);
                    cmd.ExecuteNonQuery();
                    dbCon.Close();
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {

            }

        }
        //Ca c'est pour donner un id automatiquement car dans l'id est en auto-increment dans la base
        private int GiveNewID()
        {
            try
            {
                DBConnection dbCon = new DBConnection();
                dbCon.Server = "127.0.0.1";
                dbCon.DatabaseName = "Velomax";
                dbCon.UserName = "root";
                dbCon.Password = "";//Pour éviter d'afficher le mot de passe en clair dans le code
                int Identifiant = -1;
                if (dbCon.IsConnect())
                {
                    String sqlString = "GiveId";
                    var cmd = new MySqlCommand(sqlString, dbCon.Connection);
                    cmd.CommandType = CommandType.StoredProcedure; //Il faut System.Data pour cette ligne

                    cmd.Parameters.Add("@TheID", MySqlDbType.Int32);
                    cmd.Parameters["@TheID"].Direction = ParameterDirection.Output;

                    cmd.ExecuteNonQuery();
                    Identifiant = (int)cmd.Parameters["@TheID"].Value;
                    dbCon.Close();
                    return Identifiant + 1;
                }
                dbCon.Close();
                return -1;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                return -1;
            }
        }
        //Ca c'est la methode pour ajouter le client
        private void Addclient()
        {
            try
            {

                IDCLIENT = GiveNewID();
                DBConnection dbCon = new DBConnection();

                dbCon.Server = "127.0.0.1";
                dbCon.DatabaseName = "Velomax";
                dbCon.UserName = "root";
                dbCon.Password = "";

                if (dbCon.IsConnect())
                {

                    String sqlString = "INSERT INTO client(Adresse,Telephone,Courriel) VALUES(?adresse,?tel,?email)";

                    //sqlString = Tools.PrepareLigne(sqlString, "?id", Tools.PrepareChamp(IDCLIENT.ToString(), "Nombre"));
                    sqlString = Tools.PrepareLigne(sqlString, "?adresse", Tools.PrepareChamp(ADRESSE, "Chaine"));
                    sqlString = Tools.PrepareLigne(sqlString, "?tel", Tools.PrepareChamp(TELEPHONE, "Chaine"));
                    sqlString = Tools.PrepareLigne(sqlString, "?email", Tools.PrepareChamp(COURRIEL, "Chaine"));
                    var cmd = new MySqlCommand(sqlString, dbCon.Connection);
                    cmd.ExecuteNonQuery();
                    dbCon.Close();
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {

            }

        }

        public bool Supprimer()
        {
            try
            {
                DBConnection dbCon = new DBConnection();
                dbCon.Server = "127.0.0.1";
                dbCon.DatabaseName = "Velomax";
                dbCon.UserName = "root";
                dbCon.Password = "";
                if (dbCon.IsConnect())
                {
                    String sqlString = "DELETE FROM client WHERE IDCLIENT = ?id_P";
                    sqlString = Tools.PrepareLigne(sqlString, "?id_P", Tools.PrepareChamp(IDCLIENT.ToString(), "Nombre"));
                    var cmd = new MySqlCommand(sqlString, dbCon.Connection);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                return false;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                return false;
            }

        }
    }
}
