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
        //string _path = @"C:\Users\KRIShark\Source\Repos\GUI_Main_Sevin\GUI_Main\XML\KundenlisteXML.xml";
        GUI_Main.IModel.IModel model;


        #endregion
        public UnitTest1()
        {
            model = new GUI_Main.Model.Model();

        }


        [TestMethod]
        public void Testalter()
        {
            XDocument doc = XDocument.Load(_path);
            Kunde neueKunde = new Kunde(
                100,
                "NameTest",
                "VornameTest",
                "StasseTest",
                "HausnummerTest",
                "OrtTest",
                1111,
                "EmailTest@e.com",
                ""
                );
            model.alter(neueKunde);

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

            Kunde neueKunde = new Kunde(
                100,
                "NameTest",
                "VornameTest",
                "StasseTest",
                "HausnummerTest",
                "OrtTest",
                1111,
                "EmailTest@e.com",
                "asd"
                );
            model.save(neueKunde);

            XDocument docAfter = XDocument.Load(_path);

            Assert.IsTrue(true);

        }
        [TestMethod]
        public void Testgetkunde()
        {
            XDocument doc = XDocument.Load(_path);
        }
    }
}
