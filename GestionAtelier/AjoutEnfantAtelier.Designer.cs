using System;

namespace GestionAtelier
{
    partial class AjoutEnfantAtelier
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
            this.listAtelier = new System.Windows.Forms.ListBox();
            this.listEnfant = new System.Windows.Forms.ListBox();
            this.btnAjoutEnfantAtelier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ajout d\'enfants aux ateliers";
            // 
            // listAtelier
            // 
            this.listAtelier.FormattingEnabled = true;
            this.listAtelier.ItemHeight = 16;
            this.listAtelier.Location = new System.Drawing.Point(408, 48);
            this.listAtelier.Name = "listAtelier";
            this.listAtelier.Size = new System.Drawing.Size(331, 324);
            this.listAtelier.TabIndex = 6;
            this.listAtelier.SelectedIndexChanged += new System.EventHandler(this.listAtelier_SelectedIndexChanged);
            // 
            // listEnfant
            // 
            this.listEnfant.FormattingEnabled = true;
            this.listEnfant.ItemHeight = 16;
            this.listEnfant.Location = new System.Drawing.Point(15, 48);
            this.listEnfant.Name = "listEnfant";
            this.listEnfant.Size = new System.Drawing.Size(354, 324);
            this.listEnfant.TabIndex = 8;
            this.listEnfant.SelectedIndexChanged += new System.EventHandler(this.listEnfant_SelectedIndexChanged);
            // 
            // btnAjoutEnfantAtelier
            // 
            this.btnAjoutEnfantAtelier.Location = new System.Drawing.Point(15, 396);
            this.btnAjoutEnfantAtelier.Name = "btnAjoutEnfantAtelier";
            this.btnAjoutEnfantAtelier.Size = new System.Drawing.Size(227, 57);
            this.btnAjoutEnfantAtelier.TabIndex = 9;
            this.btnAjoutEnfantAtelier.Text = "Ajouter l\'enfant à l\'atelier";
            this.btnAjoutEnfantAtelier.UseVisualStyleBackColor = true;
            this.btnAjoutEnfantAtelier.Click += new System.EventHandler(this.btnAjoutEnfantAtelier_Click);
            // 
            // AjoutEnfantAtelier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 465);
            this.Controls.Add(this.btnAjoutEnfantAtelier);
            this.Controls.Add(this.listEnfant);
            this.Controls.Add(this.listAtelier);
            this.Controls.Add(this.label1);
            this.Name = "AjoutEnfantAtelier";
            this.Text = "AjoutEnfantAtelier";
            this.Load += new System.EventHandler(this.AjoutEnfantAtelier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void listEnfant_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listAtelier;
        private System.Windows.Forms.ListBox listEnfant;
        private System.Windows.Forms.Button btnAjoutEnfantAtelier;
    }
}