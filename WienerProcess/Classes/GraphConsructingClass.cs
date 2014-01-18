using System;
using System.Collections.Generic;
using System.Linq;
using M2.Classes;
using ZedGraph;
using System.Drawing;

namespace WiennerProcess.Classes
{
    /// <summary>
    /// Constructing Graph
    /// </summary>
    class GraphConsructingClass
    {
        /// <summary>
        /// Draws the process.
        /// </summary>
        /// <param name="zedGraph">The zed graph.</param>
        /// <param name="MatrixProcess">The matrix process.</param>
        /// <param name="func">The function.</param>
        /// <param name="title">The title.</param>
        public void DrawProcess(ZedGraphControl zedGraph, List<WienerPoint> MatrixProcess, Func<WienerPoint, WienerPoint> func, string title)
        {
            GraphPane pane = zedGraph.GraphPane;
            pane.CurveList.Clear();
            PointPairList list = new PointPairList();

            //list.Add(Time[0], MatrixProcess[0].TimeState);
            foreach (var poissonPoint in MatrixProcess)
            {
                var point = func(poissonPoint);
                list.Add(point.XValue, point.YValue);
            }
            
            // Створюємо ламану, 
            pane.AddCurve("Вінерівський процес", list, Color.Blue, SymbolType.Circle);

            
            // Викликаємо метод AxisChange (), щоб обновити дані на осях осях. 
            zedGraph.AxisChange();
            // Обновляємо графік
            zedGraph.Invalidate();
            pane.XAxis.MajorGrid.IsVisible = true;

            pane.Title.Text = title;

            if (title == "Поведінка точки")
            {
                var stick = new PointPairList {list[0], list.Last()};
                pane.XAxis.Title.Text = "X";
                pane.YAxis.Title.Text = "Y";
                var pointCurve = pane.AddCurve("Початкове і кінцеве значення", stick, Color.Red, SymbolType.Star);
                pointCurve.Line.IsVisible = false;
            }
            else
            {
                pane.XAxis.Title.Text = "Час";
                pane.YAxis.Title.Text = "Значення";
            }
            // Задаємо додаткові параметри для графіка
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
