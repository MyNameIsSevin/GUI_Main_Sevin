using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Main.Schnittstellen
{
    interface IController
    {
        List<Kunde> Kunden { get; }
        GUI_Main.IModel.IModel model { set; }

        void alter(Kunde kunde);
        void delete(Kunde kunde);
        void save(Kunde kunde);
        Kunde getKunde(int kundennummer);
    }
}
