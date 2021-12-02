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
    public partial class Form1 : Form, GUI_Main.IModel.IModel
    {
        private readonly string _path;
        List<Kunde> IModel.IModel.Kunden => throw new NotImplementedException();
        public Form1()
        {
            _path = @"C:\Users\sevre\Source\Repos\MyNameIsSevin\GUI_Main_Sevin\GUI_Main\XML\KundenlisteXML.xml";
            InitializeComponent();
        }

        XDocument doc;
        XDocument IModel.IModel.doc { get => doc; set => doc = value; }

        // XDocument doc { get; }


        private void Form1_Load(object sender, EventArgs e)
        {
            doc = XDocument.Load(_path);
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
            //--
            textboxKundennummer.Text = "2";
            textboxName.Text = "Nagy";
            textboxVorname.Text = "asd";
            textboxStraße.Text = "asd2";
        }

        private void buttoneu_Click(object sender, EventArgs e) //Funct
        {
            if (String.IsNullOrEmpty(textboxKundennummer.Text) && String.IsNullOrEmpty(textboxName.Text) && String.IsNullOrEmpty(textboxVorname.Text)
               && String.IsNullOrEmpty(textboxStraße.Text) && String.IsNullOrEmpty(textboxHausnummer.Text) && String.IsNullOrEmpty(textboxPLZ.Text)
               && String.IsNullOrEmpty(textboxOrt.Text) && String.IsNullOrEmpty(textboxEmailadresse.Text))
            {
                MessageBox.Show("Please check your written informations for prescribes or mistakes, and click please |neu| again");
            }
            else
            {
                doc.Element("Kundenliste").Add(new XElement("Kunde",
                  new XElement("Kundennummer", textboxKundennummer.Text),
                  new XElement("name", textboxName.Text),
                  new XElement("vorname", textboxVorname.Text),
                  new XElement("straße", textboxStraße.Text),
                  new XElement("hausnummer", textboxHausnummer.Text),
                  new XElement("postleitzahl", textboxPLZ.Text),
                  new XElement("ort", textboxOrt.Text),
                  new XElement("email", textboxEmailadresse.Text),
                  new XElement("passwort", textboxPasswort.Text)
                  ));
                doc.Save(_path);
                MessageBox.Show("Successfully added a new member!");

            }
        }

        private void buttonlöschen_Click(object sender, EventArgs e) // funktioniert
        {
            if (String.IsNullOrEmpty(textboxKundennummer.Text) && String.IsNullOrEmpty(textboxName.Text) && String.IsNullOrEmpty(textboxVorname.Text)
                  && String.IsNullOrEmpty(textboxStraße.Text) && String.IsNullOrEmpty(textboxHausnummer.Text) && String.IsNullOrEmpty(textboxPLZ.Text)
                  && String.IsNullOrEmpty(textboxOrt.Text) && String.IsNullOrEmpty(textboxEmailadresse.Text))
            {
                MessageBox.Show("Please check your written informations for prescribes or mistakes, and click the button 'Löschen' again.");



                //foreach (XElement el in doc.Descendants("Kunden").Where(o => o.Attribute("Kundennummer").Value == textKundennummer.Text))
                //{
                //    el.Element("Name").Value = textName.Text.Remove(textName.Text);
                //    el.Element("Vorname").Value = textVorname.Text.Remove();
                //    el.Element("Straße").Value = textStraße.Text.Remove();
                //    el.Element("Hausnummer").Value = textHausnummer.Text.Remove();
                //    el.Element("PLZ").Value = textPLZ.Text.Remove();
                //    el.Element("Ort").Value = textOrt.Text.Remove();
                //    el.Element("Emailadresse").Value = textEmailadresse.Text.Remove();
                //    el.Element("Passwort").Value = textPasswort.Text.Remove();

                //    MessageBox.Show("Successfully removed an Member");
                //}
            }
            else
            {

                XDocument xdoc = doc;
                xdoc.Descendants("Kunde")
                    .Where(o => o.Element("Kundennummer").Value == textboxKundennummer.Text)
                    .Remove();
                xdoc.Save(_path);
            }
        }

        private void buttonAendern_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textboxKundennummer.Text) && String.IsNullOrEmpty(textboxName.Text) && String.IsNullOrEmpty(textboxVorname.Text)
               && String.IsNullOrEmpty(textboxStraße.Text) && String.IsNullOrEmpty(textboxHausnummer.Text) && String.IsNullOrEmpty(textboxPLZ.Text)
               && String.IsNullOrEmpty(textboxOrt.Text) && String.IsNullOrEmpty(textboxEmailadresse.Text))
            {

                MessageBox.Show("Please check your written informations for prescribes or mistakes, and click the button 'Ändern' again.");
            }
            else
            {
                if (doc.Descendants("Kunde").FirstOrDefault(k => k.Element("Kundennummer").Value == textboxKundennummer.Text) == null)
                {
                    return;
                };//.Element("vorname").Value = textVorname.Text;
                //doc.Save("testc.txt");


                foreach (XElement el in doc.Descendants("Kunde").
                    Where(o => o.Element("Kundennummer").Value
                            == textboxKundennummer.Text))
                {
                    el.Element("vorname").Value = textboxVorname.Text;
                    el.Element("name").Value = textboxName.Text;
                    el.Element("straße").Value = textboxStraße.Text;
                    el.Element("hausnummer").Value = textboxHausnummer.Text;
                    el.Element("postleitzahl").Value = textboxPLZ.Text;
                    el.Element("ort").Value = textboxOrt.Text;
                    el.Element("email").Value = textboxEmailadresse.Text;
                    el.Element("passwort").Value = textboxPasswort.Text;
                }

                //doc.Descendants("Kunde").Where(o => o.Element("Kundennummer").Value == textKundennummer.Text).ToList().ForEach(x =>
                //x.Element

                //);

                doc.Save(_path);

                MessageBox.Show("Successfully changed the data of a member!");

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

        private void textboxHausnummer_TextChanged(object sender, EventArgs e)
        {

        }
    }
}