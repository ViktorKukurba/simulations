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

        private double PerturbParam(double coef, double a, double percent = 50)
        {
            a = a + coef*percent/100;
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

            var noPerturbedList = lvSimulation.Generate(start, finish, a, b, c, d, n0, p0);

            foreach (var semiMarkovPoint in semiMarkovPoints)
            {
                n0 = list.Count == 0 ? n0 : list[list.Count-1].NValue;
                p0 = list.Count == 0 ? p0 : list[list.Count-1].PValue;
                a = PerturbParam(semiMarkovPoint.StateValue, Convert.ToDouble(textBoxA.Text),10);
                b = PerturbParam(semiMarkovPoint.StateValue, Convert.ToDouble(textBoxB.Text),20);
                c = PerturbParam(semiMarkovPoint.StateValue, Convert.ToDouble(textBoxC.Text),-30);
                d = PerturbParam(semiMarkovPoint.StateValue, Convert.ToDouble(textBoxD.Text),-40);
                list.AddRange(lvSimulation.Generate(semiMarkovPoint.StartMoment, semiMarkovPoint.EndMoment, a, b, c, d, n0, p0));
            }
            
            // Creating table
            var table = new TableClass();
            table.CreateTable(list, dataGridView1);

            //Creating graphs
            var graphProcess = new GraphConsructingClass();
            graphProcess.DrawModel(zedGraph, list, noPerturbedList);
            graphProcess.DrawProcess(zedGraphProcess, semiMarkovPoints);
        }
    }
        
}

