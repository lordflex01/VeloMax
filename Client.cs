using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeloMax
{
    public class Client
    {
        public int IdClient { get; set; }
        public ClientTypeEnum Type { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public string Ville { get; set; }
        public string CP { get; set; }
        public string Province { get; set; }
        public string Telephone { get; set; }
        public string Courriel { get; set; }
        public string NomBoutique { get; set; }
        public string NomContact { get; set; }

        public enum ClientTypeEnum
        {
            Boutique,
            Individu
        }


        public void SaveClient()
        {
            //Si le client existe deja il fait la mis à jour 
            if (IdClient > 0)
                UpdateClient();
            //Sinon il crée un nouveau client
            else
                try
                {
                    DBConnection dbCon = new DBConnection();

                    if (dbCon.IsConnect())
                    {

                        string query = "INSERT INTO client (type, nom, prenom, adresse, ville, cp, province, telephone, courriel, nom_boutique, nom_contact) VALUES (@Type, @Nom, @Prenom, @Adresse, @Ville, @CP, @Province, @Telephone, @Courriel, @NomBoutique, @NomContact)";
                        var command = new MySqlCommand(query, dbCon.Connection);

                        //sqlString = Tools.PrepareLigne(sqlString, "?id", Tools.PrepareChamp(IDCLIENT.ToString(), "Nombre"));
                        command.Parameters.AddWithValue("@Type", Type.ToString().ToLower());
                        command.Parameters.AddWithValue("@Nom", Nom);
                        command.Parameters.AddWithValue("@Prenom", Prenom);
                        command.Parameters.AddWithValue("@Adresse", Adresse);
                        command.Parameters.AddWithValue("@Ville", Ville);
                        command.Parameters.AddWithValue("@CP", CP);
                        command.Parameters.AddWithValue("@Province", Province);
                        command.Parameters.AddWithValue("@Telephone", Telephone);
                        command.Parameters.AddWithValue("@Courriel", Courriel);
                        command.Parameters.AddWithValue("@NomBoutique", NomBoutique);
                        command.Parameters.AddWithValue("@NomContact", NomContact);

                        command.ExecuteNonQuery();
                        dbCon.Close();
                    }
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {

                }
        }

        public List<Client> GetAllClients()
        {
            var clients = new List<Client>();

            DBConnection dbCon = new DBConnection();

            if (dbCon.IsConnect())
            {
                string query = "SELECT idClient, type, nom, prenom, adresse, ville, cp, province, telephone, courriel, nom_boutique, nom_contact FROM client";
                var command = new MySqlCommand(query, dbCon.Connection);
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var client = new Client
                    {
                        IdClient = reader.GetInt32("idClient"),
                        Type = (Client.ClientTypeEnum)Enum.Parse(typeof(Client.ClientTypeEnum), reader.GetString("type"), true),
                        Nom = reader.GetString("nom"),
                        Prenom = reader.GetString("prenom"),
                        Adresse = reader.GetString("adresse"),
                        Ville = reader.GetString("ville"),
                        CP = reader.GetString("cp"),
                        Province = reader.GetString("province"),
                        Telephone = reader.IsDBNull(reader.GetOrdinal("telephone")) ? null : reader.GetString("telephone"),
                        Courriel = reader.IsDBNull(reader.GetOrdinal("courriel")) ? null : reader.GetString("courriel"),
                        NomBoutique = reader.IsDBNull(reader.GetOrdinal("nom_boutique")) ? null : reader.GetString("nom_boutique"),
                        NomContact = reader.IsDBNull(reader.GetOrdinal("nom_contact")) ? null : reader.GetString("nom_contact")
                    };
                    clients.Add(client);
                }
                
            }

            return clients;
        }

        public void UpdateClient() {
            try
            {
                DBConnection dbCon = new DBConnection();

                if (dbCon.IsConnect())
                {
                    string query = "UPDATE client SET type = @Type, nom = @Nom, prenom = @Prenom, adresse = @Adresse, ville = @Ville, cp = @CP, province = @Province, telephone = @Telephone, courriel = @Courriel, nom_boutique = @NomBoutique, nom_contact = @NomContact WHERE idClient = @IdClient";
                    var command = new MySqlCommand(query, dbCon.Connection);

                    command.Parameters.AddWithValue("@IdClient", IdClient);
                    command.Parameters.AddWithValue("@Type", Type.ToString().ToLower());
                    command.Parameters.AddWithValue("@Nom", Nom);
                    command.Parameters.AddWithValue("@Prenom", Prenom);
                    command.Parameters.AddWithValue("@Adresse", Adresse);
                    command.Parameters.AddWithValue("@Ville", Ville);
                    command.Parameters.AddWithValue("@CP", CP);
                    command.Parameters.AddWithValue("@Province", Province);
                    command.Parameters.AddWithValue("@Telephone", Telephone);
                    command.Parameters.AddWithValue("@Courriel", Courriel);
                    command.Parameters.AddWithValue("@NomBoutique", NomBoutique);
                    command.Parameters.AddWithValue("@NomContact", NomContact);

                    command.ExecuteNonQuery();
                    dbCon.Close();
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {

            }
        }

        public void DeleteClient(int idClient) {
            try
            {
                DBConnection dbCon = new DBConnection();
                if (dbCon.IsConnect())
                {
                    string query = "DELETE FROM client WHERE idClient = @IdClient";
                    var command = new MySqlCommand(query, dbCon.Connection);

                    command.Parameters.AddWithValue("@IdClient", IdClient);
                    command.ExecuteNonQuery();
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                
            }
        }

        
    }
}
