using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TestExperiment;
using System.Threading;

namespace Viewer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            TestExperiment.TestExperiment e = new TestExperiment.TestExperiment();
            e.setUpEnvironment();

            Viewer v = new Viewer();
            v.attachToExperiment(e);

            MainForm f = new MainForm(v);


            Application.Run(f);

            
        }
    }
}
