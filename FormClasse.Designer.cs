
namespace Projet_School
{
    partial class FormClasse
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnclasse = new System.Windows.Forms.Button();
            this.cmbspecialite = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataclasse = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbniveau = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataclasse)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.btnclasse);
            this.panel1.Controls.Add(this.cmbspecialite);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dataclasse);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbniveau);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(186, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 464);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnclasse
            // 
            this.btnclasse.BackColor = System.Drawing.Color.LawnGreen;
            this.btnclasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclasse.Location = new System.Drawing.Point(159, 178);
            this.btnclasse.Name = "btnclasse";
            this.btnclasse.Size = new System.Drawing.Size(108, 28);
            this.btnclasse.TabIndex = 17;
            this.btnclasse.Text = "Enregistrer";
            this.btnclasse.UseVisualStyleBackColor = false;
            this.btnclasse.Click += new System.EventHandler(this.btnclasse_Click);
            // 
            // cmbspecialite
            // 
            this.cmbspecialite.FormattingEnabled = true;
            this.cmbspecialite.Items.AddRange(new object[] {
            "GENIE LOGICIEL",
            "RESEAUX INFORMATIQUE",
            "INFORMATIQUE DE GESTION",
            "FINANCE COMPTABILITE"});
            this.cmbspecialite.Location = new System.Drawing.Point(139, 85);
            this.cmbspecialite.Name = "cmbspecialite";
            this.cmbspecialite.Size = new System.Drawing.Size(160, 21);
            this.cmbspecialite.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(161, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "AJOUT CLASSE";
            // 
            // dataclasse
            // 
            this.dataclasse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataclasse.Location = new System.Drawing.Point(15, 256);
            this.dataclasse.Name = "dataclasse";
            this.dataclasse.Size = new System.Drawing.Size(382, 190);
            this.dataclasse.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "SPECIALITE";
            // 
            // cmbniveau
            // 
            this.cmbniveau.FormattingEnabled = true;
            this.cmbniveau.Items.AddRange(new object[] {
            "L1",
            "L2",
            "L3",
            "M1",
            "M2"});
            this.cmbniveau.Location = new System.Drawing.Point(139, 141);
            this.cmbniveau.Name = "cmbniveau";
            this.cmbniveau.Size = new System.Drawing.Size(160, 21);
            this.cmbniveau.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "NIVEAU";
            // 
            // FormClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.panel1);
            this.Name = "FormClasse";
            this.Text = "FormClasse";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataclasse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnclasse;
        private System.Windows.Forms.ComboBox cmbspecialite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataclasse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbniveau;
        private System.Windows.Forms.Label label2;
    }
}