using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeloMax
{
    public class Fournisseur
    {
        public string Siret { get; set; }
        public string NomFournisseur { get; set; }
        public string Contact { get; set; }
        public string Adresse { get; set; }
        public ReactiviteEnum Reactivite { get; set; }

        public enum ReactiviteEnum
        {
            TresBon,
            Bon,
            Moyen,
            Mauvais
        }

        public List<Fournisseur> GetAllFournisseurs()
        {
            List<Fournisseur> fournisseurs = new List<Fournisseur>();
            try
            {
                DBConnection dbCon = new DBConnection();
                if (dbCon.IsConnect())
                {
                    string selectAllQuery = "SELECT * FROM fournisseur";
                    MySqlCommand selectCmd = new MySqlCommand(selectAllQuery, dbCon.Connection);
                    using (MySqlDataReader reader = selectCmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Fournisseur fournisseur = new Fournisseur
                            {
                                Siret = reader.GetString("siret"),
                                NomFournisseur = reader.GetString("nom"),
                                Reactivite = (ReactiviteEnum)Enum.Parse(typeof(ReactiviteEnum), reader.GetString("reactivite"), true),
                                Contact = reader.GetString("contact"),
                                Adresse = reader.GetString("adresse")
                            };
                            fournisseurs.Add(fournisseur);
                        }
                    }
                    dbCon.Close();
                }
            }
            catch (MySqlException ex)
            {
                // Gérer les exceptions SQL
                throw new Exception("Une erreur est survenue lors de la récupération des fournisseurs.", ex);
            }
            return fournisseurs;
        }

        public void AddFournisseur()
        {
            try
            {
                DBConnection dbCon = new DBConnection();

                if (dbCon.IsConnect())
                {

                    string query = "INSERT INTO fournisseur (siret, nom_fournisseur, reactivite, adresse, contact) VALUES (@Siret, @NomFournisseur, @Contact, @Adresse, @Reactivite)";
                    var command = new MySqlCommand(query, dbCon.Connection);

                    //sqlString = Tools.PrepareLigne(sqlString, "?id", Tools.PrepareChamp(IDCLIENT.ToString(), "Nombre"));
                    command.Parameters.AddWithValue("@Reactivite", Reactivite.ToString().ToLower());
                    command.Parameters.AddWithValue("@Siret", Siret);
                    command.Parameters.AddWithValue("@NomFournisseur", NomFournisseur);
                    command.Parameters.AddWithValue("@Contact", Contact);
                    command.Parameters.AddWithValue("@Adresse", Adresse);

                    command.ExecuteNonQuery();
                    dbCon.Close();
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {

            }
        }

        public void UpdateFournisseur()
        {

        }

        public void DeleteFournisseur()
        {

        }
    }
}
