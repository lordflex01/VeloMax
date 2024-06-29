using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeloMax
{
    public class Adhesion
    {
        public int IdAdhesion { get; set; }
        public int IdClient { get; set; }
        public int IdProgramme { get; set; }
        public DateTime DateAdhesion { get; set; }
        public DateTime DateExpiration { get; set; }

        public void AddAdhesion()
        {
            DBConnection dbCon = new DBConnection();
            if (dbCon.IsConnect())
            {

                string query = "INSERT INTO adhesions (id_client, id_programme, date_adhesion, date_expiration) VALUES (@id_client, @id_programme, @date_adhesion, @date_expiration)";
                var command = new MySqlCommand(query, dbCon.Connection);

                command.Parameters.AddWithValue("@id_client", IdClient);
                command.Parameters.AddWithValue("@id_programme", IdProgramme);
                command.Parameters.AddWithValue("@date_adhesion", DateAdhesion);
                command.Parameters.AddWithValue("@date_expiration", DateExpiration);

                command.ExecuteNonQuery();
                dbCon.Close();
            }
        }

        public void UpdateAdhesion(Adhesion adhesion)
        {
            DBConnection dbCon = new DBConnection();
            if (dbCon.IsConnect())
            {
                string query = "UPDATE adhesions SET id_client = @id_client, id_programme = @id_programme, date_adhesion = @date_adhesion, date_expiration = @date_expiration WHERE id_adhesion = @id_adhesion";
                var command = new MySqlCommand(query, dbCon.Connection);

                command.Parameters.AddWithValue("@id_adhesion", IdAdhesion);
                command.Parameters.AddWithValue("@id_client", IdClient);
                command.Parameters.AddWithValue("@id_programme", IdProgramme);
                command.Parameters.AddWithValue("@date_adhesion", DateAdhesion);
                command.Parameters.AddWithValue("@date_expiration", DateExpiration);

                command.ExecuteNonQuery();
                dbCon.Close();
            }
        }

        public void DeleteAdhesion(int idAdhesion)
        {
            DBConnection dbCon = new DBConnection();
            if (dbCon.IsConnect())
            {
                string query = "DELETE FROM adhesions WHERE id_adhesion = @id_adhesion";
                var command = new MySqlCommand(query, dbCon.Connection);

                command.Parameters.AddWithValue("@id_adhesion", idAdhesion);
                command.ExecuteNonQuery();
                dbCon.Close();
            }
        }

        public List<Adhesion> GetAllAdhesions()
        {
            List<Adhesion> adhesions = new List<Adhesion>();

            DBConnection dbCon = new DBConnection();
            if (dbCon.IsConnect())
            {
                string query = "SELECT id_adhesion, id_client, id_programme, date_adhesion, date_expiration FROM adhesions";
                var command = new MySqlCommand(query, dbCon.Connection);
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var adhesion = new Adhesion
                    {
                        IdAdhesion = reader.GetInt32("id_adhesion"),
                        IdClient = reader.GetInt32("id_client"),
                        IdProgramme = reader.GetInt32("id_programme"),
                        DateAdhesion = reader.GetDateTime("date_adhesion"),
                        DateExpiration = reader.GetDateTime("date_expiration")
                    };
                    adhesions.Add(adhesion);
                }
                dbCon.Close();

            }

            return adhesions;
        }
    }
}
