using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAtelier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_creation_atelier_Click(object sender, EventArgs e)
        {
            CreationAtelier createAte = new CreationAtelier();
            createAte.TopLevel = false;
            createAte.Parent = panel_main;
            createAte.FormBorderStyle = FormBorderStyle.None;
            createAte.Size = panel_main.ClientSize;
            createAte.BringToFront();
            createAte.Show();
        }

        private void btn_edition_Click(object sender, EventArgs e)
        {
            EditionAtelier createAte = new EditionAtelier();
            createAte.TopLevel = false;
            createAte.Parent = panel_main;
            createAte.FormBorderStyle = FormBorderStyle.None;
            createAte.Size = panel_main.ClientSize;
            createAte.BringToFront();
            createAte.Show();
        }

        private void btn_ajout_enfant_atelier_Click(object sender, EventArgs e)
        {
            AjoutEnfantAtelier createAte = new AjoutEnfantAtelier();
            createAte.TopLevel = false;
            createAte.Parent = panel_main;
            createAte.FormBorderStyle = FormBorderStyle.None;
            createAte.Size = panel_main.ClientSize;
            createAte.BringToFront();
            createAte.Show();
        }
    }
}
