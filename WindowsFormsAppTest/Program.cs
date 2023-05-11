using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppTest.repository;

namespace WindowsFormsAppTest
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.SetHighDpiMode(HighDpiMode.SystemAware);
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new VizualiozareExcursie());

            PlanificareRepository a=new PlanificareRepository();

            List<Palnificare> b=a.getAllPlanificari();

            foreach(Palnificare p in b)
            {
                Debug.WriteLine(p.descriere());
            }

        }
    }
}
