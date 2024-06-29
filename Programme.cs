using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeloMax
{
    public class Programme
    {
        public int IdProgramme { get; set; }
        public string Description { get; set; }
        public decimal Cout { get; set; }
        public int Duree { get; set; }
        public decimal PourcentageRabais { get; set; }


        public void AddProgramme()
        {
            DBConnection dbCon = new DBConnection();
            if (dbCon.IsConnect())
            {
                string query = "INSERT INTO programme (description, cout, duree, pourcentage_rabais) VALUES (@description, @cout, @duree, @pourcentage_rabais)";
                var command = new MySqlCommand(query, dbCon.Connection);

                command.Parameters.AddWithValue("@description", Description);
                command.Parameters.AddWithValue("@cout", Cout);
                command.Parameters.AddWithValue("@duree", Duree);
                command.Parameters.AddWithValue("@pourcentage_rabais", PourcentageRabais);

                command.ExecuteNonQuery();
                dbCon.Close();
            }
        }

        public void UpdateProgramme(int IdProgramme)
        {
            DBConnection dbCon = new DBConnection();
            if (dbCon.IsConnect())
            {
                string query = "UPDATE programme SET description = @description, cout = @cout, duree = @duree, pourcentage_rabais = @pourcentage_rabais WHERE idProgramme = @idProgramme";
                var command = new MySqlCommand(query, dbCon.Connection);

                command.Parameters.AddWithValue("@idProgramme", IdProgramme);
                command.Parameters.AddWithValue("@description", Description);
                command.Parameters.AddWithValue("@cout", Cout);
                command.Parameters.AddWithValue("@duree", Duree);
                command.Parameters.AddWithValue("@pourcentage_rabais", PourcentageRabais);

                command.ExecuteNonQuery();
                dbCon.Close();
            }
        }

        public void DeleteProgramme(int idProgramme)
        {
            DBConnection dbCon = new DBConnection();
            if (dbCon.IsConnect())
            {
                string query = "DELETE FROM programme WHERE idProgramme = @idProgramme";
                var command = new MySqlCommand(query, dbCon.Connection);

                command.Parameters.AddWithValue("@idProgramme", idProgramme);
                command.ExecuteNonQuery();
                dbCon.Close();
            }
        }

        public List<Programme> GetAllProgrammes()
        {
            List<Programme> programmes = new List<Programme>();

            DBConnection dbCon = new DBConnection();
            if (dbCon.IsConnect())
            {

                string query = "SELECT idProgramme, description, cout, duree, pourcentage_rabais FROM programme";
                var command = new MySqlCommand(query, dbCon.Connection);
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var programme = new Programme
                    {
                        IdProgramme = reader.GetInt32("idProgramme"),
                        Description = reader.GetString("description"),
                        Cout = reader.GetDecimal("cout"),
                        Duree = reader.GetInt32("duree"),
                        PourcentageRabais = reader.GetDecimal("pourcentage_rabais")
                    };
                    programmes.Add(programme);
                }
                dbCon.Close();

            }

            return programmes;
        }
    }
}
