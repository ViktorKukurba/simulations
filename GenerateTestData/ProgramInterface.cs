using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using GenerateTestData.Classes;

namespace GenerateTestData
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

            comboBoxDistribution.Items.Add("Рівномірний");
            comboBoxDistribution.Items.Add("Експоненційний");
            comboBoxDistribution.Items.Add("розподіл Вейбула");
            comboBoxDistribution.Items.Add("Нормальний розподіл");
            comboBoxDistribution.Items.Add("Логарифмічно нормальний");
            comboBoxDistribution.Items.Add("Ерланга");
            comboBoxDistribution.Items.Add("хі-квадрат");
            comboBoxDistribution.Items.Add("розподіл Релея");
            comboBoxDistribution.Items.Add("Стьюдента");
            comboBoxDistribution.Items.Add("Фішера");
            comboBoxDistribution.Items.Add("Бета-розподіл");
            comboBoxDistribution.SelectedIndex = 3;
       
        }

        /// <summary>
        /// Handles the Click event of the button3 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void generatebtn_Click(object sender, EventArgs e)
        {

            var poissonProcess = new Generator(Convert.ToDouble(txtboxInterval.Text), Convert.ToInt32(txtboxDuration.Text), Convert.ToDouble(txtboxIntensity.Text), comboBoxDistribution.SelectedItem.ToString());
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

