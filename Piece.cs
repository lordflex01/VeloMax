using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeloMax
{
    public class Piece
    {
        public string NumeroProduit { get; set; }
        public string Description { get; set; }
        public decimal PrixUnitaire { get; set; }
        public DateTime DateIntroduction { get; set; }
        public DateTime? DateDiscontinuation { get; set; }
        public string SiretFournisseur { get; set; }
        public int DelaiFournisseur { get; set; }
        public float Quantite { get; set; }


        public void AddPiece()
        {
            DBConnection dbCon = new DBConnection();
            if (dbCon.IsConnect()) 
            { 
                string query = "INSERT INTO piece (numero_produit, description, prix_unitaire, date_introduction, date_discontinuation, siret_fournisseur, delai_fournisseur, quantite) VALUES (@numero_produit, @description, @prix_unitaire, @date_introduction, @date_discontinuation, @siret_fournisseur, @delai_fournisseur, @quantite)";
                using (var command = new MySqlCommand(query, dbCon.Connection))
                {
                    command.Parameters.AddWithValue("@numero_produit", NumeroProduit);
                    command.Parameters.AddWithValue("@description", Description);
                    command.Parameters.AddWithValue("@prix_unitaire", PrixUnitaire);
                    command.Parameters.AddWithValue("@date_introduction", DateIntroduction);
                    command.Parameters.AddWithValue("@date_discontinuation", DateDiscontinuation.HasValue ? (object)DateDiscontinuation.Value : DBNull.Value);
                    command.Parameters.AddWithValue("@siret_fournisseur", SiretFournisseur);
                    command.Parameters.AddWithValue("@delai_fournisseur", DelaiFournisseur);
                    command.Parameters.AddWithValue("@quantite", Quantite);

                    command.ExecuteNonQuery();
                }
            }
        }


        public void UpdatePiece(String NumeroProduit)
        {
            DBConnection dbCon = new DBConnection();
            
            if (dbCon.IsConnect())
            {
                string query = "UPDATE piece SET description = @description, prix_unitaire = @prix_unitaire, date_introduction = @date_introduction, date_discontinuation = @date_discontinuation, siret_fournisseur = @siret_fournisseur, delai_fournisseur = @delai_fournisseur, quantite = @quantite WHERE numero_produit = @numero_produit";
                using (var command = new MySqlCommand(query, dbCon.Connection))
                {
                    command.Parameters.AddWithValue("@numero_produit", NumeroProduit);
                    command.Parameters.AddWithValue("@description", Description);
                    command.Parameters.AddWithValue("@prix_unitaire", PrixUnitaire);
                    command.Parameters.AddWithValue("@date_introduction", DateIntroduction);
                    command.Parameters.AddWithValue("@date_discontinuation", DateDiscontinuation.HasValue ? (object)DateDiscontinuation.Value : DBNull.Value);
                    command.Parameters.AddWithValue("@siret_fournisseur", SiretFournisseur);
                    command.Parameters.AddWithValue("@delai_fournisseur", DelaiFournisseur);
                    command.Parameters.AddWithValue("@quantite", Quantite);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeletePiece(string numeroProduit)
        {
            DBConnection dbCon = new DBConnection();
            if (dbCon.IsConnect()) 
            { 
                string query = "DELETE FROM piece WHERE numero_produit = @numero_produit";
                using (var command = new MySqlCommand(query, dbCon.Connection))
                {
                    command.Parameters.AddWithValue("@numero_produit", numeroProduit);
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Piece> GetAllPieces()
        {
            List<Piece> pieces = new List<Piece>();

            DBConnection dbCon = new DBConnection();
            if (dbCon.IsConnect()) 
            { 
                string query = "SELECT numero_produit, description, prix_unitaire, date_introduction, date_discontinuation, siret_fournisseur, delai_fournisseur, quantite FROM piece";
                using (var command = new MySqlCommand(query, dbCon.Connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var piece = new Piece
                            {
                                NumeroProduit = reader.GetString("numero_produit"),
                                Description = reader.GetString("description"),
                                PrixUnitaire = reader.GetDecimal("prix_unitaire"),
                                DateIntroduction = reader.GetDateTime("date_introduction"),
                                DateDiscontinuation = reader.IsDBNull("date_discontinuation") ? (DateTime?)null : reader.GetDateTime("date_discontinuation"),
                                SiretFournisseur = reader.GetString("siret_fournisseur"),
                                DelaiFournisseur = reader.GetInt32("delai_fournisseur"),
                                Quantite = reader.GetFloat("quantite")
                            };
                            pieces.Add(piece);
                        }
                    }
                }
            }

            return pieces;
        }
    }
}
