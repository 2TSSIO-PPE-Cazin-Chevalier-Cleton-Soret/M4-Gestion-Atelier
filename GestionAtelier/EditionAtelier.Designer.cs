namespace GestionAtelier
{
    partial class EditionAtelier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditionAtelier));
            this.listAtelier = new System.Windows.Forms.ListBox();
            this.dataGridViewListeEnfant = new System.Windows.Forms.DataGridView();
            this.Column0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Informations = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImprimer = new System.Windows.Forms.Button();
            this.PrintDocumentEditionAelier = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialogEditionAtelier = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListeEnfant)).BeginInit();
            this.SuspendLayout();
            // 
            // listAtelier
            // 
            this.listAtelier.FormattingEnabled = true;
            this.listAtelier.ItemHeight = 16;
            this.listAtelier.Location = new System.Drawing.Point(12, 12);
            this.listAtelier.Name = "listAtelier";
            this.listAtelier.Size = new System.Drawing.Size(330, 484);
            this.listAtelier.TabIndex = 7;
            this.listAtelier.SelectedIndexChanged += new System.EventHandler(this.listAtelier_SelectedIndexChanged);
            // 
            // dataGridViewListeEnfant
            // 
            this.dataGridViewListeEnfant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListeEnfant.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column0,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column7,
            this.Informations,
            this.Column4,
            this.Column5});
            this.dataGridViewListeEnfant.Location = new System.Drawing.Point(396, 12);
            this.dataGridViewListeEnfant.MultiSelect = false;
            this.dataGridViewListeEnfant.Name = "dataGridViewListeEnfant";
            this.dataGridViewListeEnfant.RowTemplate.Height = 24;
            this.dataGridViewListeEnfant.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListeEnfant.Size = new System.Drawing.Size(863, 484);
            this.dataGridViewListeEnfant.TabIndex = 8;
            // 
            // Column0
            // 
            this.Column0.Frozen = true;
            this.Column0.HeaderText = "Id";
            this.Column0.Name = "Column0";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Prénom";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nom";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Téléphone Parent";
            this.Column3.Name = "Column3";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Statut";
            this.Column7.Name = "Column7";
            // 
            // Informations
            // 
            this.Informations.HeaderText = "Informations";
            this.Informations.Name = "Informations";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Date d\'inscription";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Date de fin de l\'inscription";
            this.Column5.Name = "Column5";
            // 
            // btnImprimer
            // 
            this.btnImprimer.Location = new System.Drawing.Point(396, 502);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.Size = new System.Drawing.Size(863, 58);
            this.btnImprimer.TabIndex = 9;
            this.btnImprimer.Text = "Imprimer la liste";
            this.btnImprimer.UseVisualStyleBackColor = true;
            this.btnImprimer.Click += new System.EventHandler(this.btnImprimer_Click);
            // 
            // PrintDocumentEditionAelier
            // 
            this.PrintDocumentEditionAelier.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocumentEditionAelier_PrintPage);
            // 
            // printPreviewDialogEditionAtelier
            // 
            this.printPreviewDialogEditionAtelier.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogEditionAtelier.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogEditionAtelier.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogEditionAtelier.Document = this.PrintDocumentEditionAelier;
            this.printPreviewDialogEditionAtelier.Enabled = true;
            this.printPreviewDialogEditionAtelier.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogEditionAtelier.Icon")));
            this.printPreviewDialogEditionAtelier.Name = "printPreviewDialogEditionAtelier";
            this.printPreviewDialogEditionAtelier.Visible = false;
            // 
            // EditionAtelier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 572);
            this.Controls.Add(this.btnImprimer);
            this.Controls.Add(this.dataGridViewListeEnfant);
            this.Controls.Add(this.listAtelier);
            this.Name = "EditionAtelier";
            this.Text = "EditionAtelier";
            this.Load += new System.EventHandler(this.EditionAtelier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListeEnfant)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listAtelier;
        private System.Windows.Forms.DataGridView dataGridViewListeEnfant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column0;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Informations;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnImprimer;
        private System.Drawing.Printing.PrintDocument PrintDocumentEditionAelier;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogEditionAtelier;
    }
}