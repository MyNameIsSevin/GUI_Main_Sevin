using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HHBK_Chemicals_ERP_CS.Model
{
    class Model:HHBK_Chemicals_ERP_CS.IModel.IModel
    {
        XDocument doc = XDocument.Load("KundenlisteXML.xml");

        List<Kunde> IModel.IModel.Kunden => throw new NotImplementedException();

        XDocument IModel.IModel.doc { get => doc; set => doc = value; }

        void IModel.IModel.alter(Kunde kunde)
        {
            throw new NotImplementedException();
        }

        void IModel.IModel.delete(Kunde kunde)
        {
            throw new NotImplementedException();
        }

        Kunde IModel.IModel.KundeGet(Kunde kunde)
        {
            throw new NotImplementedException();
        }

        void IModel.IModel.save(Kunde kunde)
        {
            throw new NotImplementedException();
        }
    }
}
