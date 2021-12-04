using System;
using System.Windows.Forms;

namespace GUI_Main
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            GUI_Main.Schnittstellen.IController controller = new GUI_Main.Controller.Controller();
            //GUI_Main.Schnittstellen.IKunde kunde = new GUI_Main.Kunde();
            GUI_Main.IModel.IModel model = new GUI_Main.Model.Model();
            GUI_Main.Schnittstellen.IView view = new Form1();

            //controller
            controller.model = model;


            //view
            view.IController1 = controller;


            Application.Run((Form1)view);
            //Application.Run(new Form1());
        }
    }
}
