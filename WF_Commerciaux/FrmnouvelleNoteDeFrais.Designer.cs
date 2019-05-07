namespace WF_Commerciaux
{
    partial class FrmnouvelleNoteDeFrais
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbNuite = new System.Windows.Forms.RadioButton();
            this.rbRepas = new System.Windows.Forms.RadioButton();
            this.rbTransport = new System.Windows.Forms.RadioButton();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.Transport = new System.Windows.Forms.GroupBox();
            this.nupKmTransport = new System.Windows.Forms.NumericUpDown();
            this.km = new System.Windows.Forms.Label();
            this.Repas = new System.Windows.Forms.GroupBox();
            this.nupFactureRepas = new System.Windows.Forms.NumericUpDown();
            this.facture = new System.Windows.Forms.Label();
            this.Nuitee = new System.Windows.Forms.GroupBox();
            this.nupFactureNuitee = new System.Windows.Forms.NumericUpDown();
            this.rbZone3 = new System.Windows.Forms.RadioButton();
            this.rbZone2 = new System.Windows.Forms.RadioButton();
            this.rbZone1 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.Commerciaux.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Transport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupKmTransport)).BeginInit();
            this.Repas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupFactureRepas)).BeginInit();
            this.Nuitee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupFactureNuitee)).BeginInit();
            this.SuspendLayout();
            // 
            // Commerciaux
            // 
            this.Commerciaux.Controls.Add(this.lbCommerciaux);
            this.Commerciaux.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Commerciaux.Location = new System.Drawing.Point(55, 23);
            this.Commerciaux.Name = "Commerciaux";
            this.Commerciaux.Size = new System.Drawing.Size(388, 103);
            this.Commerciaux.TabIndex = 0;
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
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbNuite);
            this.groupBox2.Controls.Add(this.rbRepas);
            this.groupBox2.Controls.Add(this.rbTransport);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(55, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(388, 70);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Type de note";
            // 
            // rbNuite
            // 
            this.rbNuite.AutoSize = true;
            this.rbNuite.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rbNuite.Location = new System.Drawing.Point(277, 28);
            this.rbNuite.Name = "rbNuite";
            this.rbNuite.Size = new System.Drawing.Size(50, 17);
            this.rbNuite.TabIndex = 2;
            this.rbNuite.Text = "Nuité";
            this.rbNuite.UseVisualStyleBackColor = true;
            this.rbNuite.CheckedChanged += new System.EventHandler(this.rbNuite_CheckedChanged);
            // 
            // rbRepas
            // 
            this.rbRepas.AutoSize = true;
            this.rbRepas.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rbRepas.Location = new System.Drawing.Point(157, 28);
            this.rbRepas.Name = "rbRepas";
            this.rbRepas.Size = new System.Drawing.Size(56, 17);
            this.rbRepas.TabIndex = 1;
            this.rbRepas.Text = "Repas";
            this.rbRepas.UseVisualStyleBackColor = true;
            this.rbRepas.CheckedChanged += new System.EventHandler(this.rbRepas_CheckedChanged);
            // 
            // rbTransport
            // 
            this.rbTransport.AutoSize = true;
            this.rbTransport.Checked = true;
            this.rbTransport.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rbTransport.Location = new System.Drawing.Point(37, 28);
            this.rbTransport.Name = "rbTransport";
            this.rbTransport.Size = new System.Drawing.Size(70, 17);
            this.rbTransport.TabIndex = 0;
            this.rbTransport.TabStop = true;
            this.rbTransport.Text = "Transport\r\n";
            this.rbTransport.UseVisualStyleBackColor = true;
            this.rbTransport.CheckedChanged += new System.EventHandler(this.rbTransport_CheckedChanged);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(144, 147);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(238, 20);
            this.dateTimePicker.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Date";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(304, 572);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 4;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(400, 572);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 23);
            this.btnFermer.TabIndex = 5;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // Transport
            // 
            this.Transport.Controls.Add(this.nupKmTransport);
            this.Transport.Controls.Add(this.km);
            this.Transport.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Transport.Location = new System.Drawing.Point(58, 254);
            this.Transport.Name = "Transport";
            this.Transport.Size = new System.Drawing.Size(179, 80);
            this.Transport.TabIndex = 6;
            this.Transport.TabStop = false;
            this.Transport.Text = "Transport";
            // 
            // nupKmTransport
            // 
            this.nupKmTransport.Location = new System.Drawing.Point(48, 29);
            this.nupKmTransport.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.nupKmTransport.Name = "nupKmTransport";
            this.nupKmTransport.Size = new System.Drawing.Size(120, 20);
            this.nupKmTransport.TabIndex = 7;
            // 
            // km
            // 
            this.km.AutoSize = true;
            this.km.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.km.ForeColor = System.Drawing.SystemColors.Desktop;
            this.km.Location = new System.Drawing.Point(12, 31);
            this.km.Name = "km";
            this.km.Size = new System.Drawing.Size(24, 13);
            this.km.TabIndex = 4;
            this.km.Text = "Km";
            // 
            // Repas
            // 
            this.Repas.Controls.Add(this.nupFactureRepas);
            this.Repas.Controls.Add(this.facture);
            this.Repas.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Repas.Location = new System.Drawing.Point(58, 340);
            this.Repas.Name = "Repas";
            this.Repas.Size = new System.Drawing.Size(179, 90);
            this.Repas.TabIndex = 1;
            this.Repas.TabStop = false;
            this.Repas.Text = "Repas";
            this.Repas.Visible = false;
            // 
            // nupFactureRepas
            // 
            this.nupFactureRepas.Location = new System.Drawing.Point(68, 40);
            this.nupFactureRepas.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.nupFactureRepas.Name = "nupFactureRepas";
            this.nupFactureRepas.Size = new System.Drawing.Size(100, 20);
            this.nupFactureRepas.TabIndex = 8;
            // 
            // facture
            // 
            this.facture.AutoSize = true;
            this.facture.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facture.ForeColor = System.Drawing.SystemColors.Desktop;
            this.facture.Location = new System.Drawing.Point(12, 42);
            this.facture.Name = "facture";
            this.facture.Size = new System.Drawing.Size(50, 13);
            this.facture.TabIndex = 4;
            this.facture.Text = "Facture";
            // 
            // Nuitee
            // 
            this.Nuitee.Controls.Add(this.nupFactureNuitee);
            this.Nuitee.Controls.Add(this.rbZone3);
            this.Nuitee.Controls.Add(this.rbZone2);
            this.Nuitee.Controls.Add(this.rbZone1);
            this.Nuitee.Controls.Add(this.label4);
            this.Nuitee.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Nuitee.Location = new System.Drawing.Point(58, 445);
            this.Nuitee.Name = "Nuitee";
            this.Nuitee.Size = new System.Drawing.Size(179, 132);
            this.Nuitee.TabIndex = 1;
            this.Nuitee.TabStop = false;
            this.Nuitee.Text = "Nuitée";
            this.Nuitee.Visible = false;
            // 
            // nupFactureNuitee
            // 
            this.nupFactureNuitee.Location = new System.Drawing.Point(68, 42);
            this.nupFactureNuitee.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.nupFactureNuitee.Name = "nupFactureNuitee";
            this.nupFactureNuitee.Size = new System.Drawing.Size(100, 20);
            this.nupFactureNuitee.TabIndex = 9;
            // 
            // rbZone3
            // 
            this.rbZone3.AutoSize = true;
            this.rbZone3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rbZone3.Location = new System.Drawing.Point(15, 109);
            this.rbZone3.Name = "rbZone3";
            this.rbZone3.Size = new System.Drawing.Size(59, 17);
            this.rbZone3.TabIndex = 7;
            this.rbZone3.Text = "Zone 3";
            this.rbZone3.UseVisualStyleBackColor = true;
            // 
            // rbZone2
            // 
            this.rbZone2.AutoSize = true;
            this.rbZone2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rbZone2.Location = new System.Drawing.Point(15, 86);
            this.rbZone2.Name = "rbZone2";
            this.rbZone2.Size = new System.Drawing.Size(59, 17);
            this.rbZone2.TabIndex = 6;
            this.rbZone2.Text = "Zone 2";
            this.rbZone2.UseVisualStyleBackColor = true;
            // 
            // rbZone1
            // 
            this.rbZone1.AutoSize = true;
            this.rbZone1.Checked = true;
            this.rbZone1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rbZone1.Location = new System.Drawing.Point(15, 63);
            this.rbZone1.Name = "rbZone1";
            this.rbZone1.Size = new System.Drawing.Size(59, 17);
            this.rbZone1.TabIndex = 5;
            this.rbZone1.TabStop = true;
            this.rbZone1.Text = "Zone 1";
            this.rbZone1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(12, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Facture";
            // 
            // FrmnouvelleNoteDeFrais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 618);
            this.Controls.Add(this.Repas);
            this.Controls.Add(this.Nuitee);
            this.Controls.Add(this.Transport);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Commerciaux);
            this.MaximumSize = new System.Drawing.Size(529, 657);
            this.MinimumSize = new System.Drawing.Size(529, 657);
            this.Name = "FrmnouvelleNoteDeFrais";
            this.Text = "Ajouter une note";
            this.Load += new System.EventHandler(this.FrmnouvelleNoteDeFrais_Load);
            this.Commerciaux.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Transport.ResumeLayout(false);
            this.Transport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupKmTransport)).EndInit();
            this.Repas.ResumeLayout(false);
            this.Repas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupFactureRepas)).EndInit();
            this.Nuitee.ResumeLayout(false);
            this.Nuitee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupFactureNuitee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Commerciaux;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbCommerciaux;
        private System.Windows.Forms.RadioButton rbNuite;
        private System.Windows.Forms.RadioButton rbRepas;
        private System.Windows.Forms.RadioButton rbTransport;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.GroupBox Transport;
        private System.Windows.Forms.Label km;
        private System.Windows.Forms.GroupBox Repas;
        private System.Windows.Forms.Label facture;
        private System.Windows.Forms.GroupBox Nuitee;
        private System.Windows.Forms.RadioButton rbZone3;
        private System.Windows.Forms.RadioButton rbZone2;
        private System.Windows.Forms.RadioButton rbZone1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nupKmTransport;
        private System.Windows.Forms.NumericUpDown nupFactureRepas;
        private System.Windows.Forms.NumericUpDown nupFactureNuitee;
    }
}