using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeloMax
{
    public class Velo
    {
        public string? NumeroProduit { get; set; }
        public string Nom { get; set; }
        public string Grandeur { get; set; }
        public decimal PrixUnitaire { get; set; }
        public LigneProduitEnum LigneProduit { get; set; }
        public DateTime? DateIntroduction { get; set; }
        public DateTime? DateDiscontinuation { get; set; }

        public enum LigneProduitEnum
        {
            VTT,
            Classique,
            BMX,
            VeloDeCourse
        }

        public List<Velo> GetAllVelos()
        {
            var velos = new List<Velo>();

            DBConnection dbCon = new DBConnection();
            if (dbCon.IsConnect())
            {
                string query = "SELECT numero_produit, nom, grandeur, prix_unitaire, ligne_produit, date_introduction, date_discontinuation FROM velo";
                var command = new MySqlCommand(query, dbCon.Connection);
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var velo = new Velo
                    {
                        NumeroProduit = reader.GetString("numero_produit"),
                        Nom = reader.GetString("nom"),
                        Grandeur = reader.GetString("grandeur"),
                        PrixUnitaire = reader.GetDecimal("prix_unitaire"),
                        LigneProduit = (Velo.LigneProduitEnum)Enum.Parse(typeof(Velo.LigneProduitEnum), reader.GetString("ligne_produit")),
                        DateIntroduction = reader.IsDBNull(reader.GetOrdinal("date_introduction")) ? (DateTime?)null : reader.GetDateTime("date_introduction"),
                        DateDiscontinuation = reader.IsDBNull(reader.GetOrdinal("date_discontinuation")) ? (DateTime?)null : reader.GetDateTime("date_discontinuation")
                    };
                    velos.Add(velo);
                }
                
            }

            return velos;
        }

        public void AddVelo()
        {
            try
            {
                DBConnection dbCon = new DBConnection();
                if (dbCon.IsConnect())
                {
                    string query = "SELECT COUNT(*) FROM velo WHERE numero_produit = @NumeroProduit";
                    var command = new MySqlCommand(query, dbCon.Connection);
                    command.Parameters.AddWithValue("@NumeroProduit", NumeroProduit);
                    var count = Convert.ToInt32(command.ExecuteScalar());

                    if (count > 0)
                    {
                        throw new Exception("Le vélo existe déjà.");
                    }
                    query = "INSERT INTO velo (numero_produit, nom, grandeur, prix_unitaire, ligne_produit, date_introduction, date_discontinuation) VALUES (@NumeroProduit, @Nom, @Grandeur, @PrixUnitaire, @LigneProduit, @DateIntroduction, @DateDiscontinuation)";
                    var result = new MySqlCommand(query, dbCon.Connection);
                    {
                        result.Parameters.AddWithValue("@NumeroProduit", NumeroProduit);
                        result.Parameters.AddWithValue("@Nom", Nom);
                        result.Parameters.AddWithValue("@Grandeur", Grandeur);
                        result.Parameters.AddWithValue("@PrixUnitaire", PrixUnitaire);
                        result.Parameters.AddWithValue("@LigneProduit", LigneProduit.ToString());
                        result.Parameters.AddWithValue("@DateIntroduction", DateIntroduction);
                        result.Parameters.AddWithValue("@DateDiscontinuation", DateDiscontinuation);

                        result.ExecuteNonQuery();
                        dbCon.Close();
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void UpdateVelo(string NumeroProduit)
        {
            try
            {
                DBConnection dbCon = new DBConnection();
                if (dbCon.IsConnect())
                {
                    string query = "UPDATE velo SET nom = @Nom, grandeur = @Grandeur, prix_unitaire = @PrixUnitaire, ligne_produit = @LigneProduit, date_introduction = @DateIntroduction, date_discontinuation = @DateDiscontinuation WHERE numero_produit = @NumeroProduit";
                    var command = new MySqlCommand(query, dbCon.Connection);

                    command.Parameters.AddWithValue("@NumeroProduit", NumeroProduit);
                    command.Parameters.AddWithValue("@Nom", Nom);
                    command.Parameters.AddWithValue("@Grandeur", Grandeur);
                    command.Parameters.AddWithValue("@PrixUnitaire", PrixUnitaire);
                    command.Parameters.AddWithValue("@LigneProduit", LigneProduit.ToString());
                    command.Parameters.AddWithValue("@DateIntroduction", DateIntroduction);
                    command.Parameters.AddWithValue("@DateDiscontinuation", DateDiscontinuation);

                    command.ExecuteNonQuery();
                    dbCon.Close();

                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                // Handle exception
            }
        }

        public void DeleteVelo(string numeroProduit)
        {
            try
            {
                DBConnection dbCon = new DBConnection();
                if (dbCon.IsConnect())
                {
                    string query = "DELETE FROM velo WHERE numero_produit = @NumeroProduit";
                    var command = new MySqlCommand(query, dbCon.Connection);

                    command.Parameters.AddWithValue("@NumeroProduit", numeroProduit);
                    command.ExecuteNonQuery();
                    dbCon.Close();

                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                // Handle exception
            }
        }
    }
}
