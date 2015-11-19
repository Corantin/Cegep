using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows;

namespace BDServices
{
    public class BDService
    {
        public MySqlConnection connexion;

        private string Serveur = "localhost";
        private string DataBase = "Tentative";
        private string Uid = "root";
        private string PW = "";

        public BDService()
        {
            try
            {
                string connexionString;
                connexionString = "SERVER=" + Serveur + ";DATABASE=" + DataBase + ";UID=" + Uid + ";PASSWORD=" + PW + ";";
                //MessageBox.Show(connexionString);
                connexion = new MySqlConnection(connexionString);
            }
            catch (Exception e)
            {
                MessageBox.Show("Connection défectueuse" + e.ToString());
            }
        }
        public  void Truncate(string sql)
        {

        }

        private bool OpenConnexion()
        {
            try
            {
                connexion.Open();
                return true;
            }
            catch (Exception e)
            {

                MessageBox.Show("Impossible d'ouvrir la connexion : " + e.ToString());
                return false;
            }
        }

        private void CloseConnexion()
        {
            try
            {
                connexion.Close();
                
            }
            catch (Exception e)
            {

                MessageBox.Show("Impossible de fermer la connexion : " + e.ToString());
            }
        }

        public long Insert(string sql)
        {
            long retVal = 0;
            try
            {
                if(this.OpenConnexion())
                {
                    MySqlCommand cmd = new MySqlCommand(sql, connexion);
                    
                    cmd.ExecuteNonQuery();

                    this.CloseConnexion();

                    retVal = cmd.LastInsertedId;

                    return retVal;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur dans le INSERT : " + e.ToString());
            }
            return retVal;
        }
        public long Update(string sql)
        {
            return 0;
        }
        public long Delete(string sql)
        {
            return 0;
        }
        public List<string>[] Select(string sql)
        {
            List<string> infoBrute = new List<string>();
            int nbLigne = 0;
            int nbChamp = 0;
            try
            {
                if (this.OpenConnexion())
                {
                    MySqlCommand cmd = new MySqlCommand(sql, connexion);

                    MySqlDataReader dr = cmd.ExecuteReader();

                    nbChamp = dr.FieldCount;

                    
                    while (dr.Read())
                    {// On a le reccord courrant qui contient nbChamp
                        for (int i = 0; i < nbChamp; i++)
                        {
                            infoBrute.Add(dr[i].ToString());
                        }
                        nbLigne++;
                    }

                    dr.Close();

                    this.CloseConnexion();

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur dans le SELECT : " + e.ToString());
                return null;
            }

            // On construit le tableau des données à retourner
            List<string>[] lstFinale;
            if (nbLigne == 0)
            {
                lstFinale = new List<string>[1];
                lstFinale[0] = new List<string>();
                lstFinale[0].Add("");
            }
            else
            {
                lstFinale = new List<string>[nbLigne];
                for (int i = 0; i < nbLigne; i++)
                {
                    lstFinale[i] = new List<string>();
                    
                    for (int j = 0; j < nbChamp; j++)
                    {
                        int indice = j + (i * nbChamp);
                        lstFinale[i].Add(infoBrute[indice]);
                    }
                }
                
            }

            return lstFinale;
        }
    }
}
