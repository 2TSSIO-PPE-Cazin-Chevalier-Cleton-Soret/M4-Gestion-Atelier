using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tutorial.SqlConn;

namespace GestionAtelier
{
    public partial class AjoutEnfantAtelier : Form
    {
        public AjoutEnfantAtelier()
        {
            InitializeComponent();
        }

        private void listAtelier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AjoutEnfantAtelier_Load(object sender, EventArgs e)
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

                        //lstAtelier.Add(item);
                        listAtelier.Items.Add(atelier);

                    }
                }
            }

            using (MySqlDataReader objReader2 = cmd2.ExecuteReader())
            {
                if (objReader2.HasRows)
                {
                    while (objReader2.Read())
                    {
                        //I would also check for DB.Null here before reading the value.
                        int enfId = objReader2.GetInt32(objReader2.GetOrdinal("enfId"));
                        String enfPrenom = objReader2.GetString(objReader2.GetOrdinal("enfPrenom"));
                        String enfNom = objReader2.GetString(objReader2.GetOrdinal("enfNom"));
                        String enfNumTelParent = objReader2.GetString(objReader2.GetOrdinal("enfNumTelParent"));
                        String enfStatut = objReader2.GetString(objReader2.GetOrdinal("enfStatut"));
                        String enfInformations = objReader2.GetString(objReader2.GetOrdinal("enfInformations"));
                        DateTime enfDateInscription = objReader2.GetDateTime(objReader2.GetOrdinal("enfDateInscription"));
                        DateTime enfDateFinInscription = objReader2.GetDateTime(objReader2.GetOrdinal("enfDateFinInscription"));

                        Enfant enfant = new Enfant(enfId, enfPrenom, enfNom, enfNumTelParent, enfStatut, enfInformations, enfDateInscription, enfDateFinInscription);

                        //lstAtelier.Add(item);
                        listEnfant.Items.Add(enfant);

                    }
                }
            }
            conn.Close();

           // listAtelier.Items.Add(lstAtelier);
        }



        private void btnAjoutEnfantAtelier_Click(object sender, EventArgs e)
        {
            Console.WriteLine(listEnfant.SelectedItem);
            Console.WriteLine(listAtelier.SelectedItem);
            Atelier ate = new Atelier();
            ate = (Atelier) listAtelier.SelectedItem;
            Console.WriteLine(ate);
            int ateId = ate.GetId();
            Console.WriteLine(ateId);
            Enfant enf = new Enfant();
            enf = (Enfant)listEnfant.SelectedItem;
            int enfId = enf.GetId();
            Console.WriteLine(enfId);

            MySqlConnection conn = DBMySQLUtils.GetDBConnection("localhost", 3306, "ram", "root", "root");
            string sql = "CALL `creer_Lien`(@pEnfId , @pAteId);";
            // Créez un objet Command.
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@pEnfId", enfId);
            cmd.Parameters.AddWithValue("@pAteId", ateId);

            conn.Open();
            try
            {

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Enfant mis à jour");
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
