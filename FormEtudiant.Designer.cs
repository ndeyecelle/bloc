
namespace Projet_School
{
    partial class FormEtudiant
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnrechclasse = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnrechannee = new System.Windows.Forms.Button();
            this.txtrechid = new System.Windows.Forms.TextBox();
            this.btnrechid = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dataetudiant = new System.Windows.Forms.DataGridView();
            this.btnsupprimer = new System.Windows.Forms.Button();
            this.btnannuler = new System.Windows.Forms.Button();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.btnetudiant = new System.Windows.Forms.Button();
            this.cmbclasse = new System.Windows.Forms.ComboBox();
            this.txtenneeescolaire = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtreglement = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcredit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtprenom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataetudiant)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.btnrechclasse);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btnrechannee);
            this.panel1.Controls.Add(this.txtrechid);
            this.panel1.Controls.Add(this.btnrechid);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.dataetudiant);
            this.panel1.Controls.Add(this.btnsupprimer);
            this.panel1.Controls.Add(this.btnannuler);
            this.panel1.Controls.Add(this.btnmodifier);
            this.panel1.Controls.Add(this.btnetudiant);
            this.panel1.Controls.Add(this.cmbclasse);
            this.panel1.Controls.Add(this.txtenneeescolaire);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtreglement);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtcredit);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtnom);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtprenom);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtid);
            this.panel1.Location = new System.Drawing.Point(96, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(692, 494);
            this.panel1.TabIndex = 26;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(227, 389);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(122, 28);
            this.textBox2.TabIndex = 47;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnrechclasse
            // 
            this.btnrechclasse.BackColor = System.Drawing.Color.LawnGreen;
            this.btnrechclasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrechclasse.Location = new System.Drawing.Point(227, 365);
            this.btnrechclasse.Name = "btnrechclasse";
            this.btnrechclasse.Size = new System.Drawing.Size(122, 23);
            this.btnrechclasse.TabIndex = 46;
            this.btnrechclasse.Text = "Recherche classe";
            this.btnrechclasse.UseVisualStyleBackColor = false;
            this.btnrechclasse.Click += new System.EventHandler(this.btnrechclasse_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(398, 389);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 28);
            this.textBox1.TabIndex = 45;
            // 
            // btnrechannee
            // 
            this.btnrechannee.BackColor = System.Drawing.Color.LawnGreen;
            this.btnrechannee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrechannee.Location = new System.Drawing.Point(398, 365);
            this.btnrechannee.Name = "btnrechannee";
            this.btnrechannee.Size = new System.Drawing.Size(163, 23);
            this.btnrechannee.TabIndex = 44;
            this.btnrechannee.Text = "Recherche annee";
            this.btnrechannee.UseVisualStyleBackColor = false;
            this.btnrechannee.Click += new System.EventHandler(this.btnrechetudiant_Click);
            // 
            // txtrechid
            // 
            this.txtrechid.Location = new System.Drawing.Point(548, 463);
            this.txtrechid.Multiline = true;
            this.txtrechid.Name = "txtrechid";
            this.txtrechid.Size = new System.Drawing.Size(141, 28);
            this.txtrechid.TabIndex = 43;
            // 
            // btnrechid
            // 
            this.btnrechid.BackColor = System.Drawing.Color.LawnGreen;
            this.btnrechid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrechid.Location = new System.Drawing.Point(548, 439);
            this.btnrechid.Name = "btnrechid";
            this.btnrechid.Size = new System.Drawing.Size(141, 23);
            this.btnrechid.TabIndex = 42;
            this.btnrechid.Text = "Recherche ID";
            this.btnrechid.UseVisualStyleBackColor = false;
            this.btnrechid.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(338, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 15);
            this.label9.TabIndex = 27;
            this.label9.Text = "AJOUT ETUDIANT";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // dataetudiant
            // 
            this.dataetudiant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataetudiant.Location = new System.Drawing.Point(227, 21);
            this.dataetudiant.Name = "dataetudiant";
            this.dataetudiant.Size = new System.Drawing.Size(334, 336);
            this.dataetudiant.TabIndex = 41;
            // 
            // btnsupprimer
            // 
            this.btnsupprimer.BackColor = System.Drawing.Color.LawnGreen;
            this.btnsupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsupprimer.Location = new System.Drawing.Point(408, 458);
            this.btnsupprimer.Name = "btnsupprimer";
            this.btnsupprimer.Size = new System.Drawing.Size(81, 28);
            this.btnsupprimer.TabIndex = 40;
            this.btnsupprimer.Text = "Supprimer";
            this.btnsupprimer.UseVisualStyleBackColor = false;
            this.btnsupprimer.Click += new System.EventHandler(this.btnsupprimer_Click);
            // 
            // btnannuler
            // 
            this.btnannuler.BackColor = System.Drawing.Color.LawnGreen;
            this.btnannuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnannuler.Location = new System.Drawing.Point(259, 458);
            this.btnannuler.Name = "btnannuler";
            this.btnannuler.Size = new System.Drawing.Size(81, 28);
            this.btnannuler.TabIndex = 39;
            this.btnannuler.Text = "Annuler";
            this.btnannuler.UseVisualStyleBackColor = false;
            this.btnannuler.Click += new System.EventHandler(this.btnannuler_Click);
            // 
            // btnmodifier
            // 
            this.btnmodifier.BackColor = System.Drawing.Color.LawnGreen;
            this.btnmodifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodifier.Location = new System.Drawing.Point(127, 458);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(81, 28);
            this.btnmodifier.TabIndex = 38;
            this.btnmodifier.Text = "Modifier";
            this.btnmodifier.UseVisualStyleBackColor = false;
            this.btnmodifier.Click += new System.EventHandler(this.btnmodifier_Click);
            // 
            // btnetudiant
            // 
            this.btnetudiant.BackColor = System.Drawing.Color.LawnGreen;
            this.btnetudiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnetudiant.Location = new System.Drawing.Point(3, 454);
            this.btnetudiant.Name = "btnetudiant";
            this.btnetudiant.Size = new System.Drawing.Size(81, 28);
            this.btnetudiant.TabIndex = 37;
            this.btnetudiant.Text = "Valider";
            this.btnetudiant.UseVisualStyleBackColor = false;
            this.btnetudiant.Click += new System.EventHandler(this.btnetudiant_Click);
            // 
            // cmbclasse
            // 
            this.cmbclasse.FormattingEnabled = true;
            this.cmbclasse.Items.AddRange(new object[] {
            "L1 IAGE",
            "L2 IAGE",
            "L3 IAGE",
            "L1 GENIE LOGICIEL",
            "L2 GENIE LOGICIEL",
            "L3 GENIE LOGICIEL",
            "L1 RI",
            "L2 RI",
            "L3 RI",
            "L1 COMPTABLITE",
            "L2 COMPTABLITE",
            "L3 COMPTABLITE"});
            this.cmbclasse.Location = new System.Drawing.Point(30, 336);
            this.cmbclasse.Name = "cmbclasse";
            this.cmbclasse.Size = new System.Drawing.Size(160, 21);
            this.cmbclasse.TabIndex = 36;
            this.cmbclasse.SelectedIndexChanged += new System.EventHandler(this.cmbclasse_SelectedIndexChanged);
            // 
            // txtenneeescolaire
            // 
            this.txtenneeescolaire.Location = new System.Drawing.Point(30, 290);
            this.txtenneeescolaire.Multiline = true;
            this.txtenneeescolaire.Name = "txtenneeescolaire";
            this.txtenneeescolaire.Size = new System.Drawing.Size(160, 23);
            this.txtenneeescolaire.TabIndex = 35;
            this.txtenneeescolaire.TextChanged += new System.EventHandler(this.txtenneeescolaire_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 15);
            this.label8.TabIndex = 34;
            this.label8.Text = "Annee Scolaire";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtreglement
            // 
            this.txtreglement.Location = new System.Drawing.Point(30, 234);
            this.txtreglement.Multiline = true;
            this.txtreglement.Name = "txtreglement";
            this.txtreglement.Size = new System.Drawing.Size(160, 23);
            this.txtreglement.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 15);
            this.label7.TabIndex = 32;
            this.label7.Text = "Reglement";
            // 
            // txtcredit
            // 
            this.txtcredit.Location = new System.Drawing.Point(30, 178);
            this.txtcredit.Multiline = true;
            this.txtcredit.Name = "txtcredit";
            this.txtcredit.Size = new System.Drawing.Size(160, 23);
            this.txtcredit.TabIndex = 31;
            this.txtcredit.TextChanged += new System.EventHandler(this.txtcredit_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 30;
            this.label6.Text = "Credit";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(30, 129);
            this.txtnom.Multiline = true;
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(160, 23);
            this.txtnom.TabIndex = 29;
            this.txtnom.TextChanged += new System.EventHandler(this.txtnom_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 28;
            this.label5.Text = "Nom";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtprenom
            // 
            this.txtprenom.Location = new System.Drawing.Point(30, 83);
            this.txtprenom.Multiline = true;
            this.txtprenom.Name = "txtprenom";
            this.txtprenom.Size = new System.Drawing.Size(160, 23);
            this.txtprenom.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 26;
            this.label4.Text = "Prenom";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(27, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 15);
            this.label10.TabIndex = 24;
            this.label10.Text = "ID";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(30, 36);
            this.txtid.Multiline = true;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(42, 17);
            this.txtid.TabIndex = 25;
            // 
            // FormEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.panel1);
            this.Name = "FormEtudiant";
            this.Text = "FormEtudiant";
            this.Load += new System.EventHandler(this.FormEtudiant_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataetudiant)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnsupprimer;
        private System.Windows.Forms.Button btnannuler;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.Button btnetudiant;
        private System.Windows.Forms.ComboBox cmbclasse;
        private System.Windows.Forms.TextBox txtenneeescolaire;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtreglement;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcredit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtprenom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataetudiant;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnrechid;
        private System.Windows.Forms.TextBox txtrechid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnrechclasse;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnrechannee;
    }
}