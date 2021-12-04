using GUI_Main.Schnittstellen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Main.Controller
{
    class Controller : GUI_Main.Schnittstellen.IController
    {
        private GUI_Main.IModel.IModel model1;
        public IModel.IModel model { set => model1 = value; }

        List<Kunde> IController.Kunden => throw new NotImplementedException();

        void IController.alter(Kunde kunde)
        {
            model1.alter(kunde);
        }

        void IController.delete(Kunde kunde)
        {
            model1.delete(kunde);
        }

        Kunde IController.getKunde(int kundennummer)
        {
            return model1.getKunde(kundennummer);
        }

        void IController.save(Kunde kunde)
        {
            model1.save(kunde);
        }
    }
}
