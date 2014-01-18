using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZedGraph;
using System.Drawing;

namespace M2.Classes
{
    class GraphConsructingClass
    {
        public void DrawProcess(ZedGraphControl zedGraph, double[,] MatrixProcess, double[] Time)
        {
            GraphPane pane = zedGraph.GraphPane;
            pane.CurveList.Clear();
            PointPairList list = new PointPairList();
            list.Add(0, MatrixProcess[0, 0]);
           
            list.Add(Time[0], MatrixProcess[0, 0]);
            for (int i = 1; i < MatrixProcess.Length/2; i++)
            {
                list.Add(Time[i-1], MatrixProcess[i, 0]);
                list.Add(Time[i], MatrixProcess[i, 0]);
                
            }
            // Створюємо ламану "переходи", 
            LineItem myCurve = pane.AddCurve("переходи", list, Color.Red, SymbolType.Circle);
            // Викликаємо метод AxisChange (), щоб обновити дані на осях осях. 
            zedGraph.AxisChange();
            // Обновляємо графік
            zedGraph.Invalidate();
            // !!!
            // Включаем отображение сетки напротив крупных рисок по оси X
            pane.XAxis.MajorGrid.IsVisible = true;

            // Задаем вид пунктирной линии для крупных рисок по оси X:
            // Длина штрихов равна 10 пикселям, ... 
            pane.XAxis.MajorGrid.DashOn = 10;

            // затем 5 пикселей - пропуск
            pane.XAxis.MajorGrid.DashOff = 5;


            // Включаем отображение сетки напротив крупных рисок по оси Y
            pane.YAxis.MajorGrid.IsVisible = true;

            //Аналогично задаем вид пунктирной линии для крупных рисок по оси Y
            pane.YAxis.MajorGrid.DashOn = 10;
            //pane.YAxis.MajorGrid.DashOff = 5;
            // Горизонтальная линия на уровне y = 0 рисоваться не будет
            pane.YAxis.MajorGrid.IsZeroLine = false;

            // Включаем отображение сетки напротив мелких рисок по оси X
            pane.YAxis.MinorGrid.IsVisible = true;

            // Задаем вид пунктирной линии для крупных рисок по оси Y: 
            // Длина штрихов равна одному пикселю, ... 
            pane.YAxis.MinorGrid.DashOn = 1;

            // затем 2 пикселя - пропуск
            pane.YAxis.MinorGrid.DashOff = 2;

            // Включаем отображение сетки напротив мелких рисок по оси Y
            pane.XAxis.MinorGrid.IsVisible = true;

            // Аналогично задаем вид пунктирной линии для крупных рисок по оси Y
            pane.XAxis.MinorGrid.DashOn = 1;
            pane.XAxis.MinorGrid.DashOff = 2;
        }
        public void DrawSOProcedure(ZedGraphControl zedGraph, double[,] MatrixProcess)
        {
            // Получим панель для рисования
            GraphPane pane = zedGraph.GraphPane;
            //pane.Title.Text ="Стан +1 "+ comboBoxRozpodilPlus.SelectedItem.ToString();
            pane.XAxis.Title.Text = "Значення";
            pane.YAxis.Title.Text = "Індекс";

            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            pane.CurveList.Clear();

            // Создадим список точек
            PointPairList list1 = new PointPairList();
            for (int i = 0; i < MatrixProcess.Length / 2; i++)
            {
                list1.Add(MatrixProcess[i, 1], MatrixProcess[i, 0]);
            }


            // !!!
            // Создадим кривую с названием "Scatter".
            // Обводка ромбиков будут рисоваться голубым цветом (Color.Blue),
            // Опорные точки - ромбики (SymbolType.Diamond)
            LineItem myCurve = pane.AddCurve("Scatter", list1, Color.DarkGreen, SymbolType.Diamond);
            // !!!
            // У кривой линия будет невидимой
            myCurve.Line.IsVisible = false;
            myCurve.Symbol.Fill.Color = Color.Blue;
            myCurve.Symbol.Fill.Type = FillType.Solid;
            myCurve.Symbol.Size = 5;


            // Устанавливаем интересующий нас интервал по оси X
            pane.XAxis.Scale.Min = 0;
            pane.XAxis.Scale.Max = 1000;

            // Устанавливаем интересующий нас интервал по оси Y
            pane.YAxis.Scale.Min = 0;
            pane.YAxis.Scale.Max = 10;

            // Вызываем метод AxisChange (), чтобы обновить данные об осях. 
            // В противном случае на рисунке будет показана только часть графика, 
            // которая умещается в интервалы по осям, установленные по умолчанию
            zedGraph.AxisChange();

            // Обновляем график
            zedGraph.Invalidate();
        }
        public void DrawStateDistribution(ZedGraphControl zedGraph, double[,] MatrixProcess)
        {
        // Получим панель для рисования
            GraphPane pane = zedGraph.GraphPane;
            //pane.Title.Text ="Стан +1 "+ comboBoxRozpodilPlus.SelectedItem.ToString();
            pane.XAxis.Title.Text = "Значення";
            pane.YAxis.Title.Text = "Індекс";

            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            pane.CurveList.Clear();

            // Создадим список точек
            PointPairList list1 = new PointPairList();
            for (int i = 0; i < MatrixProcess.Length/2; i++)
                {
                    list1.Add(i, MatrixProcess[i, 1]);
                }
            

            // !!!
            // Создадим кривую с названием "Scatter".
            // Обводка ромбиков будут рисоваться голубым цветом (Color.Blue),
            // Опорные точки - ромбики (SymbolType.Diamond)
            LineItem myCurve = pane.AddCurve("Scatter", list1, Color.DarkGreen, SymbolType.Diamond);
            // !!!
            // У кривой линия будет невидимой
            myCurve.Line.IsVisible = false;
            myCurve.Symbol.Fill.Color = Color.Blue;
            myCurve.Symbol.Fill.Type = FillType.Solid;
            myCurve.Symbol.Size = 5;


            // Устанавливаем интересующий нас интервал по оси X
            pane.XAxis.Scale.Min = 0;
            pane.XAxis.Scale.Max = 1000;

            // Устанавливаем интересующий нас интервал по оси Y
            pane.YAxis.Scale.Min = 0;
            pane.YAxis.Scale.Max = 10;

            // Вызываем метод AxisChange (), чтобы обновить данные об осях. 
            // В противном случае на рисунке будет показана только часть графика, 
            // которая умещается в интервалы по осям, установленные по умолчанию
            zedGraph.AxisChange();

            // Обновляем график
            zedGraph.Invalidate();
}
        public void DrawEvolution(ZedGraphControl zedGraph, double[,] MatrixProcess)
        {
            double[] Time = ProcessModeling.Classes.ProcessClass.Accumulation(MatrixProcess);
            int[] PoslidStaniv = ProcessModeling.Classes.ProcessClass.SequenceOfStates(MatrixProcess);
            // Получим панель для рисования
            GraphPane pane = zedGraph.GraphPane;
            //pane.Title.Text ="Стан +1 "+ comboBoxRozpodilPlus.SelectedItem.ToString();
            pane.XAxis.Title.Text = "Значення";
            pane.YAxis.Title.Text = "Індекс";

            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            pane.CurveList.Clear();

            // Создадим список точек
            PointPairList list = new PointPairList();
            // Заповнюємо список точок
            list.Add(0, SOPClass.Function(0, 0));
            list.Add(Time[0],SOPClass.Function(Time[0], 0));
            for (int i = 0; i < MatrixProcess.Length/2-1; i++)
            {

                list.Add(Time[i], SOPClass.Function(Time[i], PoslidStaniv[i + 1]));
                list.Add(Time[i + 1], SOPClass.Function(Time[i + 1], PoslidStaniv[i + 1]));

            }
            // Створюємо ламану "переходи", 
            LineItem myCurve = pane.AddCurve("переходи", list, Color.Red, SymbolType.Circle);
            // Викликаємо метод AxisChange (), щоб обновити дані на осях осях. 
            zedGraph.AxisChange();
            // Обновляємо графік
            zedGraph.Invalidate();
            // !!!
            // Включаем отображение сетки напротив крупных рисок по оси X
            pane.XAxis.MajorGrid.IsVisible = true;

            // Задаем вид пунктирной линии для крупных рисок по оси X:
            // Длина штрихов равна 10 пикселям, ... 
            pane.XAxis.MajorGrid.DashOn = 10;

            // затем 5 пикселей - пропуск
            pane.XAxis.MajorGrid.DashOff = 5;


            // Включаем отображение сетки напротив крупных рисок по оси Y
            pane.YAxis.MajorGrid.IsVisible = true;

            //Аналогично задаем вид пунктирной линии для крупных рисок по оси Y
            pane.YAxis.MajorGrid.DashOn = 10;
            //pane.YAxis.MajorGrid.DashOff = 5;
            // Горизонтальная линия на уровне y = 0 рисоваться не будет
            pane.YAxis.MajorGrid.IsZeroLine = false;

            // Включаем отображение сетки напротив мелких рисок по оси X
            pane.YAxis.MinorGrid.IsVisible = true;

            // Задаем вид пунктирной линии для крупных рисок по оси Y: 
            // Длина штрихов равна одному пикселю, ... 
            pane.YAxis.MinorGrid.DashOn = 1;

            // затем 2 пикселя - пропуск
            pane.YAxis.MinorGrid.DashOff = 2;

            // Включаем отображение сетки напротив мелких рисок по оси Y
            pane.XAxis.MinorGrid.IsVisible = true;

            // Аналогично задаем вид пунктирной линии для крупных рисок по оси Y
            pane.XAxis.MinorGrid.DashOn = 1;
            pane.XAxis.MinorGrid.DashOff = 2;
        }
        public void DrawRandomValues(ZedGraphControl zedGraph, List<double> RandomValues)
        {
            // Получим панель для рисования
            GraphPane pane = zedGraph.GraphPane;
            //pane.Title.Text ="Стан +1 "+ comboBoxRozpodilPlus.SelectedItem.ToString();
            pane.XAxis.Title.Text = "Значення";
            pane.YAxis.Title.Text = "Індекс";

            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            pane.CurveList.Clear();

            // Создадим список точек
            PointPairList list = new PointPairList();
            PointPairList list2 = new PointPairList();
            // Заповнюємо список точок
            for (int i = 0; i < (RandomValues.Count()<100?RandomValues.Count():100); i++)
            {
                list.Add(i, RandomValues[i]);
            }
            // Створюємо ламану "переходи", 
            Color coluor = Color.Red;
            LineItem myCurve = pane.AddCurve("випадкові величини", list, coluor, SymbolType.Circle);
            if (RandomValues.Count()>100)
            for (int i = 100; i < RandomValues.Count(); i++)
            {

                list2.Add(i, RandomValues[i]);
            } 
            LineItem myCurve2 = pane.AddCurve("випадкові величини", list2, Color.Blue, SymbolType.Circle);
            // Викликаємо метод AxisChange (), щоб обновити дані на осях осях. 
            zedGraph.AxisChange();
            // Обновляємо графік
            zedGraph.Invalidate();
            // !!!
            // Включаем отображение сетки напротив крупных рисок по оси X
            pane.XAxis.MajorGrid.IsVisible = true;

            // Задаем вид пунктирной линии для крупных рисок по оси X:
            // Длина штрихов равна 10 пикселям, ... 
            pane.XAxis.MajorGrid.DashOn = 10;

            // затем 5 пикселей - пропуск
            pane.XAxis.MajorGrid.DashOff = 5;


            // Включаем отображение сетки напротив крупных рисок по оси Y
            pane.YAxis.MajorGrid.IsVisible = true;

            //Аналогично задаем вид пунктирной линии для крупных рисок по оси Y
            pane.YAxis.MajorGrid.DashOn = 10;
            //pane.YAxis.MajorGrid.DashOff = 5;
            // Горизонтальная линия на уровне y = 0 рисоваться не будет
            pane.YAxis.MajorGrid.IsZeroLine = false;

            // Включаем отображение сетки напротив мелких рисок по оси X
            pane.YAxis.MinorGrid.IsVisible = true;

            // Задаем вид пунктирной линии для крупных рисок по оси Y: 
            // Длина штрихов равна одному пикселю, ... 
            pane.YAxis.MinorGrid.DashOn = 1;

            // затем 2 пикселя - пропуск
            pane.YAxis.MinorGrid.DashOff = 2;

            // Включаем отображение сетки напротив мелких рисок по оси Y
            pane.XAxis.MinorGrid.IsVisible = true;

            // Аналогично задаем вид пунктирной линии для крупных рисок по оси Y
            pane.XAxis.MinorGrid.DashOn = 1;
            pane.XAxis.MinorGrid.DashOff = 2;
        }
        public void DrawKumulanteRandomValues(ZedGraphControl zedGraph, List<double> RandomValues)
        {
            // Получим панель для рисования
            GraphPane pane = zedGraph.GraphPane;
            //pane.Title.Text ="Стан +1 "+ comboBoxRozpodilPlus.SelectedItem.ToString();
            pane.XAxis.Title.Text = "Значення";
            pane.YAxis.Title.Text = "Індекс";

            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            pane.CurveList.Clear();

            // Создадим список точек
            PointPairList list = new PointPairList();
            // Заповнюємо список точок
            double sum = 0;
            for (int i = 0; i < RandomValues.Count; i++)
            {
                sum += RandomValues[i];
                list.Add(i,sum);
            }
            // Створюємо ламану "переходи", 
            LineItem myCurve = pane.AddCurve("випадкові величини", list, Color.Red, SymbolType.Circle);
            // Викликаємо метод AxisChange (), щоб обновити дані на осях осях. 
            zedGraph.AxisChange();
            // Обновляємо графік
            zedGraph.Invalidate();
            // !!!
            // Включаем отображение сетки напротив крупных рисок по оси X
            pane.XAxis.MajorGrid.IsVisible = true;

            // Задаем вид пунктирной линии для крупных рисок по оси X:
            // Длина штрихов равна 10 пикселям, ... 
            pane.XAxis.MajorGrid.DashOn = 10;

            // затем 5 пикселей - пропуск
            pane.XAxis.MajorGrid.DashOff = 5;


            // Включаем отображение сетки напротив крупных рисок по оси Y
            pane.YAxis.MajorGrid.IsVisible = true;

            //Аналогично задаем вид пунктирной линии для крупных рисок по оси Y
            pane.YAxis.MajorGrid.DashOn = 10;
            //pane.YAxis.MajorGrid.DashOff = 5;
            // Горизонтальная линия на уровне y = 0 рисоваться не будет
            pane.YAxis.MajorGrid.IsZeroLine = false;

            // Включаем отображение сетки напротив мелких рисок по оси X
            pane.YAxis.MinorGrid.IsVisible = true;

            // Задаем вид пунктирной линии для крупных рисок по оси Y: 
            // Длина штрихов равна одному пикселю, ... 
            pane.YAxis.MinorGrid.DashOn = 1;

            // затем 2 пикселя - пропуск
            pane.YAxis.MinorGrid.DashOff = 2;

            // Включаем отображение сетки напротив мелких рисок по оси Y
            pane.XAxis.MinorGrid.IsVisible = true;

            // Аналогично задаем вид пунктирной линии для крупных рисок по оси Y
            pane.XAxis.MinorGrid.DashOn = 1;
            pane.XAxis.MinorGrid.DashOff = 2;
        }
    }
}
