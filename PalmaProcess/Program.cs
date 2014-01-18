using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ZedGraph;

namespace M2
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
            Application.Run(new ProcessModeling.Form1());
            //Application.Run(new M2.ModelingRandomValues());
            //Application.Run(new ExplorationTestResults.Form1());
            //ProcessModeling.Form1 F = new ProcessModeling.Form1();
            //ProcessModeling.Classes.StateClass SC = new ProcessModeling.Classes.StateClass();
            //SC.DistributionName = Convert.ToString(F.comboBoxRozpodilMinus);
        }

    }
}
