using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeloMax
{
    public class DetailPiece
    {
        public int IdDetail { get; set; }
        public int NumeroCommande { get; set; }
        public string NumeroProduit { get; set; }
        public int Quantite { get; set; }


        public void AddDetailCommandePiece()
        {
            DBConnection dbCon = new DBConnection();
            if (dbCon.IsConnect())
            {

                string query = "INSERT INTO details_commande_pieces (numero_commande, numero_produit, quantite) VALUES (@numero_commande, @numero_produit, @quantite)";
                var command = new MySqlCommand(query, dbCon.Connection);

                command.Parameters.AddWithValue("@numero_commande", NumeroCommande);
                command.Parameters.AddWithValue("@numero_produit", NumeroProduit);
                command.Parameters.AddWithValue("@quantite", Quantite);

                command.ExecuteNonQuery();
                dbCon.Close();
            }
        }

        public void UpdateDetailCommandePiece(int IdDetail)
        {
            DBConnection dbCon = new DBConnection();
            if (dbCon.IsConnect())
            {
                string query = "UPDATE details_commande_pieces SET numero_commande = @numero_commande, numero_produit = @numero_produit, quantite = @quantite WHERE id_detail = @id_detail";
                var command = new MySqlCommand(query, dbCon.Connection);

                command.Parameters.AddWithValue("@id_detail", IdDetail);
                command.Parameters.AddWithValue("@numero_commande", NumeroCommande);
                command.Parameters.AddWithValue("@numero_produit", NumeroProduit);
                command.Parameters.AddWithValue("@quantite", Quantite);

                command.ExecuteNonQuery();
                dbCon.Close();

            }
        }

    }
}
