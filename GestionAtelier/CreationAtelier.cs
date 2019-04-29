using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Globalization;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using Tutorial.SqlConn;

namespace GestionAtelier
{
    public partial class CreationAtelier : Form
    {
        public CreationAtelier()
        {
            InitializeComponent();
        }

        private void CreationAtelier_Load(object sender, EventArgs e)
        {


        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            string nom = txtBoxNomAtelier.Text;
            string description = txtBoxDescriptionAtelier.Text;
            string horaire = lstBoxHoraire.Text;
            string nbPlace = txtBoxNbPlace.Text;
            string persoConcerne = listBoxPerso.Text;
            DateTime jour = dateTimePickerJourAtelier.Value.Date;

            MySqlConnection conn = DBMySQLUtils.GetDBConnection("localhost", "testplanningppe", "root", "root");
            conn.Open();
            try
            {
             
                string sql = "CALL `creer_Atelier`(@pnom, @pdescription, @phoraire, @pjour, @pnbPlace, @ppersoConcerne);";

                // Créez un objet Command.
                MySqlCommand cmd = new MySqlCommand();

                // Établissez la connexion de la commande.
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@pnom", nom);
                cmd.Parameters.AddWithValue("@pdescription", description);
                cmd.Parameters.AddWithValue("@phoraire", horaire);
                cmd.Parameters.AddWithValue("@pjour", jour);
                cmd.Parameters.AddWithValue("@pnbPlace", nbPlace);
                cmd.Parameters.AddWithValue("@ppersoConcerne", persoConcerne);
                try
                {

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Successfully Inserted");
                    }

                    conn.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conn.Close();
                }



                //    using (System.Data.Common.DbDataReader reader = cmd.ExecuteReader())
                //    {
                //        if (reader.HasRows)
                //        {
                //            while (reader.Read())
                //            {
                //                //string sql = "Select ateId, ateNom, ateDescription, ateHoraire, ateJour, ateNbrPlace, atePublicConcerne from ATELIER";

                //                // Récupérez l'indexe (index) de colonne Emp_ID dans l'instruction de requête SQL.
                //                //string ateId = reader.GetString(0); // 0
                //                string ateNom = reader.GetString(1);
                //                string ateDescription = reader.GetString(2);// 2
                //                string ateHoraire = reader.GetString(3);
                //                string ateJour = reader.GetString(4);
                //                int ateNbrPlace = reader.GetInt32(5);
                //                string atePublicConcerne = reader.GetString(6);

                //                // Index (index) de la colonne Mng_Id dans l'instructions de requête SQL.
                //                String nom_fr_frIndex = reader.GetString(3);

                //                String nom_fr_fr = null;

                //                // Si une colonne est nullable, vérifiez toujours DBNull ...
                //                //if (!reader.IsDBNull(nom_fr_frIndex))
                //                //{
                //                //    //nom_fr_fr = Convert.ToInt64(reader.GetValue(nom_fr_frIndex));
                //                //}

                //                //this.dataGridViewPlanning.Rows.Add(ateNom, ateDescription, ateHoraire, ateJour, ateNbrPlace, atePublicConcerne);
                //                int iLEL = 0;
                //                while (iLEL < 19)
                //                {
                //                    iLEL++;
                //                    Atelier atelier = new Atelier(ateNom, ateDescription, ateHoraire, ateNbrPlace, atePublicConcerne);

                //                    if (atelier != null)
                //                    {
                //                        Console.WriteLine(atelier.ToString());
                //                    }

                //                    if (iLEL >= 10)
                //                    {
                //                        break;
                //                    }
                //                }
                //            }
                //        }
                //    }


                //add(prenom, nom, telephone, status, informations, dateInscription, dateFinInscription);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }




        }


        private void add(String prenom, String nom, String telephone, String status, String informations, DateTime dateInscription, DateTime dateFinInscription)
        {
            ////SQL STMT
            MySqlConnection conn = DBMySQLUtils.GetDBConnection("localhost", 3306, "testplanningppe", "root", "root");
            conn.Open();
            string sql = "call `creer_enfant`(@prenom , @nom, @telephone, @status, @informations, @dateinscription, @datefininscription );";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            ////ADD PARAMETERS
            cmd.Parameters.AddWithValue("@prenom", prenom);
            cmd.Parameters.AddWithValue("@nom", nom);
            cmd.Parameters.AddWithValue("@telephone", telephone);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@informations", informations);
            cmd.Parameters.AddWithValue("@dateInscription", dateInscription);
            cmd.Parameters.AddWithValue("@dateFinInscription", dateFinInscription);
            ////OPEN CON AND EXEC insert
            try
            {

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Successfully Inserted");
                }

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

    }
}