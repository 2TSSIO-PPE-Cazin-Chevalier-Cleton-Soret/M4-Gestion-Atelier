using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tutorial.SqlConn;

namespace GestionAtelier
{
    public partial class EditionAtelier : Form
    {
        Bitmap bmp;

        public EditionAtelier()
        {
            InitializeComponent();
        }


        private void listAtelier_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                Atelier ate = new Atelier();
                ate = (Atelier)listAtelier.SelectedItem;
                int ateId = ate.GetId();
                Console.WriteLine(ateId);
                MySqlConnection conn = null;
                conn = DBMySQLUtils.GetDBConnection("localhost", "ram", "root", "root");
                String recupEnfant = null;
                recupEnfant = "CALL `recup_Enfant_Atelier2`(@pateId);";
                MySqlCommand afficherEnfant = null;
                afficherEnfant = conn.CreateCommand();
                afficherEnfant.CommandText = recupEnfant;

                afficherEnfant.Parameters.AddWithValue("@pateId", ateId);

                conn.Open();


                DataTable dt = new DataTable();

                MySqlDataAdapter adapter = null;
                adapter = new MySqlDataAdapter(afficherEnfant);
                adapter.Fill(dt);
                dataGridViewListeEnfant.DataSource = null;
                dataGridViewListeEnfant.Rows.Clear();
                dataGridViewListeEnfant.Refresh();
                foreach (DataRow row in dt.Rows)
                {
                    populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString());
                }
                // Terminez la connexion.
                conn.Close();
                // Disposez un objet, libérez des ressources.
                conn.Dispose();


            }
            catch (Exception e5)
            {
                Console.WriteLine("Error: " + e5);
                Console.WriteLine(e5.StackTrace);
            }

            Console.Read();

        }

        private void populate(String id, String prenom, String nom, String tel, String status, String informations, String dateInscription, String dateFinInscription)
        {
            dataGridViewListeEnfant.Rows.Add(id, prenom, nom, tel, status, informations, dateInscription, dateFinInscription);
        }

        private void EditionAtelier_Load(object sender, EventArgs e)
        {
            {
                List<Atelier> lstAtelier = new List<Atelier>();
                MySqlConnection conn = DBMySQLUtils.GetDBConnection("localhost", 3306, "ram", "root", "root");
                string sql = "CALL `recup_Atelier`();";
                // Créez un objet Command.
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                string sql2 = "CALL `recup_Enfant`();";
                // Créez un objet Command.
                MySqlCommand cmd2 = new MySqlCommand(sql2, conn);

                conn.Open();

                using (MySqlDataReader objReader = cmd.ExecuteReader())
                {
                    if (objReader.HasRows)
                    {
                        while (objReader.Read())
                        {
                            //I would also check for DB.Null here before reading the value.
                            int ateId = objReader.GetInt32(objReader.GetOrdinal("ateId"));
                            String ateNom = objReader.GetString(objReader.GetOrdinal("ateNom"));
                            String ateDescription = objReader.GetString(objReader.GetOrdinal("ateDescription"));
                            String ateHoraire = objReader.GetString(objReader.GetOrdinal("ateHoraire"));
                            DateTime ateJour = objReader.GetDateTime(objReader.GetOrdinal("ateJour"));
                            int ateNbrPlace = objReader.GetInt32(objReader.GetOrdinal("ateNbrPlace"));
                            String atePublicConcerne = objReader.GetString(objReader.GetOrdinal("atePublicConcerne"));


                            Atelier atelier = new Atelier(ateId, ateNom, ateDescription, ateHoraire, ateJour, ateNbrPlace, atePublicConcerne);

                            listAtelier.Items.Add(atelier);

                        }
                    }
                }

                conn.Close();

            }
        }

        private void btnImprimer_Click(object sender, EventArgs e)
        {
            int hauteur = dataGridViewListeEnfant.Height;
            dataGridViewListeEnfant.Height = dataGridViewListeEnfant.RowCount * dataGridViewListeEnfant.RowTemplate.Height * 2;
            bmp = new Bitmap(dataGridViewListeEnfant.Width, dataGridViewListeEnfant.Height);
            dataGridViewListeEnfant.DrawToBitmap(bmp, new Rectangle(0, 0, dataGridViewListeEnfant.Width, dataGridViewListeEnfant.Height));
            dataGridViewListeEnfant.Height = hauteur;
            printPreviewDialogEditionAtelier.ShowDialog();
        }

        private void PrintDocumentEditionAelier_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {

            
            int x=10, y=10;
            Atelier ate = new Atelier();
            ate = (Atelier)listAtelier.SelectedItem;
            int ateId = ate.GetId();
            String ateNom = ate.GetNom();
            String ateDescription = ate.GetDescription();
            String ateHoraire = ate.GetHoraire();
            DateTime ateJour = ate.GetJour();
            int ateNbrPlace = ate.GetNbrPlace();
            String atePublicConcerne = ate.GetPublicConcerne();


            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            e.Graphics.DrawString("Voici l'atelier n°" + ateId + " : " + ateNom + " pour les " + atePublicConcerne, drawFont, drawBrush, x, y);
            e.Graphics.DrawString("Description :" + ateDescription + "  Nombre de place total : " + ateNbrPlace, drawFont, drawBrush, x, y + 30);
            e.Graphics.DrawString("Jour :" + ateJour + "  Horaire : " + ateHoraire, drawFont, drawBrush, x, y + 60);
            e.Graphics.DrawString("Voici les enfants inscrits :", drawFont, drawBrush, x, y + 100);

            e.Graphics.DrawImage(bmp, x, y+190);
            }
            catch
            {

            }
        }
    }
}
