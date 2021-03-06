using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GUI_Main.IModel
{
    interface IModel
    {
        List<Kunde> Kunden { get; }
        void alter(Kunde kunde);
        void delete(Kunde kunde);
        void save(Kunde kunde);
        Kunde getKunde(int kundennummer);

        XDocument doc { get; set; }
    }    
    
}
