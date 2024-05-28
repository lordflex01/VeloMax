using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace VeloMax
{
    public class Auth
    {
        public string login ; 
        public string mdp;

        public bool Authentication()
        {
            try
            {
                DBConnection dbCon = new DBConnection();

                if (dbCon.IsConnect())
                {
                    String sqlString = "SELECT * FROM admin WHERE login = ?login AND mdp = ?mdp";
                    sqlString = Tools.PrepareLigne(sqlString, "?login", Tools.PrepareChamp(login, "Chaine"));
                    sqlString = Tools.PrepareLigne(sqlString, "?mdp", Tools.PrepareChamp(mdp, "Chaine"));
                    var cmd = new MySqlCommand(sqlString, dbCon.Connection);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                return false;
            }
            catch(MySql.Data.MySqlClient.MySqlException) {
                return false;
            }
        }
    }
}
