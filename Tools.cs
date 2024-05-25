using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeloMax
{
    class Tools
    {
        public static String PrepareChamp(String LaValeur, String LeType)
        {
            string ValeurPreparee = "";
            switch (LeType)
            {
                case "Chaine":
                    ValeurPreparee = "'" + LaValeur + "'";
                    break;

                case "Nombre":
                    ValeurPreparee = LaValeur;
                    break;
            }
            return ValeurPreparee;
        }

        public static String PrepareLigne(String LaLigne, String LeMotCle, String LaValeur)
        {
            string LignePreparee = "";
            LignePreparee = LaLigne.Replace(LeMotCle, LaValeur);
            return LignePreparee;
        }

        public static void AppelerProcedureStockee(DBConnection DataBaseConnection)
        {
            try
            {
                String sqlString = "Compter_Enregistrement";
                var cmd = new MySqlCommand(sqlString, DataBaseConnection.Connection);
                cmd.CommandType = CommandType.StoredProcedure; //Il faut System.Data pour cette ligne

                cmd.Parameters.Add("@NbLignes", MySqlDbType.Int32);
                cmd.Parameters["@NbLignes"].Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                Console.WriteLine("Nombre de Client(s): " + cmd.Parameters["@NbLignes"].Value);
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.Write("Erreur N° " + ex.Number + " : " + ex.Message);
            }
        }

        public static bool VeriferMail(string str1) //Fonction qui retourne un booleen, vrai si l'email semble Correct
        {
            bool isOK = true;
            if (str1.Length == 0)//Longueur nulle
                isOK = false;
            if (CompterCar(str1, '@') != 1)//Pas un @ et un seul
                isOK = false;
            int posDernierPoint = LastPosCar(str1, '.'); //On en aura besoin plus loin, on peut donc utiliser des locales
            int posDernierArobase = LastPosCar(str1, '@');
            if (posDernierPoint < posDernierArobase)
                isOK = false;//PAs de point apres @
            if (posDernierPoint > posDernierArobase)
            {
                if ((posDernierPoint - posDernierArobase) < 2)
                    isOK = false;//Pas au moins un caractere entre @ et dernier point
            }
            if ((str1.Length - posDernierPoint) <= 2) //pas au moins deux caracteres apres dernier point
                isOK = false;
            if (posDernierArobase < 1) //Au moins un caractere avant @
                isOK = false;
            if (CompterCar(str1, ' ') != 0)//Presence de caractere espace
                isOK = false;
            return isOK;
        }

        private static int LastPosCar(string str1, char lecaractere) //Retourne la dernière position d'un caractere dans une chaine, -1 sinon
        {
            int pos = -1;
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] == lecaractere)
                    pos = i;
            }
            return pos;
        }

        private static int CompterCar(string str1, char lecaractere) //Retourne le nombre de fois où un caractere figure dans une chaine
        {
            int cpt = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] == lecaractere)
                    cpt++;
            }
            return cpt;
        }
    }
}
