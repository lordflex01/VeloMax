using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace VeloMax
{
    public enum TypeContrat
    {
        [EnumMember(Value = "plein temps")]
        PleinTemps,

        [EnumMember(Value = "temps partiel")]
        TempsPartiel
    }
    
    public class Employe
    {
        
        public int IdEmploye { get; set; }

        public string Nom { get; set; }

        public TypeContrat TypeContrat { get; set; }

        public string Role { get; set; }

        public float Salaire { get; set; }

        public float? Prime { get; set; }

        public List<Employe> GetAllEmployes()
        {
            List<Employe> employes = new List<Employe>();

            try
            {
                DBConnection dbCon = new DBConnection();
                if (dbCon.IsConnect())
                {
                    string selectAllQuery = "SELECT * FROM employe";
                    MySqlCommand selectCmd = new MySqlCommand(selectAllQuery, dbCon.Connection);
                    using (MySqlDataReader reader = selectCmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Employe employe = new Employe
                            {
                                IdEmploye = reader.GetInt32("idEmploye"),
                                Nom = reader.GetString("nom"),
                                TypeContrat = (TypeContrat)Enum.Parse(typeof(TypeContrat), reader.GetString("type_contrat"), true),
                                Role = reader.IsDBNull(reader.GetOrdinal("role")) ? null : reader.GetString("role"),
                                Salaire = reader.GetFloat("salaire"),
                                Prime = reader.IsDBNull(reader.GetOrdinal("prime")) ? null : (float?)reader.GetFloat("prime")
                            };
                            employes.Add(employe);
                        }
                    }
                    dbCon.Close();
                }
            }
            catch (MySqlException ex)
            {
                // Gérer les exceptions SQL
                throw new Exception("Une erreur est survenue lors de la récupération des employés.", ex);
            }

            return employes;
        }

        public void AddEmploye()
        {
            try
            {
                DBConnection dbCon = new DBConnection();
                if (dbCon.IsConnect())
                {
                    // Vérifier si l'employé existe déjà
                    string checkIfExistsQuery = "SELECT COUNT(*) FROM employe WHERE nom = @nom";
                    MySqlCommand checkCmd = new MySqlCommand(checkIfExistsQuery, dbCon.Connection);
                    checkCmd.Parameters.AddWithValue("@nom", Nom);

                    long existingCount = (long)checkCmd.ExecuteScalar();

                    if (existingCount > 0)
                    {
                        throw new InvalidOperationException("Cet employé existe déjà.");
                    }

                    // Ajouter l'employé s'il n'existe pas déjà
                    string addEmployeQuery = "INSERT INTO employe (nom, type_contrat, role, salaire, prime) VALUES (@nom, @type_contrat, @role, @salaire, @prime)";
                    MySqlCommand addCmd = new MySqlCommand(addEmployeQuery, dbCon.Connection);
                    addCmd.Parameters.AddWithValue("@nom", Nom);
                    addCmd.Parameters.AddWithValue("@type_contrat", TypeContrat.ToString().ToLower());
                    addCmd.Parameters.AddWithValue("@role", Role ?? "");
                    addCmd.Parameters.AddWithValue("@salaire", Salaire);
                    addCmd.Parameters.AddWithValue("@prime", Prime ?? (object)DBNull.Value);

                    addCmd.ExecuteNonQuery();
                    dbCon.Close();
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                // Handle exception
            }
        }


        public void UpdateEmploye(int id)
        {
            try
            {
                DBConnection dbCon = new DBConnection();
                if (dbCon.IsConnect())
                {
                    string updateEmployeQuery = "UPDATE employe SET nom = @nom, type_contrat = @type_contrat, role = @role, salaire = @salaire, prime = @prime WHERE idEmploye = @idEmploye";
                    MySqlCommand updateCmd = new MySqlCommand(updateEmployeQuery, dbCon.Connection);
                    updateCmd.Parameters.AddWithValue("@nom", Nom);
                    updateCmd.Parameters.AddWithValue("@type_contrat", TypeContrat.ToString().ToLower());
                    updateCmd.Parameters.AddWithValue("@role", Role ?? "");
                    updateCmd.Parameters.AddWithValue("@salaire", Salaire);
                    updateCmd.Parameters.AddWithValue("@prime", Prime ?? (object)DBNull.Value);
                    updateCmd.Parameters.AddWithValue("@idEmploye", IdEmploye);

                    int rowsAffected = updateCmd.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new InvalidOperationException("L'employé à mettre à jour n'existe pas.");
                    }
                    dbCon.Close();
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                // Handle exception
                throw new Exception("Une erreur est survenue lors de la mise à jour de l'employé.", ex);
            }
        }


        public void DeleteEmploye(int id)
        {
            try
            {
                DBConnection dbCon = new DBConnection();
                if (dbCon.IsConnect())
                {
                    string deleteEmployeQuery = "DELETE FROM employe WHERE idEmploye = @idEmploye";
                    MySqlCommand deleteCmd = new MySqlCommand(deleteEmployeQuery, dbCon.Connection);
                    deleteCmd.Parameters.AddWithValue("@idEmploye", IdEmploye);

                    int rowsAffected = deleteCmd.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new InvalidOperationException("L'employé à supprimer n'existe pas.");
                    }
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
