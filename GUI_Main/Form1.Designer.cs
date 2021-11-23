
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
            this.textKundennummer = new System.Windows.Forms.TextBox();
            this.textStraße = new System.Windows.Forms.TextBox();
            this.textPLZ = new System.Windows.Forms.TextBox();
            this.textOrt = new System.Windows.Forms.TextBox();
            this.textHausnummer = new System.Windows.Forms.TextBox();
            this.textVorname = new System.Windows.Forms.TextBox();
            this.textEmailadresse = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttoneu
            // 
            this.buttoneu.Location = new System.Drawing.Point(13, 273);
            this.buttoneu.Name = "buttoneu";
            this.buttoneu.Size = new System.Drawing.Size(75, 23);
            this.buttoneu.TabIndex = 0;
            this.buttoneu.Text = "Neu";
            this.buttoneu.UseVisualStyleBackColor = true;
            this.buttoneu.Click += new System.EventHandler(this.buttoneu_Click);
            // 
            // buttonAendern
            // 
            this.buttonAendern.Location = new System.Drawing.Point(356, 273);
            this.buttonAendern.Name = "buttonAendern";
            this.buttonAendern.Size = new System.Drawing.Size(75, 23);
            this.buttonAendern.TabIndex = 1;
            this.buttonAendern.Text = "Ändern";
            this.buttonAendern.UseVisualStyleBackColor = true;
            this.buttonAendern.Click += new System.EventHandler(this.buttonAendern_Click);
            // 
            // buttonlöschen
            // 
            this.buttonlöschen.Location = new System.Drawing.Point(714, 273);
            this.buttonlöschen.Name = "buttonlöschen";
            this.buttonlöschen.Size = new System.Drawing.Size(75, 23);
            this.buttonlöschen.TabIndex = 2;
            this.buttonlöschen.Text = "Löschen";
            this.buttonlöschen.UseVisualStyleBackColor = true;
            this.buttonlöschen.Click += new System.EventHandler(this.buttonlöschen_Click);
            // 
            // labelKundennummer
            // 
            this.labelKundennummer.AutoSize = true;
            this.labelKundennummer.Location = new System.Drawing.Point(41, 33);
            this.labelKundennummer.Name = "labelKundennummer";
            this.labelKundennummer.Size = new System.Drawing.Size(108, 17);
            this.labelKundennummer.TabIndex = 4;
            this.labelKundennummer.Text = "Kundennummer";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(41, 80);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 17);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Name";
            // 
            // labelStrasse
            // 
            this.labelStrasse.AutoSize = true;
            this.labelStrasse.Location = new System.Drawing.Point(41, 125);
            this.labelStrasse.Name = "labelStrasse";
            this.labelStrasse.Size = new System.Drawing.Size(51, 17);
            this.labelStrasse.TabIndex = 6;
            this.labelStrasse.Text = "Straße";
            // 
            // labelPLZ
            // 
            this.labelPLZ.AutoSize = true;
            this.labelPLZ.Location = new System.Drawing.Point(41, 173);
            this.labelPLZ.Name = "labelPLZ";
            this.labelPLZ.Size = new System.Drawing.Size(34, 17);
            this.labelPLZ.TabIndex = 7;
            this.labelPLZ.Text = "PLZ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "E-Mailadresse";
            // 
            // labelVorname
            // 
            this.labelVorname.AutoSize = true;
            this.labelVorname.Location = new System.Drawing.Point(420, 80);
            this.labelVorname.Name = "labelVorname";
            this.labelVorname.Size = new System.Drawing.Size(65, 17);
            this.labelVorname.TabIndex = 9;
            this.labelVorname.Text = "Vorname";
            // 
            // labelHausnummer
            // 
            this.labelHausnummer.AutoSize = true;
            this.labelHausnummer.Location = new System.Drawing.Point(420, 125);
            this.labelHausnummer.Name = "labelHausnummer";
            this.labelHausnummer.Size = new System.Drawing.Size(92, 17);
            this.labelHausnummer.TabIndex = 10;
            this.labelHausnummer.Text = "Hausnummer";
            // 
            // labelOrt
            // 
            this.labelOrt.AutoSize = true;
            this.labelOrt.Location = new System.Drawing.Point(420, 173);
            this.labelOrt.Name = "labelOrt";
            this.labelOrt.Size = new System.Drawing.Size(28, 17);
            this.labelOrt.TabIndex = 11;
            this.labelOrt.Text = "Ort";
            // 
            // textKundennummer
            // 
            this.textKundennummer.Location = new System.Drawing.Point(173, 30);
            this.textKundennummer.Name = "textKundennummer";
            this.textKundennummer.Size = new System.Drawing.Size(152, 22);
            this.textKundennummer.TabIndex = 12;
            // 
            // textStraße
            // 
            this.textStraße.Location = new System.Drawing.Point(173, 122);
            this.textStraße.Name = "textStraße";
            this.textStraße.Size = new System.Drawing.Size(152, 22);
            this.textStraße.TabIndex = 13;
            // 
            // textPLZ
            // 
            this.textPLZ.Location = new System.Drawing.Point(173, 170);
            this.textPLZ.Name = "textPLZ";
            this.textPLZ.Size = new System.Drawing.Size(152, 22);
            this.textPLZ.TabIndex = 14;
            // 
            // textOrt
            // 
            this.textOrt.Location = new System.Drawing.Point(522, 170);
            this.textOrt.Name = "textOrt";
            this.textOrt.Size = new System.Drawing.Size(152, 22);
            this.textOrt.TabIndex = 16;
            // 
            // textHausnummer
            // 
            this.textHausnummer.Location = new System.Drawing.Point(586, 122);
            this.textHausnummer.Name = "textHausnummer";
            this.textHausnummer.Size = new System.Drawing.Size(88, 22);
            this.textHausnummer.TabIndex = 17;
            // 
            // textVorname
            // 
            this.textVorname.Location = new System.Drawing.Point(522, 77);
            this.textVorname.Name = "textVorname";
            this.textVorname.Size = new System.Drawing.Size(152, 22);
            this.textVorname.TabIndex = 18;
            // 
            // textEmailadresse
            // 
            this.textEmailadresse.Location = new System.Drawing.Point(173, 214);
            this.textEmailadresse.Name = "textEmailadresse";
            this.textEmailadresse.Size = new System.Drawing.Size(501, 22);
            this.textEmailadresse.TabIndex = 19;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(173, 77);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(152, 22);
            this.textName.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 308);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textEmailadresse);
            this.Controls.Add(this.textVorname);
            this.Controls.Add(this.textHausnummer);
            this.Controls.Add(this.textOrt);
            this.Controls.Add(this.textPLZ);
            this.Controls.Add(this.textStraße);
            this.Controls.Add(this.textKundennummer);
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
        private System.Windows.Forms.TextBox textKundennummer;
        private System.Windows.Forms.TextBox textStraße;
        private System.Windows.Forms.TextBox textPLZ;
        private System.Windows.Forms.TextBox textOrt;
        private System.Windows.Forms.TextBox textHausnummer;
        private System.Windows.Forms.TextBox textVorname;
        private System.Windows.Forms.TextBox textEmailadresse;
        private System.Windows.Forms.TextBox textName;
    }
}

