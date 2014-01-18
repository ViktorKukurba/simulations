using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using PoissonProcess.Classes;

namespace PoissonProcess
{
    /// <summary>
    /// Program Interface
    /// </summary>
    public partial class ProgramInterface : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProgramInterface"/> class.
        /// </summary>
        public ProgramInterface()
        {
            InitializeComponent();
       
        }

        /// <summary>
        /// Handles the Click event of the button3 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void generatebtn_Click(object sender, EventArgs e)
        {
            var poissonProcess = new Poisson(Convert.ToDouble(txtboxInterval.Text), Convert.ToInt32(txtboxDuration.Text), Convert.ToDouble(txtboxIntensity.Text));
            //List of process points
            List<PoissonPoint> events = poissonProcess.GenerateExpEvents();

            var poisson = poissonProcess.GeneratePoisson();
            
            // Creating table
            var table = new TableClass();
            table.CreateTable(poisson, dataGridView1);

            //Creating graphs
            GraphConsructingClass graphProcess = new GraphConsructingClass();
            graphProcess.DrawRandomEvents(zedGraph, events);
            graphProcess.DrawPoisson(zedGraphEvol, poisson);

            var average = poisson.Average(_ => _.Value);
            lblMS.Text = average.ToString(CultureInfo.InvariantCulture);
            lblDisp.Text = (poisson.Sum(_ => Math.Pow(_.Value - average, 2)) / poisson.Count).ToString(CultureInfo.InvariantCulture);

            graphProcess.DrawDistribution(zedGraphEmp, poisson);
        }
    }
        
}

