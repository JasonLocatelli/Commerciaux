namespace WF_Commerciaux
{
    partial class FrmvisualiserLesNotes
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
            this.Commerciaux = new System.Windows.Forms.GroupBox();
            this.lbCommerciaux = new System.Windows.Forms.ListBox();
            this.gbNotesFrais = new System.Windows.Forms.GroupBox();
            this.lbNotesFrais = new System.Windows.Forms.ListBox();
            this.btnFermer = new System.Windows.Forms.Button();
            this.Commerciaux.SuspendLayout();
            this.gbNotesFrais.SuspendLayout();
            this.SuspendLayout();
            // 
            // Commerciaux
            // 
            this.Commerciaux.Controls.Add(this.lbCommerciaux);
            this.Commerciaux.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Commerciaux.Location = new System.Drawing.Point(12, 12);
            this.Commerciaux.Name = "Commerciaux";
            this.Commerciaux.Size = new System.Drawing.Size(388, 103);
            this.Commerciaux.TabIndex = 1;
            this.Commerciaux.TabStop = false;
            this.Commerciaux.Text = "Commerciaux";
            // 
            // lbCommerciaux
            // 
            this.lbCommerciaux.FormattingEnabled = true;
            this.lbCommerciaux.Location = new System.Drawing.Point(18, 29);
            this.lbCommerciaux.Name = "lbCommerciaux";
            this.lbCommerciaux.Size = new System.Drawing.Size(322, 56);
            this.lbCommerciaux.TabIndex = 0;
            this.lbCommerciaux.SelectedIndexChanged += new System.EventHandler(this.lbCommerciaux_SelectedIndexChanged);
            // 
            // gbNotesFrais
            // 
            this.gbNotesFrais.Controls.Add(this.lbNotesFrais);
            this.gbNotesFrais.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gbNotesFrais.Location = new System.Drawing.Point(12, 131);
            this.gbNotesFrais.Name = "gbNotesFrais";
            this.gbNotesFrais.Size = new System.Drawing.Size(388, 208);
            this.gbNotesFrais.TabIndex = 2;
            this.gbNotesFrais.TabStop = false;
            this.gbNotesFrais.Text = "Notes de frais";
            // 
            // lbNotesFrais
            // 
            this.lbNotesFrais.FormattingEnabled = true;
            this.lbNotesFrais.HorizontalScrollbar = true;
            this.lbNotesFrais.Location = new System.Drawing.Point(18, 29);
            this.lbNotesFrais.Name = "lbNotesFrais";
            this.lbNotesFrais.Size = new System.Drawing.Size(322, 147);
            this.lbNotesFrais.TabIndex = 0;
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(325, 363);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 23);
            this.btnFermer.TabIndex = 11;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // FrmvisualiserLesNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 401);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.gbNotesFrais);
            this.Controls.Add(this.Commerciaux);
            this.MaximumSize = new System.Drawing.Size(452, 440);
            this.MinimumSize = new System.Drawing.Size(452, 440);
            this.Name = "FrmvisualiserLesNotes";
            this.Text = "Visualiser les notes de frais";
            this.Load += new System.EventHandler(this.FrmvisualiserLesNotes_Load);
            this.Commerciaux.ResumeLayout(false);
            this.gbNotesFrais.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Commerciaux;
        private System.Windows.Forms.ListBox lbCommerciaux;
        private System.Windows.Forms.GroupBox gbNotesFrais;
        private System.Windows.Forms.ListBox lbNotesFrais;
        private System.Windows.Forms.Button btnFermer;
    }
}