
namespace GUI_Main
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttoneu = new System.Windows.Forms.Button();
            this.buttonAendern = new System.Windows.Forms.Button();
            this.buttonlöschen = new System.Windows.Forms.Button();
            this.labelKundennummer = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelStrasse = new System.Windows.Forms.Label();
            this.labelPLZ = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelVorname = new System.Windows.Forms.Label();
            this.labelHausnummer = new System.Windows.Forms.Label();
            this.labelOrt = new System.Windows.Forms.Label();
            this.textboxKundennummer = new System.Windows.Forms.TextBox();
            this.textboxStraße = new System.Windows.Forms.TextBox();
            this.textboxPLZ = new System.Windows.Forms.TextBox();
            this.textboxOrt = new System.Windows.Forms.TextBox();
            this.textboxHausnummer = new System.Windows.Forms.TextBox();
            this.textboxVorname = new System.Windows.Forms.TextBox();
            this.textboxEmailadresse = new System.Windows.Forms.TextBox();
            this.textboxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textboxPasswort = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttoneu
            // 
            this.buttoneu.Location = new System.Drawing.Point(10, 222);
            this.buttoneu.Margin = new System.Windows.Forms.Padding(2);
            this.buttoneu.Name = "buttoneu";
            this.buttoneu.Size = new System.Drawing.Size(56, 19);
            this.buttoneu.TabIndex = 0;
            this.buttoneu.Text = "Neu";
            this.buttoneu.UseVisualStyleBackColor = true;
            this.buttoneu.Click += new System.EventHandler(this.buttoneu_Click);
            // 
            // buttonAendern
            // 
            this.buttonAendern.Location = new System.Drawing.Point(267, 222);
            this.buttonAendern.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAendern.Name = "buttonAendern";
            this.buttonAendern.Size = new System.Drawing.Size(56, 19);
            this.buttonAendern.TabIndex = 1;
            this.buttonAendern.Text = "Ändern";
            this.buttonAendern.UseVisualStyleBackColor = true;
            this.buttonAendern.Click += new System.EventHandler(this.buttonAendern_Click);
            // 
            // buttonlöschen
            // 
            this.buttonlöschen.Location = new System.Drawing.Point(536, 222);
            this.buttonlöschen.Margin = new System.Windows.Forms.Padding(2);
            this.buttonlöschen.Name = "buttonlöschen";
            this.buttonlöschen.Size = new System.Drawing.Size(56, 19);
            this.buttonlöschen.TabIndex = 2;
            this.buttonlöschen.Text = "Löschen";
            this.buttonlöschen.UseVisualStyleBackColor = true;
            this.buttonlöschen.Click += new System.EventHandler(this.buttonlöschen_Click);
            // 
            // labelKundennummer
            // 
            this.labelKundennummer.AutoSize = true;
            this.labelKundennummer.Location = new System.Drawing.Point(31, 27);
            this.labelKundennummer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelKundennummer.Name = "labelKundennummer";
            this.labelKundennummer.Size = new System.Drawing.Size(81, 13);
            this.labelKundennummer.TabIndex = 4;
            this.labelKundennummer.Text = "Kundennummer";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(31, 65);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Name";
            // 
            // labelStrasse
            // 
            this.labelStrasse.AutoSize = true;
            this.labelStrasse.Location = new System.Drawing.Point(31, 102);
            this.labelStrasse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStrasse.Name = "labelStrasse";
            this.labelStrasse.Size = new System.Drawing.Size(38, 13);
            this.labelStrasse.TabIndex = 6;
            this.labelStrasse.Text = "Straße";
            // 
            // labelPLZ
            // 
            this.labelPLZ.AutoSize = true;
            this.labelPLZ.Location = new System.Drawing.Point(31, 141);
            this.labelPLZ.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPLZ.Name = "labelPLZ";
            this.labelPLZ.Size = new System.Drawing.Size(27, 13);
            this.labelPLZ.TabIndex = 7;
            this.labelPLZ.Text = "PLZ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 176);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "E-Mailadresse";
            // 
            // labelVorname
            // 
            this.labelVorname.AutoSize = true;
            this.labelVorname.Location = new System.Drawing.Point(315, 65);
            this.labelVorname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVorname.Name = "labelVorname";
            this.labelVorname.Size = new System.Drawing.Size(49, 13);
            this.labelVorname.TabIndex = 9;
            this.labelVorname.Text = "Vorname";
            // 
            // labelHausnummer
            // 
            this.labelHausnummer.AutoSize = true;
            this.labelHausnummer.Location = new System.Drawing.Point(315, 102);
            this.labelHausnummer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHausnummer.Name = "labelHausnummer";
            this.labelHausnummer.Size = new System.Drawing.Size(69, 13);
            this.labelHausnummer.TabIndex = 10;
            this.labelHausnummer.Text = "Hausnummer";
            // 
            // labelOrt
            // 
            this.labelOrt.AutoSize = true;
            this.labelOrt.Location = new System.Drawing.Point(315, 141);
            this.labelOrt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOrt.Name = "labelOrt";
            this.labelOrt.Size = new System.Drawing.Size(21, 13);
            this.labelOrt.TabIndex = 11;
            this.labelOrt.Text = "Ort";
            // 
            // textboxKundennummer
            // 
            this.textboxKundennummer.Location = new System.Drawing.Point(130, 24);
            this.textboxKundennummer.Margin = new System.Windows.Forms.Padding(2);
            this.textboxKundennummer.Name = "textboxKundennummer";
            this.textboxKundennummer.Size = new System.Drawing.Size(115, 20);
            this.textboxKundennummer.TabIndex = 12;
            // 
            // textboxStraße
            // 
            this.textboxStraße.Location = new System.Drawing.Point(130, 99);
            this.textboxStraße.Margin = new System.Windows.Forms.Padding(2);
            this.textboxStraße.Name = "textboxStraße";
            this.textboxStraße.Size = new System.Drawing.Size(115, 20);
            this.textboxStraße.TabIndex = 13;
            // 
            // textboxPLZ
            // 
            this.textboxPLZ.Location = new System.Drawing.Point(130, 138);
            this.textboxPLZ.Margin = new System.Windows.Forms.Padding(2);
            this.textboxPLZ.Name = "textboxPLZ";
            this.textboxPLZ.Size = new System.Drawing.Size(115, 20);
            this.textboxPLZ.TabIndex = 14;
            // 
            // textboxOrt
            // 
            this.textboxOrt.Location = new System.Drawing.Point(392, 138);
            this.textboxOrt.Margin = new System.Windows.Forms.Padding(2);
            this.textboxOrt.Name = "textboxOrt";
            this.textboxOrt.Size = new System.Drawing.Size(115, 20);
            this.textboxOrt.TabIndex = 16;
            // 
            // textboxHausnummer
            // 
            this.textboxHausnummer.Location = new System.Drawing.Point(440, 99);
            this.textboxHausnummer.Margin = new System.Windows.Forms.Padding(2);
            this.textboxHausnummer.Name = "textboxHausnummer";
            this.textboxHausnummer.Size = new System.Drawing.Size(67, 20);
            this.textboxHausnummer.TabIndex = 17;
            this.textboxHausnummer.TextChanged += new System.EventHandler(this.textboxHausnummer_TextChanged);
            // 
            // textboxVorname
            // 
            this.textboxVorname.Location = new System.Drawing.Point(392, 63);
            this.textboxVorname.Margin = new System.Windows.Forms.Padding(2);
            this.textboxVorname.Name = "textboxVorname";
            this.textboxVorname.Size = new System.Drawing.Size(115, 20);
            this.textboxVorname.TabIndex = 18;
            // 
            // textboxEmailadresse
            // 
            this.textboxEmailadresse.Location = new System.Drawing.Point(130, 174);
            this.textboxEmailadresse.Margin = new System.Windows.Forms.Padding(2);
            this.textboxEmailadresse.Name = "textboxEmailadresse";
            this.textboxEmailadresse.Size = new System.Drawing.Size(377, 20);
            this.textboxEmailadresse.TabIndex = 19;
            // 
            // textboxName
            // 
            this.textboxName.Location = new System.Drawing.Point(130, 63);
            this.textboxName.Margin = new System.Windows.Forms.Padding(2);
            this.textboxName.Name = "textboxName";
            this.textboxName.Size = new System.Drawing.Size(115, 20);
            this.textboxName.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Passwort";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textboxPasswort
            // 
            this.textboxPasswort.Location = new System.Drawing.Point(392, 24);
            this.textboxPasswort.Margin = new System.Windows.Forms.Padding(2);
            this.textboxPasswort.Name = "textboxPasswort";
            this.textboxPasswort.Size = new System.Drawing.Size(115, 20);
            this.textboxPasswort.TabIndex = 23;
            this.textboxPasswort.TextChanged += new System.EventHandler(this.textPasswort_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 250);
            this.Controls.Add(this.textboxPasswort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textboxName);
            this.Controls.Add(this.textboxEmailadresse);
            this.Controls.Add(this.textboxVorname);
            this.Controls.Add(this.textboxHausnummer);
            this.Controls.Add(this.textboxOrt);
            this.Controls.Add(this.textboxPLZ);
            this.Controls.Add(this.textboxStraße);
            this.Controls.Add(this.textboxKundennummer);
            this.Controls.Add(this.labelOrt);
            this.Controls.Add(this.labelHausnummer);
            this.Controls.Add(this.labelVorname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelPLZ);
            this.Controls.Add(this.labelStrasse);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelKundennummer);
            this.Controls.Add(this.buttonlöschen);
            this.Controls.Add(this.buttonAendern);
            this.Controls.Add(this.buttoneu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttoneu;
        private System.Windows.Forms.Button buttonAendern;
        private System.Windows.Forms.Button buttonlöschen;
        private System.Windows.Forms.Label labelKundennummer;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelStrasse;
        private System.Windows.Forms.Label labelPLZ;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelVorname;
        private System.Windows.Forms.Label labelHausnummer;
        private System.Windows.Forms.Label labelOrt;
        private System.Windows.Forms.TextBox textboxKundennummer;
        private System.Windows.Forms.TextBox textboxStraße;
        private System.Windows.Forms.TextBox textboxPLZ;
        private System.Windows.Forms.TextBox textboxOrt;
        private System.Windows.Forms.TextBox textboxHausnummer;
        private System.Windows.Forms.TextBox textboxVorname;
        private System.Windows.Forms.TextBox textboxEmailadresse;
        private System.Windows.Forms.TextBox textboxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textboxPasswort;
    }
}

