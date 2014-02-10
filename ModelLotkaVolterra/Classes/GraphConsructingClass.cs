using System.Collections.Generic;
using System.Linq;
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
        /// <param name="points">The points of process.</param>
        public void DrawModel(ZedGraphControl zedGraph, List<MLVPoint> points)
        {
            GraphPane pane = zedGraph.GraphPane;
            pane.CurveList.Clear();
            PointPairList nList = new PointPairList();
            PointPairList pList = new PointPairList();

            //list.Add(Time[0], MatrixProcess[0].TimeState);
            foreach (var poissonPoint in points)
            {
                nList.Add(poissonPoint.TimePoint, poissonPoint.NValue);
                pList.Add(poissonPoint.TimePoint, poissonPoint.PValue);
            }

            // Створюємо ламану "переходи", 
            LineItem myCurve = pane.AddCurve("значення N", nList, Color.Blue, SymbolType.Circle);
            pane.AddCurve("значення P", pList, Color.Green, SymbolType.Circle);
            // Викликаємо метод AxisChange (), щоб обновити дані на осях осях. 
            zedGraph.AxisChange();
            // Обновляємо графік
            zedGraph.Invalidate();
            // !!!
            pane.XAxis.MajorGrid.IsVisible = true;
            pane.Title.Text = "Модель";
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
    }
}
