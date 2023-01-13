using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Patientenverwaltung.Gui;
using System.Windows.Forms;

namespace Patientenverwaltung
{
    internal class Program
    {
        
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Controller().startProgram());
        }
    }
}
