using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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



        }
        [TestMethod]
        public void Testgetkunde()
        {
            XDocument doc = XDocument.Load(_path);



        }
    }
}
