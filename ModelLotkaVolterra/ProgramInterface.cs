using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LotkaVolterra.Classes;
using SemiMarkovProcess;

namespace LotkaVolterra
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

        public List<ProcessMoment> GenerateSemiMarkovProcess(ulong finish)
        {
            var states = new List<IState>
                             {
                                 new State(0, null, 1),
                                 new State(1, null, -1)
                             };
            var process = new Process(states,null,null,ConditionOfEndProcess.Time, finish);
            return process.SimulateProcess();
        }

        private double PerturbParam(double coef, double a, double percent)
        {
            a = a + a*coef*percent;
            return a;

        }

        /// <summary>
        /// Handles the Click event of the button3 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void generatebtn_Click(object sender, EventArgs e)
        {
            LVSimulation lvSimulation = new MatLabLVSimulation();
            var start = Convert.ToDouble(txtboxStart.Text);
            var finish = Convert.ToUInt64(txtboxEnd.Text);

            var a = Convert.ToDouble(textBoxA.Text);
            var b = Convert.ToDouble(textBoxB.Text);
            var c = Convert.ToDouble(textBoxC.Text);
            var d = Convert.ToDouble(textBoxD.Text);

            var n0 = Convert.ToDouble(textBoxN.Text);
            var p0 = Convert.ToDouble(textBoxP.Text);

            var semiMarkovPoints = GenerateSemiMarkovProcess(finish);
            var list = new List<MLVPoint>();
            var sapList = new List<MLVPoint>();
            var alpha = Convert.ToDouble(txtAlpha.Text);
            var noPerturbedList = lvSimulation.Generate(start, finish, a, b, c, d, n0, p0);
            var noPerturbedsapList = lvSimulation.SAPProcess(start, finish, a, b, c, d, n0, p0, alpha);
            var perturbA = Convert.ToDouble(txtAx.Text);
            var perturbB = Convert.ToDouble(txtAx.Text);
            var perturbC = Convert.ToDouble(txtAx.Text);
            var perturbD = Convert.ToDouble(txtAx.Text);
            foreach (var semiMarkovPoint in semiMarkovPoints)
            {
                if (semiMarkovPoint.StartMoment == 0)
                {
                    semiMarkovPoint.StartMoment=0.001;
                }
                n0 = list.Count == 0 ? n0 : list[list.Count-1].NValue;
                p0 = list.Count == 0 ? p0 : list[list.Count-1].PValue;
                a = PerturbParam(semiMarkovPoint.StateValue, Convert.ToDouble(textBoxA.Text), perturbA);
                b = PerturbParam(semiMarkovPoint.StateValue, Convert.ToDouble(textBoxB.Text), perturbB);
                c = PerturbParam(semiMarkovPoint.StateValue, Convert.ToDouble(textBoxC.Text), perturbC);
                d = PerturbParam(semiMarkovPoint.StateValue, Convert.ToDouble(textBoxD.Text), perturbD);
                Console.WriteLine("{0};{1};{2};{3};{4};{5};{6};{7};{8}", semiMarkovPoint.StartMoment, semiMarkovPoint.EndMoment, a, b, c, d, n0, p0, alpha);
                var n01 = sapList.Count == 0 ? n0 : sapList[sapList.Count - 1].NValue;
                var p01 = sapList.Count == 0 ? p0 : sapList[sapList.Count - 1].PValue;
                sapList.AddRange(lvSimulation.SAPProcess(semiMarkovPoint.StartMoment, semiMarkovPoint.EndMoment, a, b, c, d, n01, p01, alpha));
                list.AddRange(lvSimulation.Generate(semiMarkovPoint.StartMoment, semiMarkovPoint.EndMoment, a, b, c, d, n0, p0));
            }
            
            // Creating table
            var table = new TableClass();
            table.CreateTable(list, dataGridView1);

            //Creating graphs
            var graphProcess = new GraphConsructingClass();
            graphProcess.DrawModel(zedGraph, list, noPerturbedList, "Модель Лотка Вольтерра");
            //graphProcess.DrawProcess(zedGraphProcess, semiMarkovPoints);
            graphProcess.DrawModel(zedGraphProcess, sapList, noPerturbedsapList, "Апроксимація");
        }
    }
        
}

