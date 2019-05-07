namespace WF_Commerciaux
{
    partial class FmAjoutCommercial
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
            this.gbCategorie = new System.Windows.Forms.GroupBox();
            this.rbC = new System.Windows.Forms.RadioButton();
            this.rbB = new System.Windows.Forms.RadioButton();
            this.rbA = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PSV = new System.Windows.Forms.Label();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.nupPv = new System.Windows.Forms.NumericUpDown();
            this.gbCategorie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupPv)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCategorie
            // 
            this.gbCategorie.Controls.Add(this.rbC);
            this.gbCategorie.Controls.Add(this.rbB);
            this.gbCategorie.Controls.Add(this.rbA);
            this.gbCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCategorie.ForeColor = System.Drawing.SystemColors.Desktop;
            this.gbCategorie.Location = new System.Drawing.Point(26, 150);
            this.gbCategorie.Name = "gbCategorie";
            this.gbCategorie.Size = new System.Drawing.Size(115, 109);
            this.gbCategorie.TabIndex = 2;
            this.gbCategorie.TabStop = false;
            this.gbCategorie.Text = "Categorie";
            // 
            // rbC
            // 
            this.rbC.AutoSize = true;
            this.rbC.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rbC.Location = new System.Drawing.Point(28, 74);
            this.rbC.Name = "rbC";
            this.rbC.Size = new System.Drawing.Size(33, 17);
            this.rbC.TabIndex = 7;
            this.rbC.Text = "C";
            this.rbC.UseVisualStyleBackColor = true;
            // 
            // rbB
            // 
            this.rbB.AutoSize = true;
            this.rbB.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rbB.Location = new System.Drawing.Point(28, 51);
            this.rbB.Name = "rbB";
            this.rbB.Size = new System.Drawing.Size(33, 17);
            this.rbB.TabIndex = 6;
            this.rbB.Text = "B";
            this.rbB.UseVisualStyleBackColor = true;
            // 
            // rbA
            // 
            this.rbA.AutoSize = true;
            this.rbA.Checked = true;
            this.rbA.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rbA.Location = new System.Drawing.Point(28, 28);
            this.rbA.Name = "rbA";
            this.rbA.Size = new System.Drawing.Size(33, 17);
            this.rbA.TabIndex = 5;
            this.rbA.TabStop = true;
            this.rbA.Text = "A";
            this.rbA.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(23, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nom";
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(102, 22);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(122, 20);
            this.tbNom.TabIndex = 1;
            // 
            // tbPrenom
            // 
            this.tbPrenom.Location = new System.Drawing.Point(102, 57);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(122, 20);
            this.tbPrenom.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(23, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Prénom";
            // 
            // PSV
            // 
            this.PSV.AutoSize = true;
            this.PSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PSV.ForeColor = System.Drawing.SystemColors.Desktop;
            this.PSV.Location = new System.Drawing.Point(23, 109);
            this.PSV.Name = "PSV";
            this.PSV.Size = new System.Drawing.Size(117, 13);
            this.PSV.TabIndex = 8;
            this.PSV.Text = "Puissance véhicule";
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(194, 280);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 23);
            this.btnFermer.TabIndex = 10;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(98, 280);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 9;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // nupPv
            // 
            this.nupPv.Location = new System.Drawing.Point(147, 109);
            this.nupPv.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nupPv.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupPv.Name = "nupPv";
            this.nupPv.Size = new System.Drawing.Size(120, 20);
            this.nupPv.TabIndex = 11;
            this.nupPv.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FmAjoutCommercial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 319);
            this.Controls.Add(this.nupPv);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.PSV);
            this.Controls.Add(this.tbPrenom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbCategorie);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.label4);
            this.MaximumSize = new System.Drawing.Size(305, 358);
            this.MinimumSize = new System.Drawing.Size(305, 358);
            this.Name = "FmAjoutCommercial";
            this.Text = "Ajout d\'un commercial";
            this.gbCategorie.ResumeLayout(false);
            this.gbCategorie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupPv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCategorie;
        private System.Windows.Forms.RadioButton rbC;
        private System.Windows.Forms.RadioButton rbB;
        private System.Windows.Forms.RadioButton rbA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PSV;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.NumericUpDown nupPv;
    }
}