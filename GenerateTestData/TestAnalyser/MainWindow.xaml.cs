using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TestProductModel;
using System.IO;
using System.Xml.Serialization;
using Microsoft.Win32;

namespace TestAnalyser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            distributionsCombo.Items.Add("Експоненційний");
            distributionsCombo.Items.Add("Вейбула");
            distributionsCombo.Items.Add("Ерланга");
            distributionsCombo.SelectedIndex = 0;
            poissonChart.DataContext = new List<PoissonPoint> { new PoissonPoint() };
            eventsChart.DataContext = new List<PoissonPoint> { new PoissonPoint() };
            empireChart.DataContext = new List<PoissonPoint> { new PoissonPoint() };
            SOPBox.Visibility = Visibility.Collapsed;
            SOPResultBox.Visibility = Visibility.Collapsed;
            testModelResultBox.Visibility = Visibility.Collapsed;
        }

        /// <summary>
        /// The _testProcess 
        /// </summary>
        private List<PoissonPoint> _testProcess;

        private Generator _poissonGenerator;

        /// <summary>
        /// The _events 
        /// </summary>
        private List<PoissonPoint> _events;

        /// <summary>
        /// The _model data
        /// </summary>
        private TestModel _modelData;

        private void simulateTestProcessBtn_Click(object sender, RoutedEventArgs e)
        {
            var interval = Convert.ToDouble(txtInterval.Text);
            var duration = Convert.ToInt32(txtDuration.Text);
            var intensity = Convert.ToDouble(txtIntensity.Text);
            var distribution = distributionsCombo.SelectedItem.ToString();
            var paramA = Convert.ToDouble(txtDistributionA.Text);
            var paramB = Convert.ToDouble(txtDistributionB.Text);
            _poissonGenerator = new Generator(interval, duration, intensity, distribution, paramA, paramB);
            //List of process points
            _events = _poissonGenerator.GenerateExpEvents();
            _testProcess = _poissonGenerator.GeneratePoisson(null);
            DisplayTestData();
            InitModelState();
        }

        private void DisplayTestData()
        {
            eventsChart.DataContext = _events;
            empireChart.DataContext = GetEmpireDistribution(_testProcess);
            poissonChart.DataContext = _testProcess;
            processDataGrid.ItemsSource = _testProcess;

            var average = _testProcess.Average(_ => _.Value);
            averagelbl.Content = "Середнє значення: " + average.ToString();
            displbl.Content = "Дисперсія: " + (_testProcess.Sum(_ => Math.Pow(_.Value - average, 2)) / _testProcess.Count).ToString();
        }


        private List<PoissonPoint> GetEmpireDistribution(List<PoissonPoint> list)
        {
            var result = new List<PoissonPoint>();
            double value = 0;
            double sum = list.Sum(_ => _.Value);

            list.ForEach(_ => { _.EmpValue = _.SumValue / sum; });

            for (var index = 0; index < list.Count - 1; index++)
            {
                value += list[index].Value / sum;
                result.Add(new PoissonPoint { TimePoint = list[index].TimePoint, EmpValue = value });
                result.Add(new PoissonPoint { TimePoint = list[index + 1].TimePoint, EmpValue = value });
            }
            return list;
        }

        private void testModelBtn_Click(object sender, EventArgs e)
        {
            InitModelState();
            try
            {
                var mathCad = new TestModelMathCad(@"D:\Aspiranture\Dis_project\simulations\GenerateTestData\MathCad\testModel.xmcd");
                mathCad.SetValues("t", _testProcess.Skip(1).Select(_ => _.TimePoint).ToArray());
                mathCad.SetValues("mk", _testProcess.Skip(1).Select(_ => _.Value).ToArray());
                mathCad.SetValues("n", _testProcess.Skip(1).Count() - 1);
                mathCad.SetValues("x", Convert.ToInt32(txtAlpha.Text));
                mathCad.SetValues("y", Convert.ToDouble(txtBeta.Text));
                mathCad.SetValues("z", Convert.ToDouble(txtS.Text));
                try
                {
                    DisplayModelData(mathCad);
                    testModelResultBox.Visibility = Visibility.Visible;
                }
                catch (Exception exp)
                {
                    HandleModelError(exp.Message);
                }
            }catch(Exception exp)
            {
                HandleModelError(exp.Message);
            }
        }

        private void HandleModelError(string txt)
        {
            testModelStatuslbl.Content = "Статус помилка";
            testModelProgress.Value = 0;
            testModelProgress.Background = Brushes.Red;
            testModelStatuslbl.Foreground = Brushes.Red;
        }

        private void HandleSopError(string txt)
        {
            sopStatuslbl.Content = "Статус помилка";
            sopProgress.Value = 0;
            sopProgress.Background = Brushes.Red;
            sopStatuslbl.Foreground = Brushes.Red;
        }

        private void DisplayModelData(TestModelMathCad mathCad)
        {
            testModelStatuslbl.Content = "Розрахунок";
            testModelProgress.Value = 60;
            mathCad.Calculate();
            _modelData = mathCad.GetModelData();
            testModelAlphaResult.Content = "Alpha : " + _modelData.Alpha;
            testModelBetaResult.Content = "Beta : " + _modelData.Beta;
            testModelSResult.Content = "S : " + _modelData.S;
            testModelTotalResult.Content = "Total : " + _modelData.Total;
            testModelProgress.Value = 100;
            testModelStatuslbl.Content = "Статус розв'язано";
            testModelResultBox.Visibility = Visibility.Visible;
            SOPBox.Visibility = Visibility.Visible;
        }

        private void DisplaySOPData(SOPMathCad mathCad)
        {
            sopStatuslbl.Content = "Статус розрахунок";
            sopProgress.Value = 60;
            mathCad.Calculate();
            var sopData = mathCad.GetSOPData();
            SOPSlbl.Content = "S : " + sopData.S;
            SOPTotallbl.Content = "Total : " + sopData.Total;
            sopProgress.Value = 100;
            sopStatuslbl.Foreground = Brushes.Green;
            sopStatuslbl.Content = "Статус розв'язано";
        }

        private void InitModelState()
        {
            testModelProgress.Background = Brushes.LightGray;
            testModelStatuslbl.Foreground = Brushes.Green;
            testModelProgress.Value = 0;
            testModelStatuslbl.Content = "Статус не розв'язано";
            testModelResultBox.Visibility = Visibility.Collapsed;
            SOPResultBox.Visibility = Visibility.Collapsed;
            SOPBox.Visibility = Visibility.Collapsed;
        }

        private void SOPBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var mathCad = new SOPMathCad(@"D:\Aspiranture\Dis_project\simulations\GenerateTestData\MathCad\testModelSOP.xmcd");
                mathCad.SetValues("alpha", _modelData.Alpha);
                mathCad.SetValues("beta", _modelData.Beta);
                mathCad.SetValues("s", _modelData.S);
                mathCad.SetValues("a", Convert.ToInt32(txtSOPA.Text));
                mathCad.SetValues("b", Convert.ToDouble(txtSOPB.Text));
                try
                {
                    DisplaySOPData(mathCad);
                    SOPResultBox.Visibility = Visibility.Visible;
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

        private void testModelingSavebtn_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog()
            {
                Filter = "Text Files(*.txt)|*.txt|All(*.*)|*"
            };

            if (dialog.ShowDialog() == true)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<PoissonPoint>));
                using (var stream = File.Create(dialog.FileName))
                {
                    serializer.Serialize(stream, _events);
                }
            }
        }

        private void testModelingLoadbtn_Click(object sender, RoutedEventArgs e)
        {
            // Create an instance of the open file dialog box.
            OpenFileDialog openFileDialog = new OpenFileDialog();
            var interval = Convert.ToDouble(txtInterval.Text);
            var duration = Convert.ToInt32(txtDuration.Text);
            var intensity = Convert.ToDouble(txtIntensity.Text);
            var distribution = distributionsCombo.SelectedItem.ToString();
            var paramA = Convert.ToDouble(txtDistributionA.Text);
            var paramB = Convert.ToDouble(txtDistributionB.Text);
            _poissonGenerator = new Generator(interval, duration, intensity, distribution, paramA, paramB);
            // Set filter options and filter index.
            openFileDialog.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;

            // Process input if the user clicked OK.
            if (openFileDialog.ShowDialog() == true)
            {
                 // Read the first line from the file and write it the textbox.
                 XmlSerializer serializer = new XmlSerializer(typeof(List<PoissonPoint>));
                 //string temp = reader.ReadToEnd();
                 Stream reader = new FileStream(openFileDialog.FileName, FileMode.Open);
                 _events = (List<PoissonPoint>)serializer.Deserialize(reader);
                 _testProcess = _poissonGenerator.GeneratePoisson(_events);
                 DisplayTestData();
            }
        }
    }
}
