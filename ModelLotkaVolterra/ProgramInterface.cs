using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using LotkaVolterra.Classes;
using MathWorks.MATLAB.NET.Arrays;

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

        /// <summary>
        /// Handles the Click event of the button3 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void generatebtn_Click(object sender, EventArgs e)
        {
            var lotka = new ModelLotkaVolterra.LotkaVolterra();
            var tspan = new double[] { Convert.ToDouble(txtboxStart.Text), Convert.ToDouble(txtboxEnd.Text) };
            var tspan1 = new double[] { Convert.ToDouble(textBoxN.Text), Convert.ToDouble(textBoxP.Text) };
            var mwtspan = new MWNumericArray(tspan);
            var mwtspan2 = new MWNumericArray(tspan1);
            var mwArrayOut = lotka.MLV(2, mwtspan, mwtspan2, Convert.ToDouble(textBoxA.Text),
                Convert.ToDouble(textBoxB.Text), Convert.ToDouble(textBoxC.Text), Convert.ToDouble(textBoxD.Text));
            var list = new List<MLVPoint>();
            var length = mwArrayOut[0].NumberOfElements;
            for (var i = 0; i < length; i++)
            {
                var psoPoint = new MLVPoint()
                {
                    TimePoint = ((double[])((MWNumericArray)mwArrayOut[0]).ToVector(MWArrayComponent.Real))[i],
                    NValue = ((double[])((MWNumericArray)mwArrayOut[1]).ToVector(MWArrayComponent.Real))[i],
                    PValue = ((double[])((MWNumericArray)mwArrayOut[1]).ToVector(MWArrayComponent.Real))[i + length]
                };
                list.Add(psoPoint);
            }
            
            // Creating table
            var table = new TableClass();
            table.CreateTable(list, dataGridView1);

            //Creating graphs
            var graphProcess = new GraphConsructingClass();
            graphProcess.DrawModel(zedGraph, list);
        }
    }
        
}

