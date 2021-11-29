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

       // XDocument doc { set; }

        private void Form1_Load(object sender, EventArgs e)
        {
           
                // Create the list to use as the custom source. 
                var source = new AutoCompleteStringCollection();
                source.AddRange(new string[]
                                {
                    //Name (List)
                    //Nachname (List)
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
            doc.Descendants("Kundenliste").Where(o => o.Attribute("Kundennummer").Value = textKundennummer.Text
            && o.Element("Kundenliste").Element("Name").Value == textName.Text)
            && o.Element("Kundenliste").Element("Vorname").Value == textVorname.Text)
            && o.Element("Kundenliste").Element("Straße").Value == textStraße.Text)
            && o.Element("Kundenliste").Element("Hausnummer").Value == textHausnummer.Text)
            && o.Element("Kundenliste").Element("PLZ").Value == textPLZ.Text)
            && o.Element("Kundenliste").Element("Ort").Value == textOrt.Text)
            && o.Element("Kundenliste").Element("Emailadresse").Value == textEmailadresse.Text)
            && o.Element("Kundenliste").Element("Passwort").Value == textPasswort.te).remove();

        }

        private void buttonAendern_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textKundennummer.Text) && String.IsNullOrEmpty(textName.Text) && String.IsNullOrEmpty(textVorname.Text)
               && String.IsNullOrEmpty(textStraße.Text) && String.IsNullOrEmpty(textHausnummer.Text) && String.IsNullOrEmpty(textPLZ.Text)
               && String.IsNullOrEmpty(textOrt.Text) && String.IsNullOrEmpty(textEmailadresse.Text))
            {


                foreach (XElement el in doc.Descendants("Kunde").
                    Where(o => o.Attribute("Kundennummer").Value
                            == textKundennummer.Text))
                {
                    //el.Value = textName.Text;
                    el.Element("Vorname").Value = textVorname.Text;
                    /*
                    el.Element("Straße").Value = textStraße.Text.First().Value = textStraße.Text;
                    el.Element("Hausnummer").Value = textHausnummer.Text.First().Value = textHausnummer.Text;
                    el.Element("PLZ").Value = textPLZ.Text.First().Value = textPLZ.Text;
                    el.Element("Ort").Value = textOrt.Text.First().Value = textOrt.Text;
                    el.Element("Kundenliste").Element("Emailadresse").Value = textEmailadresse.Text.First().Value = textEmailadresse.Text;
                                el.Element("Kundenliste").Element("Passwort").Value = textPasswort.Text).First().Value = textPasswort.Text;
                    */ //
                }

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