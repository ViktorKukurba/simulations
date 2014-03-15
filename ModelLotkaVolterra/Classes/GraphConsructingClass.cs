using System.Collections.Generic;
using System.Linq;
using SemiMarkovProcess;
using ZedGraph;
using System.Drawing;

namespace LotkaVolterra.Classes
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
        /// <param name="perturbedPoints"> </param>
        /// <param name="points">The points of process.</param>
        public void DrawModel(ZedGraphControl zedGraph, List<MLVPoint> perturbedPoints, List<MLVPoint> points)
        {
            var pane = zedGraph.GraphPane;
            pane.CurveList.Clear();
            var nList = new PointPairList();
            var pList = new PointPairList();

            var perturbedNList = new PointPairList();
            var perturbedPList = new PointPairList();

            foreach (var point in points)
            {
                nList.Add(point.TimePoint, point.NValue);
                pList.Add(point.TimePoint, point.PValue);
            }

            foreach (var perturbedPoint in perturbedPoints)
            {
                perturbedNList.Add(perturbedPoint.TimePoint, perturbedPoint.NValue);
                perturbedPList.Add(perturbedPoint.TimePoint, perturbedPoint.PValue);
            }

            // Створюємо ламану "переходи", 
            LineItem myCurve = pane.AddCurve("значення збуреного N", perturbedNList, Color.Blue, SymbolType.Circle);
            pane.AddCurve("значення N", nList, Color.LightBlue, SymbolType.Circle);
            pane.AddCurve("значення P", perturbedPList, Color.Green, SymbolType.Circle);
            pane.AddCurve("значення P", pList, Color.LightGreen, SymbolType.Circle);
            // Викликаємо метод AxisChange (), щоб обновити дані на осях осях. 
            zedGraph.AxisChange();
            // Обновляємо графік
            zedGraph.Invalidate();
            // !!!
            pane.XAxis.MajorGrid.IsVisible = true;
            pane.Title.Text = "Модель";
            pane.XAxis.Title.Text = "Час";
            pane.YAxis.Title.Text = "Значення";
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

        public void DrawProcess(ZedGraphControl zedGraph, List<ProcessMoment> points)
        {
            GraphPane pane = zedGraph.GraphPane;
            pane.CurveList.Clear();
            PointPairList list = new PointPairList();

            //list.Add(Time[0], MatrixProcess[0].TimeState);
            foreach (var poissonPoint in points)
            {
                list.Add(poissonPoint.StartMoment, poissonPoint.StateValue);
                list.Add(poissonPoint.EndMoment, poissonPoint.StateValue);
            }

            // Створюємо ламану "переходи", 
            LineItem myCurve = pane.AddCurve("значення N", list, Color.Green, SymbolType.Circle);
            // Викликаємо метод AxisChange (), щоб обновити дані на осях осях. 
            zedGraph.AxisChange();
            // Обновляємо графік
            zedGraph.Invalidate();
            // !!!
            pane.XAxis.MajorGrid.IsVisible = true;
            pane.Title.Text = "Процес";
            pane.XAxis.Title.Text = "Час";
            pane.YAxis.Title.Text = "Значення";
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
    }
}
