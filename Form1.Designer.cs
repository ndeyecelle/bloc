
namespace Projet_School
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
            this.nouveauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cRUDCLASSEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cRUDETUDIANTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eTUDIANTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLASSEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fermerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnimprimer = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.editionToolStripMenuItem,
            this.fermerToolStripMenuItem,
            this.toolStripTextBox1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 23);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // nouveauToolStripMenuItem
            // 
            this.nouveauToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cRUDCLASSEToolStripMenuItem,
            this.cRUDETUDIANTToolStripMenuItem});
            this.nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
            this.nouveauToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nouveauToolStripMenuItem.Text = "Nouveau";
            // 
            // cRUDCLASSEToolStripMenuItem
            // 
            this.cRUDCLASSEToolStripMenuItem.Name = "cRUDCLASSEToolStripMenuItem";
            this.cRUDCLASSEToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.cRUDCLASSEToolStripMenuItem.Text = "CRUD CLASSE";
            this.cRUDCLASSEToolStripMenuItem.Click += new System.EventHandler(this.cRUDCLASSEToolStripMenuItem_Click);
            // 
            // cRUDETUDIANTToolStripMenuItem
            // 
            this.cRUDETUDIANTToolStripMenuItem.Name = "cRUDETUDIANTToolStripMenuItem";
            this.cRUDETUDIANTToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.cRUDETUDIANTToolStripMenuItem.Text = "CRUD ETUDIANT";
            this.cRUDETUDIANTToolStripMenuItem.Click += new System.EventHandler(this.cRUDETUDIANTToolStripMenuItem_Click);
            // 
            // editionToolStripMenuItem
            // 
            this.editionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportToolStripMenuItem});
            this.editionToolStripMenuItem.Name = "editionToolStripMenuItem";
            this.editionToolStripMenuItem.Size = new System.Drawing.Size(56, 23);
            this.editionToolStripMenuItem.Text = "Edition";
            this.editionToolStripMenuItem.Click += new System.EventHandler(this.editionToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eTUDIANTToolStripMenuItem,
            this.cLASSEToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reportToolStripMenuItem.Text = "Report";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // eTUDIANTToolStripMenuItem
            // 
            this.eTUDIANTToolStripMenuItem.Name = "eTUDIANTToolStripMenuItem";
            this.eTUDIANTToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eTUDIANTToolStripMenuItem.Text = "ETUDIANT";
            this.eTUDIANTToolStripMenuItem.Click += new System.EventHandler(this.eTUDIANTToolStripMenuItem_Click);
            // 
            // cLASSEToolStripMenuItem
            // 
            this.cLASSEToolStripMenuItem.Name = "cLASSEToolStripMenuItem";
            this.cLASSEToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cLASSEToolStripMenuItem.Text = "CLASSE";
            this.cLASSEToolStripMenuItem.Click += new System.EventHandler(this.cLASSEToolStripMenuItem_Click);
            // 
            // fermerToolStripMenuItem
            // 
            this.fermerToolStripMenuItem.Name = "fermerToolStripMenuItem";
            this.fermerToolStripMenuItem.Size = new System.Drawing.Size(56, 23);
            this.fermerToolStripMenuItem.Text = "Fermer";
            this.fermerToolStripMenuItem.Click += new System.EventHandler(this.fermerToolStripMenuItem_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnimprimer
            // 
            this.btnimprimer.Location = new System.Drawing.Point(185, 1);
            this.btnimprimer.Name = "btnimprimer";
            this.btnimprimer.Size = new System.Drawing.Size(75, 23);
            this.btnimprimer.TabIndex = 3;
            this.btnimprimer.Text = "Imprimer";
            this.btnimprimer.UseVisualStyleBackColor = true;
            this.btnimprimer.Click += new System.EventHandler(this.btnimprimer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(800, 445);
            this.Controls.Add(this.btnimprimer);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cRUDETUDIANTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cRUDCLASSEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fermerToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eTUDIANTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLASSEToolStripMenuItem;
        private System.Windows.Forms.Button btnimprimer;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
    }
}

