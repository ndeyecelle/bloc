namespace Projet_School
{
    partial class formreport
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
            this.pnlrecherche = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnImprimer = new System.Windows.Forms.Button();
            this.cpvViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.monrapport2 = new Projet_School.monrapport();
            this.monrapport1 = new Projet_School.monrapport();
            this.pnlrecherche.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlrecherche
            // 
            this.pnlrecherche.Controls.Add(this.comboBox1);
            this.pnlrecherche.Controls.Add(this.btnImprimer);
            this.pnlrecherche.Location = new System.Drawing.Point(1, 3);
            this.pnlrecherche.Name = "pnlrecherche";
            this.pnlrecherche.Size = new System.Drawing.Size(787, 52);
            this.pnlrecherche.TabIndex = 1;
            this.pnlrecherche.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlrecherche_Paint);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Listes des etudiants",
            "Listes des classes",
            "Programmes Etudiants-Classes",
            "Programmes Etudiants- Annee"});
            this.comboBox1.Location = new System.Drawing.Point(300, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // btnImprimer
            // 
            this.btnImprimer.Location = new System.Drawing.Point(513, 9);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.Size = new System.Drawing.Size(75, 23);
            this.btnImprimer.TabIndex = 0;
            this.btnImprimer.Text = "Imprimer";
            this.btnImprimer.UseVisualStyleBackColor = true;
            this.btnImprimer.Click += new System.EventHandler(this.btnrecherche_Click);
            // 
            // cpvViewer
            // 
            this.cpvViewer.ActiveViewIndex = 0;
            this.cpvViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpvViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.cpvViewer.Location = new System.Drawing.Point(1, 78);
            this.cpvViewer.Name = "cpvViewer";
            this.cpvViewer.ReportSource = this.monrapport2;
            this.cpvViewer.Size = new System.Drawing.Size(787, 377);
            this.cpvViewer.TabIndex = 0;
            this.cpvViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.ParameterPanel;
            this.cpvViewer.Load += new System.EventHandler(this.viwerscripteur_Load);
            // 
            // formreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlrecherche);
            this.Controls.Add(this.cpvViewer);
            this.Name = "formreport";
            this.Text = "formrapport";
            this.Load += new System.EventHandler(this.formrapport_Load);
            this.pnlrecherche.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlrecherche;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer cpvViewer;
        private monrapport monrapport1;
        private monrapport monrapport2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnImprimer;
    }
}