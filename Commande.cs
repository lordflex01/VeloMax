using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeloMax
{
    public class Commande
    {
        public int NumeroCommande { get; set; }
        public DateTime DateCommande { get; set; }
        public string AdresseLivraison { get; set; }
        public DateTime? DateLivraison { get; set; }
        public decimal PrixTotal { get; set; }
        public int? ClientId { get; set; }
        public int? EmployeId { get; set; }


        public void AddCommande()
        {
            DBConnection dbCon = new DBConnection();
            if (dbCon.IsConnect())
            {
                string query = "INSERT INTO commande (date_commande, adresse_livraison, date_livraison, prix_total, client_id, employe_id) VALUES (@date_commande, @adresse_livraison, @date_livraison, @prix_total, @client_id, @employe_id)";
                using (var command = new MySqlCommand(query, dbCon.Connection))
                {
                    command.Parameters.AddWithValue("@date_commande", DateCommande);
                    command.Parameters.AddWithValue("@adresse_livraison", AdresseLivraison);
                    command.Parameters.AddWithValue("@date_livraison", DateLivraison.HasValue ? (object)DateLivraison.Value : DBNull.Value);
                    command.Parameters.AddWithValue("@prix_total", PrixTotal);
                    command.Parameters.AddWithValue("@client_id", ClientId.HasValue ? (object)ClientId.Value : DBNull.Value);
                    command.Parameters.AddWithValue("@employe_id", EmployeId.HasValue ? (object)EmployeId.Value : DBNull.Value);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateCommande(int NumeroCommande)
        {
            DBConnection dbCon = new DBConnection();
            if(dbCon.IsConnect())
            {
                
                string query = "UPDATE commande SET date_commande = @date_commande, adresse_livraison = @adresse_livraison, date_livraison = @date_livraison, prix_total = @prix_total, client_id = @client_id, employe_id = @employe_id WHERE numero_commande = @numero_commande";
                using (var command = new MySqlCommand(query, dbCon.Connection))
                {
                    command.Parameters.AddWithValue("@numero_commande", NumeroCommande);
                    command.Parameters.AddWithValue("@date_commande", DateCommande);
                    command.Parameters.AddWithValue("@adresse_livraison", AdresseLivraison);
                    command.Parameters.AddWithValue("@date_livraison", DateLivraison.HasValue ? (object)DateLivraison.Value : DBNull.Value);
                    command.Parameters.AddWithValue("@prix_total", PrixTotal);
                    command.Parameters.AddWithValue("@client_id", ClientId.HasValue ? (object)ClientId.Value : DBNull.Value);
                    command.Parameters.AddWithValue("@employe_id", EmployeId.HasValue ? (object)EmployeId.Value : DBNull.Value);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteCommande(int numeroCommande)
        {
            DBConnection dbCon = new DBConnection();
            if (dbCon.IsConnect())
            {
                string query = "DELETE FROM commande WHERE numero_commande = @numero_commande";
                using (var command = new MySqlCommand(query, dbCon.Connection))
                {
                    command.Parameters.AddWithValue("@numero_commande", numeroCommande);
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Commande> GetAllCommandes()
        {
            List<Commande> commandes = new List<Commande>();

            DBConnection dbCon = new DBConnection();
            if (dbCon.IsConnect())
            {
                string query = "SELECT numero_commande, date_commande, adresse_livraison, date_livraison, prix_total, client_id, employe_id FROM commande";
                using (var command = new MySqlCommand(query, dbCon.Connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var commande = new Commande
                            {
                                NumeroCommande = reader.GetInt32("numero_commande"),
                                DateCommande = reader.GetDateTime("date_commande"),
                                AdresseLivraison = reader.GetString("adresse_livraison"),
                                DateLivraison = reader.IsDBNull("date_livraison") ? (DateTime?)null : reader.GetDateTime("date_livraison"),
                                PrixTotal = reader.GetDecimal("prix_total"),
                                ClientId = reader.IsDBNull("client_id") ? (int?)null : reader.GetInt32("client_id"),
                                EmployeId = reader.IsDBNull("employe_id") ? (int?)null : reader.GetInt32("employe_id")
                            };
                            commandes.Add(commande);
                        }
                    }
                }
            }

            return commandes;
        }
    }
}
