namespace GestionAtelier
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_top = new System.Windows.Forms.Panel();
            this.lbl_panel_actuel = new System.Windows.Forms.Label();
            this.panel_titre = new System.Windows.Forms.Panel();
            this.panel_creation_atelier = new System.Windows.Forms.Panel();
            this.titre = new System.Windows.Forms.Label();
            this.panel_lst_btn = new System.Windows.Forms.Panel();
            this.btn_ajout_enfant_atelier = new System.Windows.Forms.Button();
            this.btn_edition_atelier = new System.Windows.Forms.Button();
            this.btn_creation_atelier = new System.Windows.Forms.Button();
            this.panel_main = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel_top.SuspendLayout();
            this.panel_titre.SuspendLayout();
            this.panel_lst_btn.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.White;
            this.panel_top.Controls.Add(this.lbl_panel_actuel);
            this.panel_top.Controls.Add(this.panel_titre);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Margin = new System.Windows.Forms.Padding(4);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1924, 123);
            this.panel_top.TabIndex = 0;
            // 
            // lbl_panel_actuel
            // 
            this.lbl_panel_actuel.AutoSize = true;
            this.lbl_panel_actuel.Font = new System.Drawing.Font("Century Gothic", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_panel_actuel.Location = new System.Drawing.Point(587, 39);
            this.lbl_panel_actuel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_panel_actuel.Name = "lbl_panel_actuel";
            this.lbl_panel_actuel.Size = new System.Drawing.Size(0, 46);
            this.lbl_panel_actuel.TabIndex = 1;
            // 
            // panel_titre
            // 
            this.panel_titre.BackColor = System.Drawing.Color.Aqua;
            this.panel_titre.Controls.Add(this.panel_creation_atelier);
            this.panel_titre.Controls.Add(this.titre);
            this.panel_titre.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_titre.Location = new System.Drawing.Point(0, 0);
            this.panel_titre.Margin = new System.Windows.Forms.Padding(4);
            this.panel_titre.Name = "panel_titre";
            this.panel_titre.Size = new System.Drawing.Size(1924, 123);
            this.panel_titre.TabIndex = 0;
            // 
            // panel_creation_atelier
            // 
            this.panel_creation_atelier.Location = new System.Drawing.Point(533, 123);
            this.panel_creation_atelier.Name = "panel_creation_atelier";
            this.panel_creation_atelier.Size = new System.Drawing.Size(1391, 929);
            this.panel_creation_atelier.TabIndex = 1;
            // 
            // titre
            // 
            this.titre.AutoSize = true;
            this.titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre.ForeColor = System.Drawing.Color.White;
            this.titre.Location = new System.Drawing.Point(745, 39);
            this.titre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(269, 44);
            this.titre.TabIndex = 0;
            this.titre.Text = "Les fripouilles";
            // 
            // panel_lst_btn
            // 
            this.panel_lst_btn.BackColor = System.Drawing.Color.Salmon;
            this.panel_lst_btn.Controls.Add(this.btn_ajout_enfant_atelier);
            this.panel_lst_btn.Controls.Add(this.btn_edition_atelier);
            this.panel_lst_btn.Controls.Add(this.btn_creation_atelier);
            this.panel_lst_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_lst_btn.Location = new System.Drawing.Point(0, 123);
            this.panel_lst_btn.Margin = new System.Windows.Forms.Padding(4);
            this.panel_lst_btn.Name = "panel_lst_btn";
            this.panel_lst_btn.Size = new System.Drawing.Size(533, 932);
            this.panel_lst_btn.TabIndex = 1;
            // 
            // btn_ajout_enfant_atelier
            // 
            this.btn_ajout_enfant_atelier.BackColor = System.Drawing.Color.Salmon;
            this.btn_ajout_enfant_atelier.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ajout_enfant_atelier.FlatAppearance.BorderSize = 0;
            this.btn_ajout_enfant_atelier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btn_ajout_enfant_atelier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ajout_enfant_atelier.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajout_enfant_atelier.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_ajout_enfant_atelier.Location = new System.Drawing.Point(0, 246);
            this.btn_ajout_enfant_atelier.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ajout_enfant_atelier.Name = "btn_ajout_enfant_atelier";
            this.btn_ajout_enfant_atelier.Size = new System.Drawing.Size(533, 123);
            this.btn_ajout_enfant_atelier.TabIndex = 2;
            this.btn_ajout_enfant_atelier.Text = "Ajout d\'enfant dans un atelier";
            this.btn_ajout_enfant_atelier.UseVisualStyleBackColor = false;
            this.btn_ajout_enfant_atelier.Click += new System.EventHandler(this.btn_ajout_enfant_atelier_Click);
            // 
            // btn_edition_atelier
            // 
            this.btn_edition_atelier.BackColor = System.Drawing.Color.Salmon;
            this.btn_edition_atelier.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_edition_atelier.FlatAppearance.BorderSize = 0;
            this.btn_edition_atelier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btn_edition_atelier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edition_atelier.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edition_atelier.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_edition_atelier.Location = new System.Drawing.Point(0, 123);
            this.btn_edition_atelier.Margin = new System.Windows.Forms.Padding(0);
            this.btn_edition_atelier.Name = "btn_edition_atelier";
            this.btn_edition_atelier.Size = new System.Drawing.Size(533, 123);
            this.btn_edition_atelier.TabIndex = 1;
            this.btn_edition_atelier.Text = "Edition et visualisation des ateliers";
            this.btn_edition_atelier.UseVisualStyleBackColor = false;
            this.btn_edition_atelier.Click += new System.EventHandler(this.btn_edition_Click);
            // 
            // btn_creation_atelier
            // 
            this.btn_creation_atelier.BackColor = System.Drawing.Color.Salmon;
            this.btn_creation_atelier.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_creation_atelier.FlatAppearance.BorderSize = 0;
            this.btn_creation_atelier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btn_creation_atelier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_creation_atelier.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_creation_atelier.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_creation_atelier.Location = new System.Drawing.Point(0, 0);
            this.btn_creation_atelier.Margin = new System.Windows.Forms.Padding(0);
            this.btn_creation_atelier.Name = "btn_creation_atelier";
            this.btn_creation_atelier.Size = new System.Drawing.Size(533, 123);
            this.btn_creation_atelier.TabIndex = 0;
            this.btn_creation_atelier.Text = "Création des ateliers";
            this.btn_creation_atelier.UseVisualStyleBackColor = false;
            this.btn_creation_atelier.Click += new System.EventHandler(this.btn_creation_atelier_Click);
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_main.Location = new System.Drawing.Point(533, 123);
            this.panel_main.Margin = new System.Windows.Forms.Padding(4);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(2027, 1157);
            this.panel_main.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_lst_btn);
            this.Controls.Add(this.panel_top);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.panel_titre.ResumeLayout(false);
            this.panel_titre.PerformLayout();
            this.panel_lst_btn.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Panel panel_lst_btn;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Button btn_creation_atelier;
        private System.Windows.Forms.Panel panel_titre;
        private System.Windows.Forms.Label titre;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_edition_atelier;
        private System.Windows.Forms.Label lbl_panel_actuel;


        #endregion
        private System.Windows.Forms.Panel panel_creation_atelier;
        private System.Windows.Forms.Button btn_ajout_enfant_atelier;
    }
}
