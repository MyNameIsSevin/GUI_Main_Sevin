using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("Unittest")]
namespace GUI_Main.Model
{
    class Model : GUI_Main.IModel.IModel
    {

        List<Kunde> IModel.IModel.Kunden => throw new NotImplementedException();

        XDocument IModel.IModel.doc { get => doc; set => doc = value; }

        string _path = @"C:\Users\sevre\Source\Repos\MyNameIsSevin\GUI_Main_Sevin\GUI_Main\XML\KundenlisteXML.xml";
        XDocument doc = XDocument.Load(@"C:\Users\sevre\Source\Repos\MyNameIsSevin\GUI_Main_Sevin\GUI_Main\XML\KundenlisteXML.xml");



        void IModel.IModel.alter(Kunde kunde)
        {
            doc = XDocument.Load(_path);
            if (doc.Descendants("Kunde").FirstOrDefault(k => k.Element("Kundennummer").Value == kunde.Kundennummer.ToString()) == null)
            {
                return;
            };


            foreach (XElement el in doc.Descendants("Kunde").
                Where(o => o.Element("Kundennummer").Value
                        == kunde.Kundennummer.ToString()))
            {
                el.Element("vorname").Value = kunde.Vorname;
                el.Element("name").Value = kunde.Name;
                el.Element("straße").Value = kunde.Strasse;
                el.Element("hausnummer").Value = kunde.Hausnummer;
                el.Element("postleitzahl").Value = kunde.Postleitzahl.ToString();
                el.Element("ort").Value = kunde.Ort;
                el.Element("email").Value = kunde.Emailadresse;
                el.Element("passwort").Value = kunde.Passwort;
            }

            doc.Save(_path);
        }

        void IModel.IModel.delete(Kunde kunde)
        {
            doc = XDocument.Load(_path);
            XDocument xdoc = doc;
            xdoc.Descendants("Kunde")
                .Where(o => o.Element("Kundennummer").Value == kunde.Kundennummer.ToString())
                .Remove();
            xdoc.Save(_path);
        }

        Kunde IModel.IModel.getKunde(int kundennummer)
        {
            throw new NotImplementedException();
        }

        void IModel.IModel.save(Kunde kunde)
        {
            doc = XDocument.Load(_path);
            doc.Element("Kundenliste").Add(new XElement("Kunde",
                  new XElement("Kundennummer", kunde.Kundennummer),
                  new XElement("name", kunde.Name),
                  new XElement("vorname", kunde.Vorname),
                  new XElement("straße", kunde.Strasse),
                  new XElement("hausnummer", kunde.Hausnummer),
                  new XElement("postleitzahl", kunde.Postleitzahl),
                  new XElement("ort", kunde.Ort),
                  new XElement("email", kunde.Emailadresse),
                  new XElement("passwort", kunde.Passwort)
                  ));
            doc.Save(_path);
        }
    }
}
