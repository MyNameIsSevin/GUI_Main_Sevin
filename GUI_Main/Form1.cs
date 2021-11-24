using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GUI_Main
{
    public partial class Form1 : Form,GUI_Main.IModel.IModel
    {
        List<Kunde> IModel.IModel.Kunden => throw new NotImplementedException();

        XDocument IModel.IModel.doc => throw new NotImplementedException();

        public Form1()
        {
            InitializeComponent();
        }

        XDocument doc { get; }

        private void Form1_Load(object sender, EventArgs e)
        {
            try { 
                // Create the list to use as the custom source. 
                var source = new AutoCompleteStringCollection();
                source.AddRange(new string[]
                                {
                        "January",
                        "February",
                        "March",
                        "April",
                        "May",
                        "June",
                        "July",
                        "August",
                        "September",
                        "October",
                        "November",
                        "December"
                                });

                // Create and initialize the text box.
                var textBox = new TextBox
                {
                    AutoCompleteCustomSource = source,
                    AutoCompleteMode =
                                      AutoCompleteMode.SuggestAppend,
                    AutoCompleteSource =
                                      AutoCompleteSource.CustomSource,
                    Location = new Point(20, 20),
                    Width = ClientRectangle.Width - 40,
                    Visible = true
                };

                // Add the text box to the form.
                   Controls.Add(textBox);
                }

            catch { 
            
            
            }
        }

        private void buttoneu_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(textKundennummer.Text) && String.IsNullOrEmpty(textName.Text) && String.IsNullOrEmpty(textVorname.Text)
               && String.IsNullOrEmpty(textStraße.Text) && String.IsNullOrEmpty(textHausnummer.Text) && String.IsNullOrEmpty(textPLZ.Text)
               && String.IsNullOrEmpty(textOrt.Text) && String.IsNullOrEmpty(textEmailadresse.Text))  
            {
                doc.Element("Kundenliste").Add(new XElement("Kunde",
                   new XElement("Kundennummer", textKundennummer.Text),
                   new XElement("Name", textName.Text),
                   new XElement("Vorname", textVorname.Text),
                   new XElement("Straße", textStraße.Text),
                   new XElement("Hausnummer", textHausnummer.Text),
                   new XElement("PLZ", textPLZ.Text),
                   new XElement("Ort", textOrt.Text),
                   new XElement("Emailadresse", textEmailadresse.Text),
                   new XElement("Passwort", textPasswort.Text)
                   ));

                MessageBox.Show("Successfully added a new member!");
            }
            else
            {
                MessageBox.Show("Please check your written informations for prescribes or mistakes, and click please |neu| again");
            }
        }

        private void buttonlöschen_Click(object sender, EventArgs e)
        {
            doc.Descendants("Kundenliste").Where(o => o.Attribute("Kundennummer").Value == "5 
            && o.Element("Kundenliste").Element("Name").Value == "DerBeispielname").remove();
        }

        private void buttonAendern_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textKundennummer.Text) && String.IsNullOrEmpty(textName.Text) && String.IsNullOrEmpty(textVorname.Text)
               && String.IsNullOrEmpty(textStraße.Text) && String.IsNullOrEmpty(textHausnummer.Text) && String.IsNullOrEmpty(textPLZ.Text)
               && String.IsNullOrEmpty(textOrt.Text) && String.IsNullOrEmpty(textEmailadresse.Text))
            {


                doc.Descendants("Kundenliste").Where(o => o.Attribute("Kundennummer").Value == "5 
                && o.Element("Kundenliste").Element("Name").Value ="DerTestName").First().Value=textName;
                MessageBox.Show("Successfully changed the data of a member!");
            }
            else
            {
                MessageBox.Show("Please check your written informations for prescribes or mistakes, and click the button 'Ändern' again.");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textPasswort_TextChanged(object sender, EventArgs e)
        {

        }

        void IModel.IModel.alter(Kunde kunde)
        {
            throw new NotImplementedException();
        }

        void IModel.IModel.delete(Kunde kunde)
        {
            throw new NotImplementedException();
        }

        void IModel.IModel.save(Kunde kunde)
        {
            throw new NotImplementedException();
        }

        Kunde IModel.IModel.getKunde(int kundennummer)
        {
            throw new NotImplementedException();
        }
    }
}