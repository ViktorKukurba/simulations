using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using WiennerProcess.Classes;

namespace WiennerProcess
{
    /// <summary>
    /// Creates Interface for program.
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
        /// Handles the Click event of the modeling button control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void modelbtn_Click(object sender, EventArgs e)
        {
            // Creates object that incapsulates logic for
            // generating Wiener process
            var wiener = new WienerModeling
                             {
                                 Radius = Convert.ToDouble(txtboxRadius.Text),
                                 Distance = Convert.ToInt32(txtboxDuration.Text)
                             };
            // Generates process
            // processList list of points that
            // describes behaviour of wiener process
            var processList = wiener.GenerateProcess();

            // Creates table that displays Wiener proces
            var table = new TableClass {colls = processList.Count};
            table.CreateTable(processList, dataGridView1);
            //Func methods describes logic for creating line charts
            Func<WienerPoint, WienerPoint> wienerDraw = (point) => point;
            Func<WienerPoint, WienerPoint> wienerXDraw = (point) => new WienerPoint() { YValue = point.XValue, XValue = point.Number };
            Func<WienerPoint, WienerPoint> wienerYDraw = (point) => new WienerPoint() { YValue = point.YValue, XValue = point.Number };

            // Creates object that incapsulates logic for creating charts
            var graphProcess = new GraphConsructingClass();
            //Draw charts
            graphProcess.DrawProcess(zedXGraph, processList, wienerXDraw, "Зміна по X");
            graphProcess.DrawProcess(zedYGraph, processList, wienerYDraw, "Зміна по Y");
            graphProcess.DrawProcess(zedWienerGraph, processList, wienerDraw, "Поведінка точки");

            var average = processList.Select(_ => _.Value).Average();
            lblMatSpod.Text = string.Format("x:{0}; y:{1}", Math.Round(processList.Average(_ => _.Value),5),
                                            Math.Round(processList.Average(_ => _.YValue),2)); 
                //average.ToString(CultureInfo.InvariantCulture);
            //var disp = processList.Sum(_ => (Math.Pow(_.Value - average, 2))) / processList.Count;
            var disp = string.Format("x:{0}; y:{1}", Math.Round(processList.Sum(_ => (Math.Pow(_.XValue - processList.Average(i => i.XValue), 2))) / processList.Count,2),
                                            Math.Round(processList.Sum(_ => (Math.Pow(_.YValue - processList.Average(i => i.YValue), 2))) / processList.Count,2)); 
            lblDisp.Text = disp;
            lblMax.Text = processList.Max(_ => _.Value).ToString(CultureInfo.InvariantCulture);
            lblMin.Text = processList.Skip(1).Min(_ => _.Value).ToString(CultureInfo.InvariantCulture);
        }
    }
        
}

