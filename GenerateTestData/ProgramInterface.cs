using System;
using System.Collections.Generic;
using System.Drawing;
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
            comboBoxDistribution.SelectedIndex = 1;
        }

        /// <summary>
        /// The _testProcess 
        /// </summary>
        private List<PoissonPoint> _testProcess;

        /// <summary>
        /// The _model data
        /// </summary>
        private TestModel _modelData;

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

            _testProcess = poissonProcess.GeneratePoisson();
            
            // Creating table
            var table = new TableClass();
            table.CreateTable(_testProcess, dataGridView1);

            //Creating graphs
            var graphProcess = new GraphConsructingClass();
            graphProcess.DrawRandomEvents(zedGraph, events);
            graphProcess.DrawPoisson(zedGraphEvol, _testProcess);

            var average = _testProcess.Average(_ => _.Value);
            lblMS.Text = average.ToString(CultureInfo.InvariantCulture);
            lblDisp.Text = (_testProcess.Sum(_ => Math.Pow(_.Value - average, 2)) / _testProcess.Count).ToString(CultureInfo.InvariantCulture);

            graphProcess.DrawDistribution(zedGraphEmp, _testProcess);
            btnModel.Visible = true;
        }

        private void Model_Click(object sender, EventArgs e)
        {
            InitModelState();
            try
            {
                var mathCad = new TestModelMathCad(
                    @"D:\Aspiranture\Dis_project\simulations\GenerateTestData\MathCad\testModel.xmcd");
                mathCad.SetValues("t", _testProcess.Skip(1).Select(_ => _.TimePoint*10).ToArray());
                mathCad.SetValues("mk", _testProcess.Skip(1).Select(_ => _.Value).ToArray());
                mathCad.SetValues("n", _testProcess.Skip(1).Count() - 1);
                mathCad.SetValues("x", Convert.ToInt32(txtAlpha.Text));
                mathCad.SetValues("y", Convert.ToDouble(txtBeta.Text));
                mathCad.SetValues("z", Convert.ToDouble(txtS.Text));
                try
                {
                    DisplayModelData(mathCad);
                    groupBoxSOP.Visible = true;
                }
                catch (Exception exp)
                {
                    HandleErrorState(exp.Message);
                }
            }catch(Exception exp)
            {
                HandleErrorState(exp.Message);
            }
        }

        private void HandleErrorState(string txt)
        {
            lblStatus.Text = txt;
            progressBar.Value = 0;
            progressBar.BackColor = Color.Red;
            lblStatus.ForeColor = Color.Red;
        }

        private void HandleSopError(string txt)
        {
            lblSOPStatus.Text = txt;
            progressBarSOP.Value = 0;
            progressBarSOP.BackColor = Color.Red;
            lblSOPStatus.ForeColor = Color.Red;
        }

        private void DisplayModelData(TestModelMathCad mathCad)
        {
            lblStatus.Text = "Розрахунок";
            progressBar.Value = 60;
            mathCad.Calculate();
            _modelData = mathCad.GetModelData();
            lblModelAlpha.Text = "alpha : " + _modelData.Alpha;
            lblModelBeta.Text = "beta : " + _modelData.Beta;
            lblModelS.Text = "s : " + _modelData.S;
            lblModelTotal.Text = "Total : " + _modelData.Total;
            progressBar.Value = 100;
            lblStatus.Text = "Отримано результати";
        }

        private void DisplaySOPData(SOPMathCad mathCad)
        {
            lblSOPStatus.Text = "Розрахунок";
            progressBarSOP.Value = 60;
            mathCad.Calculate();
            var sopData = mathCad.GetSOPData();
            lblSOPS.Text = "s : " + sopData.S;
            lblSOPTotal.Text = "Total : " + sopData.Total;
            progressBarSOP.Value = 100;
            lblStatus.ForeColor = Color.Green;
            lblSOPStatus.Text = "Отримано результати";
        }

        private void InitModelState()
        {
            progressBar.BackColor = Color.LightGray;
            lblStatus.ForeColor = Color.Green;
            progressBar.Value = 30;
            lblStatus.Text = "Ініціалізація";
            lblModelAlpha.Text = "alpha";
            lblModelBeta.Text = "beta";
            lblModelS.Text = "s";
            lblModelTotal.Text = "Total";
        }

        private void btnSOP_Click(object sender, EventArgs e)
        {
            try
            {
                var mathCad = new SOPMathCad(
                    @"D:\Aspiranture\Dis_project\simulations\GenerateTestData\MathCad\testModelSOP.xmcd");
                mathCad.SetValues("alpha", _modelData.Alpha);
                mathCad.SetValues("beta", _modelData.Beta);
                mathCad.SetValues("s", _modelData.S);
                mathCad.SetValues("a", Convert.ToInt32(txtSopA.Text));
                mathCad.SetValues("b", Convert.ToDouble(txtSopB.Text));
                try
                {
                    DisplaySOPData(mathCad);
                    groupBoxSOP.Visible = true;
                }
                catch (Exception exp)
                {
                    HandleSopError(exp.Message);
                }
            }
            catch (Exception exp)
            {
                HandleSopError(exp.Message);
            }
        }
    }
        
}

