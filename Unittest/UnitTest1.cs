using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GUI_Main;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Collections;
using System.Reflection;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Unittest
{
    [TestClass]
    public class UnitTest1
    {
        #region helper
        string _path = @"C:\Users\sevre\Source\Repos\MyNameIsSevin\GUI_Main_Sevin\GUI_Main\XML\KundenlisteXML.xml";
        
        GUI_Main.IModel.IModel model;


        #endregion
        public UnitTest1()
        {
            model = new GUI_Main.Model.Model();

        }

        private List<Kunde> UnittestK(XDocument document)
        {

            List<Kunde> Tk = new List<Kunde>();


            IEnumerable<XElement> Kundenele = document.Descendants("Kunde");

            foreach (XElement item in Kundenele)
            {
                Tk.Add(new Kunde(int.Parse(item.Element("Kundennummer").Value), item.Element("name").Value, item.Element("vorname").Value, item.Element("straße").Value, item.Element("hausnummer").Value, item.Element("ort").Value, int.Parse(item.Element("postleitzahl").Value), item.Element("email").Value, item.Element("passwort").Value));
            }
            return Tk;
        }
        [TestMethod]
        public void Testalter()
        {

            Kunde myKunde = new Kunde(
                55, "Nameanonym", "Vornameanonym", "Straßeunbekannt", "HausnummerVerborgen", "Ortversteckt", 45353, "MEINEEMAILSISCHER@gmail.com", "MEINEPASSWORTSISCHER"
                );

            XDocument doc = XDocument.Load(_path);

            doc.Element("Kundenliste").Add(new XElement("Kunde",
                  new XElement("Kundennummer", myKunde.Kundennummer),
                  new XElement("name", myKunde.Name),
                  new XElement("vorname", myKunde.Vorname),
                  new XElement("straße", myKunde.Strasse),
                  new XElement("hausnummer", myKunde.Hausnummer),
                  new XElement("postleitzahl", myKunde.Postleitzahl),
                  new XElement("ort", myKunde.Ort),
                  new XElement("email", myKunde.Emailadresse),
                  new XElement("passwort", myKunde.Passwort)
                  ));

            doc.Save(_path);

            Kunde neueKunde = new Kunde(
                55, "Nameanonym1", "Vornameanonym1", "Straßeunbekannt1", "HausnummerVerborgen1", "Ortversteckt1", 453531, "MEINEEMAILSISCHER@gmail.com1", "MEINEPASSWORTSISCHER1"
                );

            //--

            XDocument docTestKundeEins = XDocument.Load(_path);
            List<Kunde> kundenTestKundeEins = UnittestK(docTestKundeEins);

            Kunde derzuänderndeKunde = neueKunde;// kundenTestKundeEins.FirstOrDefault(x => x.Kundennummer == 55);

            model.alter(derzuänderndeKunde);

            XDocument docTestKundeZwei = XDocument.Load(_path);
            List<Kunde> kundenTestKundeZwei = UnittestK(docTestKundeZwei);

            Assert.IsFalse(
                kundenTestKundeZwei.FirstOrDefault(Tk =>
                    Tk.Hausnummer == derzuänderndeKunde.Hausnummer &&
                    Tk.Name == derzuänderndeKunde.Name &&
                    Tk.Vorname == derzuänderndeKunde.Vorname &&
                    Tk.Strasse == derzuänderndeKunde.Strasse &&
                    Tk.Postleitzahl == derzuänderndeKunde.Postleitzahl &&
                    Tk.Ort == derzuänderndeKunde.Ort &&
                    Tk.Emailadresse == derzuänderndeKunde.Emailadresse
                ) == null
            );
        }
        [TestMethod]
        public void Testdelete()
        {

            XDocument doc = XDocument.Load(_path);

            XDocument docTestKundeEins = XDocument.Load(_path);
            List<Kunde> kundenTestKundeEins = UnittestK(docTestKundeEins);

            Kunde KundeZumLöschen = kundenTestKundeEins.First();
            model.delete(KundeZumLöschen);

            XDocument docTestKundeZwei = XDocument.Load(_path);
            List<Kunde> kundenTestKundeZwei = UnittestK(docTestKundeZwei);

            Assert.IsTrue(
                kundenTestKundeZwei.FirstOrDefault(Tk =>
                    Tk.Hausnummer == KundeZumLöschen.Hausnummer &&
                    Tk.Name == KundeZumLöschen.Name &&
                    Tk.Vorname == KundeZumLöschen.Vorname &&
                    Tk.Strasse == KundeZumLöschen.Strasse &&
                    Tk.Postleitzahl == KundeZumLöschen.Postleitzahl &&
                    Tk.Ort == KundeZumLöschen.Ort &&
                    Tk.Emailadresse == KundeZumLöschen.Emailadresse
                ) == null
            );

        }
        [TestMethod]
        public void Testsave()
        {
            XDocument doc = XDocument.Load(_path);

            Kunde neueKunde = new Kunde(
                55, "Nameanonym", "Vornameanonym", "Straßeunbekannt", "HausnummerVerborgen", "Ortversteckt", 45353, "MEINEEMAILSISCHER@gmail.com", "MEINEPASSWORTSISCHER"
                );
            model.save(neueKunde);

            XDocument docTestKundeEins = XDocument.Load(_path);
            List<Kunde> kundenTestKundeEins = UnittestK(docTestKundeEins);

            XDocument docTestKundeZwei = XDocument.Load(_path);
            List<Kunde> kundenTestKundeZwei = UnittestK(docTestKundeZwei);

            Assert.IsFalse(
                kundenTestKundeZwei.FirstOrDefault(Tk =>
                    Tk.Hausnummer == neueKunde.Hausnummer &&
                    Tk.Name == neueKunde.Name &&
                    Tk.Vorname == neueKunde.Vorname &&
                    Tk.Strasse == neueKunde.Strasse &&
                    Tk.Postleitzahl == neueKunde.Postleitzahl &&
                    Tk.Ort == neueKunde.Ort &&
                    Tk.Emailadresse == neueKunde.Emailadresse
                ) == null
            );
        }
        [TestMethod]
        public void Testgetkunde()
        {
            XDocument doc = XDocument.Load(_path);
            Assert.IsTrue(false);
        }
    }
}
