using System.Collections.Generic;
using System.Linq;
using TestProductModel;
using ZedGraph;
using System.Drawing;

namespace GenerateTestData.DataViz
{
    /// <summary>
    /// Graph Consructing
    /// </summary>
    class GraphConsructingClass
    {
        /// <summary>
        /// Draws the random events.
        /// </summary>
        /// <param name="zedGraph">The zed graph.</param>
        /// <param name="points">The points of process.</param>
        public void DrawRandomEvents(ZedGraphControl zedGraph, List<PoissonPoint> points)
        {
            GraphPane pane = zedGraph.GraphPane;
            pane.CurveList.Clear();
            PointPairList list = new PointPairList();

            //list.Add(Time[0], MatrixProcess[0].TimeState);
            foreach (var poissonPoint in points)
            {
                list.Add(poissonPoint.TimePoint, 0);
            }

            // Створюємо ламану "переходи", 
            LineItem myCurve = pane.AddCurve("події", list, Color.Blue, SymbolType.Circle);
            // Викликаємо метод AxisChange (), щоб обновити дані на осях осях. 
            zedGraph.AxisChange();
            // Обновляємо графік
            zedGraph.Invalidate();
            // !!!
            pane.XAxis.MajorGrid.IsVisible = true;
            pane.Title.Text = "Випадкові події";
            pane.XAxis.Title.Text = "Час";
            pane.XAxis.MajorGrid.DashOn = 10;
            pane.XAxis.MajorGrid.DashOff = 5;
            pane.YAxis.MajorGrid.IsVisible = true;
            pane.YAxis.MajorGrid.DashOn = 10;
            pane.YAxis.MajorGrid.IsZeroLine = false;
            pane.YAxis.MinorGrid.IsVisible = true;
            pane.YAxis.MinorGrid.DashOn = 1;
            pane.YAxis.MinorGrid.DashOff = 2;
            pane.XAxis.MinorGrid.IsVisible = true;
            pane.XAxis.MinorGrid.DashOn = 1;
            pane.XAxis.MinorGrid.DashOff = 2;
        }

        /// <summary>
        /// Draws the poisson.
        /// </summary>
        /// <param name="zedGraph">The zed graph.</param>
        /// <param name="points">The points of process.</param>
        public void DrawPoisson(ZedGraphControl zedGraph, List<PoissonPoint> points)
        {
            GraphPane pane = zedGraph.GraphPane;
            pane.XAxis.Title.Text = "Значення";
            pane.YAxis.Title.Text = "Індекс";
            pane.CurveList.Clear();
            PointPairList list = new PointPairList();
            // Заповнюємо список точок
            foreach (var poissonPoint in points)
            {
                list.Add(poissonPoint.TimePoint, poissonPoint.Value);
            }

            pane.Title.Text = "Пуассонівський процес";
            pane.AddCurve("процес", list, Color.Green, SymbolType.Circle);
            // Викликаємо метод AxisChange (), щоб обновити дані на осях осях. 
            zedGraph.AxisChange();
            // Обновляємо графік
            zedGraph.Invalidate();
            // !!!
            pane.XAxis.MajorGrid.IsVisible = true;
            pane.XAxis.MajorGrid.DashOn = 10;

            pane.XAxis.Title.Text = "Інтервал";
            pane.YAxis.Title.Text = "Значення";
            pane.XAxis.MajorGrid.DashOff = 5;
            pane.YAxis.MajorGrid.IsVisible = true;
            pane.YAxis.MajorGrid.DashOn = 10;
            pane.YAxis.MajorGrid.IsZeroLine = false;
            pane.YAxis.MinorGrid.IsVisible = true;
            pane.YAxis.MinorGrid.DashOn = 1;
            pane.YAxis.MinorGrid.DashOff = 2;
            pane.XAxis.MinorGrid.IsVisible = true;
            pane.XAxis.MinorGrid.DashOn = 1;
            pane.XAxis.MinorGrid.DashOff = 2;
        }
        /// <summary>
        /// Draws the distribution.
        /// </summary>
        /// <param name="zedGraph">The zed graph.</param>
        /// <param name="MatrixProcess">The matrix process.</param>
        public void DrawDistribution(ZedGraphControl zedGraph, List<PoissonPoint> points)
        {
            GraphPane pane = zedGraph.GraphPane;
            pane.XAxis.Title.Text = "Значення";
            pane.YAxis.Title.Text = "Індекс";
            PointPairList list = new PointPairList();
            pane.CurveList.Clear();
            double value = 0;
            double sum = points.Sum(_ => _.Value);
            for (var index = 0; index < points.Count - 1; index++)
            {
                value += points[index].Value / sum;
                list.Add(points[index].TimePoint, value);
                list.Add(points[index + 1].TimePoint, value);
                list.Add(PointPairBase.Missing, PointPairBase.Missing);
            }

            pane.AddCurve("емпірична функція розподілу", list, Color.Red, SymbolType.None);
            pane.Title.Text = "Пуассонівський процес";
            zedGraph.AxisChange();
            zedGraph.Invalidate();
            // !!!
            pane.XAxis.MajorGrid.IsVisible = true;
            pane.XAxis.MajorGrid.DashOn = 10;

            pane.XAxis.Title.Text = "Інтервал";
            pane.YAxis.Title.Text = "Значення";
            pane.XAxis.MajorGrid.DashOff = 5;
            pane.YAxis.MajorGrid.IsVisible = true;
            pane.YAxis.MajorGrid.DashOn = 10;
            pane.YAxis.MajorGrid.IsZeroLine = false;
            pane.YAxis.MinorGrid.IsVisible = true;
            pane.YAxis.MinorGrid.DashOn = 1;
            pane.YAxis.MinorGrid.DashOff = 2;
            pane.XAxis.MinorGrid.IsVisible = true;
            pane.XAxis.MinorGrid.DashOn = 1;
            pane.XAxis.MinorGrid.DashOff = 2;
            pane.XAxis.Scale.MinAuto = true;
            pane.XAxis.Scale.MaxAuto = true;
            pane.YAxis.Scale.MinAuto = true;
            pane.YAxis.Scale.MaxAuto = true;
        }
    }
}
