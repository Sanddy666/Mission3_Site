namespace Module_CLIRE
{
    partial class Form1
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
            this.Prenom = new System.Windows.Forms.Label();
            this.Nombres = new System.Windows.Forms.Label();
            this.Email_txt = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.Supprimer = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            this.Valider = new System.Windows.Forms.Button();
            this.Période = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.Nom = new System.Windows.Forms.Label();
            this.Nom_txt = new System.Windows.Forms.TextBox();
            this.Nbr_txt = new System.Windows.Forms.TextBox();
            this.Prenom_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Prenom
            // 
            this.Prenom.Location = new System.Drawing.Point(455, 93);
            this.Prenom.Name = "Prenom";
            this.Prenom.Size = new System.Drawing.Size(89, 35);
            this.Prenom.TabIndex = 2;
            this.Prenom.Text = "Prenom";
            // 
            // Nombres
            // 
            this.Nombres.Location = new System.Drawing.Point(101, 222);
            this.Nombres.Name = "Nombres";
            this.Nombres.Size = new System.Drawing.Size(134, 35);
            this.Nombres.TabIndex = 4;
            this.Nombres.Text = "Nombres de personnes";
            // 
            // Email_txt
            // 
            this.Email_txt.Location = new System.Drawing.Point(210, 157);
            this.Email_txt.Name = "Email_txt";
            this.Email_txt.Size = new System.Drawing.Size(117, 23);
            this.Email_txt.TabIndex = 7;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(101, 159);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(89, 35);
            this.Email.TabIndex = 6;
            this.Email.Text = "Email";
            // 
            // Supprimer
            // 
            this.Supprimer.Location = new System.Drawing.Point(750, 414);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(143, 69);
            this.Supprimer.TabIndex = 8;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = true;
            // 
            // Modifier
            // 
            this.Modifier.Location = new System.Drawing.Point(551, 414);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(141, 68);
            this.Modifier.TabIndex = 9;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = true;
            // 
            // Valider
            // 
            this.Valider.Location = new System.Drawing.Point(351, 414);
            this.Valider.Name = "Valider";
            this.Valider.Size = new System.Drawing.Size(139, 68);
            this.Valider.TabIndex = 10;
            this.Valider.Text = "Valider";
            this.Valider.UseVisualStyleBackColor = true;
            // 
            // Période
            // 
            this.Période.Location = new System.Drawing.Point(353, 262);
            this.Période.Name = "Période";
            this.Période.Size = new System.Drawing.Size(190, 31);
            this.Période.TabIndex = 11;
            this.Période.Text = "Periode d\'emplacement du ";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(656, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 33);
            this.label2.TabIndex = 12;
            this.label2.Text = "au";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(537, 258);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(112, 23);
            this.comboBox1.TabIndex = 15;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(696, 258);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(91, 23);
            this.comboBox2.TabIndex = 16;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // Nom
            // 
            this.Nom.Location = new System.Drawing.Point(104, 91);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(58, 27);
            this.Nom.TabIndex = 17;
            this.Nom.Text = "Nom";
            // 
            // Nom_txt
            // 
            this.Nom_txt.Location = new System.Drawing.Point(210, 91);
            this.Nom_txt.Name = "Nom_txt";
            this.Nom_txt.Size = new System.Drawing.Size(117, 23);
            this.Nom_txt.TabIndex = 18;
            // 
            // Nbr_txt
            // 
            this.Nbr_txt.Location = new System.Drawing.Point(283, 213);
            this.Nbr_txt.Name = "Nbr_txt";
            this.Nbr_txt.Size = new System.Drawing.Size(43, 23);
            this.Nbr_txt.TabIndex = 19;
            // 
            // Prenom_txt
            // 
            this.Prenom_txt.Location = new System.Drawing.Point(561, 88);
            this.Prenom_txt.Name = "Prenom_txt";
            this.Prenom_txt.Size = new System.Drawing.Size(105, 23);
            this.Prenom_txt.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.Prenom_txt);
            this.Controls.Add(this.Nbr_txt);
            this.Controls.Add(this.Nom_txt);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Période);
            this.Controls.Add(this.Valider);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.Supprimer);
            this.Controls.Add(this.Email_txt);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Nombres);
            this.Controls.Add(this.Prenom);
            this.Name = "Form1";
            this.Text = "Aloha Camping";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Valider;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.Button Supprimer;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Nombres;
        private System.Windows.Forms.Label Prenom;
        private System.Windows.Forms.Label Période;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label Nom;
        private System.Windows.Forms.TextBox Email_txt;
        private System.Windows.Forms.TextBox Nom_txt;
        private System.Windows.Forms.TextBox Prenom_txt;
        private System.Windows.Forms.TextBox Nbr_txt;
    }
}