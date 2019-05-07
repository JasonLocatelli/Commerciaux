namespace WF_Commerciaux
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commercialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauCommercialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvelleNoteDeFraisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualiserLesNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.commercialToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirToolStripMenuItem,
            this.enregistrerToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // ouvrirToolStripMenuItem
            // 
            this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.ouvrirToolStripMenuItem.Text = "Ouvrir";
            this.ouvrirToolStripMenuItem.Click += new System.EventHandler(this.ouvrirToolStripMenuItem_Click);
            // 
            // enregistrerToolStripMenuItem
            // 
            this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.enregistrerToolStripMenuItem.Text = "Enregistrer";
            this.enregistrerToolStripMenuItem.Click += new System.EventHandler(this.enregistrerToolStripMenuItem_Click);
            // 
            // commercialToolStripMenuItem
            // 
            this.commercialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauCommercialToolStripMenuItem,
            this.nouvelleNoteDeFraisToolStripMenuItem,
            this.visualiserLesNotesToolStripMenuItem});
            this.commercialToolStripMenuItem.Name = "commercialToolStripMenuItem";
            this.commercialToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.commercialToolStripMenuItem.Text = "Commercial";
            // 
            // nouveauCommercialToolStripMenuItem
            // 
            this.nouveauCommercialToolStripMenuItem.Name = "nouveauCommercialToolStripMenuItem";
            this.nouveauCommercialToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.nouveauCommercialToolStripMenuItem.Text = "Nouveau commercial";
            this.nouveauCommercialToolStripMenuItem.Click += new System.EventHandler(this.nouveauCommercialToolStripMenuItem_Click);
            // 
            // nouvelleNoteDeFraisToolStripMenuItem
            // 
            this.nouvelleNoteDeFraisToolStripMenuItem.Name = "nouvelleNoteDeFraisToolStripMenuItem";
            this.nouvelleNoteDeFraisToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.nouvelleNoteDeFraisToolStripMenuItem.Text = "Nouvelle note de frais";
            this.nouvelleNoteDeFraisToolStripMenuItem.Click += new System.EventHandler(this.nouvelleNoteDeFraisToolStripMenuItem_Click);
            // 
            // visualiserLesNotesToolStripMenuItem
            // 
            this.visualiserLesNotesToolStripMenuItem.Name = "visualiserLesNotesToolStripMenuItem";
            this.visualiserLesNotesToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.visualiserLesNotesToolStripMenuItem.Text = "Visualiser les notes";
            this.visualiserLesNotesToolStripMenuItem.Click += new System.EventHandler(this.visualiserLesNotesToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Gestion des notes de frais";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commercialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauCommercialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouvelleNoteDeFraisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualiserLesNotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

