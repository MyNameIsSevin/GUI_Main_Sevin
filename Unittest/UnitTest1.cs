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
        
        string _path = @"C:\Users\sevre\Source\Repos\MyNameIsSevin\GUI_Main_Sevin\GUI_Main\XML\KundenlisteXML.xml";
        //GUI_Main.IModel.IModel myform;
        public UnitTest1()
        {
            myform = new GUI_Main.Form1();
        }
      

        [TestMethod]
        public void Testalter()
        {
            XDocument doc = XDocument.Load(_path);
           

        }
        [TestMethod]
        public void Testdelete()
        {
            XDocument doc = XDocument.Load(_path);



        }
        [TestMethod]
        public void Testsave()
        {
            XDocument doc = XDocument.Load(_path);





        /*

            textboxKundennummer = 4;
            textboxName = De_Santa;
            textboxVorname = Michael;
            textboxStraﬂe = Los_Santosstr;
            textboxHausnummer = 4;
            textboxPLZ = 42131;
            textboxOrt = Hood;
            textboxEmailadresse = MichaelFBI@gmai.com;
            textboxPasswort = MoneyMoney;


            doc.Element("Kundenliste").Add(new XElement("Kunde",
                  new XElement("Kundennummer", textboxKundennummer.Text),
                  new XElement("name", textboxName.Text),
                  new XElement("vorname", textboxVorname.Text),
                  new XElement("straﬂe", textboxStraﬂe.Text),
                  new XElement("hausnummer", textboxHausnummer.Text),
                  new XElement("postleitzahl", textboxPLZ.Text),
                  new XElement("ort", textboxOrt.Text),
                  new XElement("email", textboxEmailadresse.Text),
                  new XElement("passwort", textboxPasswort.Text)
                  ));


            */

        }
        [TestMethod]
        public void Testgetkunde()
        {
            XDocument doc = XDocument.Load(_path);



        }
    }
}
