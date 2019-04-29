namespace GestionAtelier
{
    partial class CreationAtelier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblJour = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.listBoxPerso = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxNbPlace = new System.Windows.Forms.TextBox();
            this.lblNbrPlace = new System.Windows.Forms.Label();
            this.lblHeure = new System.Windows.Forms.Label();
            this.lstBoxHoraire = new System.Windows.Forms.ListBox();
            this.txtBoxDescriptionAtelier = new System.Windows.Forms.TextBox();
            this.lblDescriptionAtelier = new System.Windows.Forms.Label();
            this.lblNomAtelier = new System.Windows.Forms.Label();
            this.txtBoxNomAtelier = new System.Windows.Forms.TextBox();
            this.dateTimePickerJourAtelier = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Création d\'atelier";
            // 
            // lblJour
            // 
            this.lblJour.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblJour.AutoSize = true;
            this.lblJour.Location = new System.Drawing.Point(387, 178);
            this.lblJour.Name = "lblJour";
            this.lblJour.Size = new System.Drawing.Size(113, 17);
            this.lblJour.TabIndex = 28;
            this.lblJour.Text = "Jour de l\'atelier :";
            // 
            // btnAjouter
            // 
            this.btnAjouter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAjouter.Location = new System.Drawing.Point(64, 299);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(602, 60);
            this.btnAjouter.TabIndex = 26;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // listBoxPerso
            // 
            this.listBoxPerso.FormattingEnabled = true;
            this.listBoxPerso.ItemHeight = 16;
            this.listBoxPerso.Items.AddRange(new object[] {
            "Parents",
            "Assistantes Maternelles"});
            this.listBoxPerso.Location = new System.Drawing.Point(387, 243);
            this.listBoxPerso.Name = "listBoxPerso";
            this.listBoxPerso.Size = new System.Drawing.Size(279, 36);
            this.listBoxPerso.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Personnes interessées ";
            // 
            // txtBoxNbPlace
            // 
            this.txtBoxNbPlace.Location = new System.Drawing.Point(517, 76);
            this.txtBoxNbPlace.Name = "txtBoxNbPlace";
            this.txtBoxNbPlace.Size = new System.Drawing.Size(149, 22);
            this.txtBoxNbPlace.TabIndex = 23;
            // 
            // lblNbrPlace
            // 
            this.lblNbrPlace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNbrPlace.AutoSize = true;
            this.lblNbrPlace.Location = new System.Drawing.Point(387, 79);
            this.lblNbrPlace.Name = "lblNbrPlace";
            this.lblNbrPlace.Size = new System.Drawing.Size(124, 17);
            this.lblNbrPlace.TabIndex = 22;
            this.lblNbrPlace.Text = "Nombre de place :";
            // 
            // lblHeure
            // 
            this.lblHeure.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeure.AutoSize = true;
            this.lblHeure.Location = new System.Drawing.Point(387, 125);
            this.lblHeure.Name = "lblHeure";
            this.lblHeure.Size = new System.Drawing.Size(124, 17);
            this.lblHeure.TabIndex = 21;
            this.lblHeure.Text = "Heure de l\'atelier :";
            // 
            // lstBoxHoraire
            // 
            this.lstBoxHoraire.FormattingEnabled = true;
            this.lstBoxHoraire.ItemHeight = 16;
            this.lstBoxHoraire.Items.AddRange(new object[] {
            "8:00",
            "9:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00",
            "22:00",
            "23:00",
            "00:00"});
            this.lstBoxHoraire.Location = new System.Drawing.Point(517, 125);
            this.lstBoxHoraire.Name = "lstBoxHoraire";
            this.lstBoxHoraire.Size = new System.Drawing.Size(149, 20);
            this.lstBoxHoraire.TabIndex = 20;
            // 
            // txtBoxDescriptionAtelier
            // 
            this.txtBoxDescriptionAtelier.Location = new System.Drawing.Point(64, 79);
            this.txtBoxDescriptionAtelier.MaximumSize = new System.Drawing.Size(500, 500);
            this.txtBoxDescriptionAtelier.Multiline = true;
            this.txtBoxDescriptionAtelier.Name = "txtBoxDescriptionAtelier";
            this.txtBoxDescriptionAtelier.Size = new System.Drawing.Size(279, 200);
            this.txtBoxDescriptionAtelier.TabIndex = 19;
            // 
            // lblDescriptionAtelier
            // 
            this.lblDescriptionAtelier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescriptionAtelier.AutoSize = true;
            this.lblDescriptionAtelier.Location = new System.Drawing.Point(61, 59);
            this.lblDescriptionAtelier.Name = "lblDescriptionAtelier";
            this.lblDescriptionAtelier.Size = new System.Drawing.Size(156, 17);
            this.lblDescriptionAtelier.TabIndex = 18;
            this.lblDescriptionAtelier.Text = "Description de l\'atelier :";
            // 
            // lblNomAtelier
            // 
            this.lblNomAtelier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNomAtelier.AutoSize = true;
            this.lblNomAtelier.Location = new System.Drawing.Point(157, 15);
            this.lblNomAtelier.Name = "lblNomAtelier";
            this.lblNomAtelier.Size = new System.Drawing.Size(56, 17);
            this.lblNomAtelier.TabIndex = 17;
            this.lblNomAtelier.Text = "Atelier :";
            // 
            // txtBoxNomAtelier
            // 
            this.txtBoxNomAtelier.Location = new System.Drawing.Point(219, 12);
            this.txtBoxNomAtelier.Name = "txtBoxNomAtelier";
            this.txtBoxNomAtelier.Size = new System.Drawing.Size(447, 22);
            this.txtBoxNomAtelier.TabIndex = 16;
            // 
            // dateTimePickerJourAtelier
            // 
            this.dateTimePickerJourAtelier.Location = new System.Drawing.Point(517, 178);
            this.dateTimePickerJourAtelier.Name = "dateTimePickerJourAtelier";
            this.dateTimePickerJourAtelier.Size = new System.Drawing.Size(149, 22);
            this.dateTimePickerJourAtelier.TabIndex = 29;
            // 
            // CreationAtelier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 550);
            this.Controls.Add(this.dateTimePickerJourAtelier);
            this.Controls.Add(this.lblJour);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.listBoxPerso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxNbPlace);
            this.Controls.Add(this.lblNbrPlace);
            this.Controls.Add(this.lblHeure);
            this.Controls.Add(this.lstBoxHoraire);
            this.Controls.Add(this.txtBoxDescriptionAtelier);
            this.Controls.Add(this.lblDescriptionAtelier);
            this.Controls.Add(this.lblNomAtelier);
            this.Controls.Add(this.txtBoxNomAtelier);
            this.Controls.Add(this.label1);
            this.Name = "CreationAtelier";
            this.Text = "<";
            this.Load += new System.EventHandler(this.CreationAtelier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblJour;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.ListBox listBoxPerso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxNbPlace;
        private System.Windows.Forms.Label lblNbrPlace;
        private System.Windows.Forms.Label lblHeure;
        private System.Windows.Forms.ListBox lstBoxHoraire;
        private System.Windows.Forms.TextBox txtBoxDescriptionAtelier;
        private System.Windows.Forms.Label lblDescriptionAtelier;
        private System.Windows.Forms.Label lblNomAtelier;
        private System.Windows.Forms.TextBox txtBoxNomAtelier;
        private System.Windows.Forms.DateTimePicker dateTimePickerJourAtelier;
    }
}