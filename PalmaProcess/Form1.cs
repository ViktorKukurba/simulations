        using System;
        using System.Collections.Generic;
        using System.ComponentModel;
        using System.Data;
        using System.Drawing;
        using System.Linq;
        using System.Text;
        using System.Windows.Forms;
        using ZedGraph;
using ProcessModeling.Classes;


namespace ProcessModeling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            InitializeComboBoxRozpodil(comboBoxRozpodilMinus);
            InitializeComboBoxRozpodil(comboBoxRozpodilPlus);
            InitializeComboBoxRozpodil(comboBoxRozpodilNull);
            
            comboBoxPerehid.SelectedIndex = 0;
            InitializeProcessParameter();
        
            // параметри рівномірного розподілу
            a1 = 0;
            b1 = 1;
            a0 = 0;
            b0 = 1;
            aNull = 0;
            bNull = 1;
        }
        private void InitializeComboBoxRozpodil(ComboBox comboBoxRozpodilMinus)
        {
            comboBoxRozpodilMinus.Items.Add("Рівномірний");
            comboBoxRozpodilMinus.Items.Add("Експоненційний");
            comboBoxRozpodilMinus.Items.Add("розподіл Вейбула");
            comboBoxRozpodilMinus.Items.Add("Нормальний розподіл");
            comboBoxRozpodilMinus.Items.Add("Логарифмічно нормальний");
            comboBoxRozpodilMinus.Items.Add("Ерланга");
            comboBoxRozpodilMinus.Items.Add("хі-квадрат");
            comboBoxRozpodilMinus.Items.Add("розподіл Релея");
            comboBoxRozpodilMinus.Items.Add("Стьюдента");
            comboBoxRozpodilMinus.Items.Add("Фішера");
            comboBoxRozpodilMinus.Items.Add("Бета-розподіл");
            comboBoxRozpodilMinus.SelectedIndex = 1;
        }
        private void InitializeProcessParameter()
        {
            comboBox1.Items.Add("к-сть переходів");
            comboBox1.Items.Add("тривалість");
            comboBox1.SelectedIndex = 0;
        }
        // Глобальні змінні
        public double[] Time = new double[100000];
        public double[] PSOTime = new double[100000];
        public double[] GradTime = new double[100000];
        public double[] EvolTime = new double[100000];
        public double[] EvolTimeZbur = new double[100000];
        public double[] GradETime = new double[100000];
        public int[] PoslidStaniv = new int[100000];
        public Random realRnd = new Random();
        public int stan, StartStan,n;
        public double[] StanMinus1 = new double[100000];
        public double[] StanNull = new double[100000];
        public double[] StanPlus1 = new double[100000];
        public double[] zhi = new double[100];
        public double[,] MatrixPerehid = new double[3,3];
        public double EndTime,a0,b0,a1,b1,aNull,bNull;
        public bool p = true;
        int KilkPerebyvNull = 0, KilkPerebyvMinus = 0, KilkPerebyvPlus = 0;
        private ProcessModeling.Classes.ProcessClass PC = new ProcessModeling.Classes.ProcessClass();
        /*private void GenVupVel(double a0, double b0, ComboBox comboBoxRozpodilMinus,int i,double[] StanMinus1)
        {
           

            Array.Clear(zhi, 0, zhi.Length);
            double x=0;
            if (comboBoxRozpodilMinus.SelectedItem.ToString() == "Рівномірний")
                x = Rivnomirnuj(a0, b0);

            if (comboBoxRozpodilMinus.SelectedItem.ToString() == "Експоненційний")
                x = Exponential(a0, b0);

            if (comboBoxRozpodilMinus.SelectedItem.ToString() == "розподіл Вейбула")
                x = RVejbyla(a0, b0);

            if (comboBoxRozpodilMinus.SelectedItem.ToString() == "Нормальний розподіл")
                x = RNormal(a0, b0);

            if (comboBoxRozpodilMinus.SelectedItem.ToString() == "Логарифмічно нормальний")
                x = RLogNorm(a0, b0);

            if (comboBoxRozpodilMinus.SelectedItem.ToString() == "Ерланга")
                x = RErlang(a0, b0);

            if (comboBoxRozpodilMinus.SelectedItem.ToString() == "хі-квадрат")
                x = RHiKvadrat(a0, zhi);

            if (comboBoxRozpodilMinus.SelectedItem.ToString() == "розподіл Релея")
                x = RReleja(a0);

            if (comboBoxRozpodilMinus.SelectedItem.ToString() == "Стьюдента")
                x = RStudenta(a0, zhi);

            if (comboBoxRozpodilMinus.SelectedItem.ToString() == "Фішера")
                x = RFischera(a0, b0, zhi);

            if (comboBoxRozpodilMinus.SelectedItem.ToString() == "Бета-розподіл")
                x = RBeta(a0, b0, zhi);

            StanMinus1[i] = 0;
            StanNull[i] = 0;
            StanPlus1[i] = 0;
            StanMinus1[i] = x;

        }
        */
        /*private void Gen2StanTruv(double Etime)
        {
            double x;
            double T;
            EndTime = Etime;
            int p,ncount=0;
            stan = -1;
            StartStan = 1;
            for (int j = 0; j <= n; j++)
            {
                Time[j] = 0;
            }
            Random realRnd = new Random();
            x = realRnd.NextDouble();

            if (x < 0.5) { stan = -1; StartStan = -1; } else stan = 1;
            if (comboBox1.SelectedItem.ToString() == "тривалість")
            {
                int i = 0; T = 0;
                while(T<=EndTime)
                  {
                      p = 0;
                      if (stan == -1)
                      {
                          if (comboBoxRozpodilMinus.SelectedItem.ToString() == "Рівномірний")
                              x = realRnd.NextDouble();
                          if (comboBoxRozpodilMinus.SelectedItem.ToString() == "Експотенціальний")
                              x = -Math.Log(realRnd.NextDouble());

                          StanMinus1[i] = x;
                          StanPlus1[i] = 0;
                          stan = 1; p = 1;
                          T++;
                      }
                      if (stan == 1 && p == 0)
                      {
                          //x = realRnd.NextDouble();
                          if (comboBoxRozpodilMinus.SelectedItem.ToString() == "Рівномірний")
                              x = Rivnomirnuj(a1,b1);
                          if (comboBoxRozpodilMinus.SelectedItem.ToString() == "Експотенціальний")
                              x = Exponential(a1,b1);
                          x = realRnd.NextDouble();
                          StanPlus1[i] = x;
                          StanMinus1[i] = 0;
                          stan = -1; p = 0;
                          T = T + 1;
                      }
                      i++;
                      ncount++;
                      //T = T + StanPlus1[i] + StanMinus1[i];
                  }

                for (int l = 0; l <= n; i++)
                {
                    for (int j = 0; j <= l; j++)
                    {
                        Time[l + 1] = Time[l] + StanMinus1[j + 1] + StanPlus1[j + 1];
                    }
                }
                textBox2.Text = Convert.ToString(Time[n - 1]);
                textBox1.Text = Convert.ToString(n);
                textBox1.Visible = true;
                label1.Visible = true;
            }
            }
        */
        /*private void Gen2StanPer(int KilkistPerehodiv)
        {
            //double x; //x1 = 0, y, z;//StanMinus1Max,StanMinus1Min,StanPlus1Max,StanPlus1Min;
            if (KilkistPerehodiv != 0) { n = KilkistPerehodiv; }
            int p;//p прапорець, вказує на те, що перехід на і-ому кроці вже відбувся чи ні
            IdentPerehid();// ідентифікуємо матрицю переходів
            //обнулення масивів
            Array.Clear(Time, 0, Time.Length);

            stan = 0;// починаємо з стану 0
            StartStan = 0;
            if (comboBox1.SelectedItem.ToString() == "к-сть переходів")
            {
                for (int i = 0; i < n; i++)
                {
                    //Розподіли для стану -1
                    p = 0;
                    if (stan == -1 && p==0)
                    {
                        PoslidStaniv[i] = -1;
                        GenVupVel(a0, b0, comboBoxRozpodilMinus, i, StanMinus1);
                        if (comboBoxPerehid.SelectedItem.ToString() == "Послідовний (0,1,-1)")
                        {
                            stan = 0; 
                        }
                        if (comboBoxPerehid.SelectedItem.ToString() == "Матриця переходів")
                        {
                            stan = Perehid(-1, MatrixPerehid);
                        }   
                        p = 1;
                    }
                    
                    //Розподіли для стану 1
                    if ((stan == 1) && (p == 0))
                    {
                        PoslidStaniv[i] = 1;
                        GenVupVel(a1, b1, comboBoxRozpodilPlus, i, StanPlus1);
                        if (comboBoxPerehid.SelectedItem.ToString() == "Послідовний (0,1,-1)")
                        {
                            stan = -1;
                        }
                        if (comboBoxPerehid.SelectedItem.ToString() == "Матриця переходів")
                        {
                            stan = Perehid(1, MatrixPerehid);
                        }
                        p = 1;
                    }
                    //Розподіли для стану 0
                    if (stan == 0 && p == 0)
                    {
                        PoslidStaniv[i] = 0;
                        GenVupVel(aNull, bNull, comboBoxRozpodilNull, i, StanNull);
                        if (comboBoxPerehid.SelectedItem.ToString() == "Послідовний (0,1,-1)")
                        {
                            stan = 1;
                        }
                        if (comboBoxPerehid.SelectedItem.ToString() == "Матриця переходів")
                        {
                            stan = Perehid(0, MatrixPerehid);
                        }
                        p = 1;
                    }
                }
                Time[0] = StanMinus1[0] + StanPlus1[0] + StanNull[0];
                for (int i = 0; i <= n; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Time[i + 1] = Time[i] + StanMinus1[j + 1] + StanPlus1[j + 1] + StanNull[j+1];
                    }
                }               
                textBox2.Text = Convert.ToString(Time[n - 1]);
                textBox2.Visible = true;
                label2.Visible = true;

            }
           
            }           
        */
        private void MinMax(double[] Stan1, double[] Stan2)
        {
            int Minus1Max = 0, Minus1Min = 0, Plus1Max = 0, Plus1Min = 0, kistPlus = 0, kistMinus = 0;
            double StanMinus1Max = 0, StanMinus1Min = 100, StanPlus1Max = 0, StanPlus1Min = 100, SumStan1=0, SumStan2=0;

            if (StanMinus1[0] != 0)
            {
                if (n % 2 != 0)
                {
                    kistPlus = (n - 1) / 2 + 1;
                }
                else kistPlus = n / 2;
                kistMinus = n - kistPlus;
                StanMinus1Max = StanMinus1[0];
            }
            else StanMinus1Max = StanMinus1[1];
            //kistPlus=Sta
            
            for (int i = 1; i <= n; i++)
            {
                if (StanMinus1[i] > StanMinus1Max)
                {
                    StanMinus1Max = StanMinus1[i];
                    Minus1Max = i;
                }
                if ((StanMinus1[i] < StanMinus1Min) && (StanMinus1[i]!=0))
                {
                    StanMinus1Min = StanMinus1[i];
                    Minus1Min = i;
                }
            }
            label8.Text = "Min ";
            label9.Text = "Max ";
            label8.Text += Convert.ToString(Minus1Min) + "  " + Convert.ToString(StanMinus1Min);
            label9.Text += Convert.ToString(Minus1Max) + "  " + Convert.ToString(StanMinus1Max);
            
            label8.Visible = true;
            label9.Visible = true;

            groupBoxStatMinus.Visible = true;

            if (StanPlus1[0] != 0)
            {
                if (n % 2 != 0)
                {
                    kistPlus = (n-1) / 2 + 1;
                }
                else kistPlus = n / 2;
                kistMinus = n - kistPlus;
                StanPlus1Max = StanPlus1[0];

            }
            else StanPlus1Max = StanPlus1[1];

            for (int i = 1; i <= n; i++)
            {
                if (StanPlus1[i] > StanPlus1Max)
                {
                    StanPlus1Max = StanPlus1[i];
                    Plus1Max = i;
                }
                if ((StanPlus1[i] < StanPlus1Min) && (StanPlus1[i] != 0))
                {
                    StanPlus1Min = StanPlus1[i];
                    Plus1Min = i;
                }
            }
            for (int i = 0; i <= n + 1; i++)
            {
                SumStan1 = SumStan1 + StanMinus1[i];
                SumStan2 = SumStan2 + StanPlus1[i];
            }
            SumStan1 = SumStan1 /KilkPerebyvMinus;
            SumStan2=SumStan2/KilkPerebyvPlus;
            labelSerMinus.Text = "Середнє -1 " + Convert.ToString(SumStan1);
            labelSerPlus.Text = "Середнє +1 " + Convert.ToString(SumStan2);
            label10.Text = "Min ";
            label11.Text = "Max ";
            label10.Text += Convert.ToString(Plus1Min) + "  " + Convert.ToString(StanPlus1Min);
            label11.Text += Convert.ToString(Plus1Max) + "  " + Convert.ToString(StanPlus1Max);

            labelSerMinus.Visible = true;
            labelSerPlus.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            groupBoxStatPlus.Visible = true;
            groupBoxStatMinus.Visible = true;
            MatSpoDusp(comboBoxRozpodilMinus, labelMatSpodMinus);
            MatSpoDusp(comboBoxRozpodilPlus, labelMatSpodPlus);
        }
        private void MatSpoDusp(ComboBox comboBoxRozpodilMinus, System.Windows.Forms.Label labelMatSpodMinus)
        {
            if (comboBoxRozpodilMinus.SelectedItem.ToString() == "Рівномірний")
            {
                labelMatSpodMinus.Text = "М " + Convert.ToString((a0 + b0) / 2);
            }

            if (comboBoxRozpodilMinus.SelectedItem.ToString() == "Експоненційний")
            {
                labelMatSpodMinus.Text = "М " + Convert.ToString(b0 + 1 / a0);
            }
            if (comboBoxRozpodilMinus.SelectedItem.ToString() == "розподіл Вейбула")
            {
                labelMatSpodMinus.Text = "М ---";
            }
            if (comboBoxRozpodilMinus.SelectedItem.ToString() == "Нормальний розподіл")
            {
                labelMatSpodMinus.Text = "М " + Convert.ToString(a0);
            }
            if (comboBoxRozpodilMinus.SelectedItem.ToString() == "Бета-розподіл")
            {
                labelMatSpodMinus.Text = "М " + Convert.ToString(b0 / (a0 + b0));
            }
            if (comboBoxRozpodilMinus.SelectedItem.ToString() == "Логарифмічно нормальний")
            {
                labelMatSpodMinus.Text = "М " + Convert.ToString(Math.Exp(a0 + Math.Pow(b0,2)/2));
            }
            if (comboBoxRozpodilMinus.SelectedItem.ToString() == "Ерланга")
            {
                labelMatSpodMinus.Text = "М " + Convert.ToString(a0 / b0); ;
            }
            if (comboBoxRozpodilMinus.SelectedItem.ToString() == "хі-квадрат")
            {
                labelMatSpodMinus.Text = "М " + Convert.ToString(a0);
            }
            if (comboBoxRozpodilMinus.SelectedItem.ToString() == "розподіл Релея")
            {
                labelMatSpodMinus.Text = "М " + Convert.ToString(a0 * Math.Pow(Math.PI / 2, 1 / 2));
            }
            if (comboBoxRozpodilMinus.SelectedItem.ToString() == "Стьюдента")
            {
                labelMatSpodMinus.Text = "М " + Convert.ToString(0);
            }
            if (comboBoxRozpodilMinus.SelectedItem.ToString() == "Фішера")
            {
                labelMatSpodMinus.Text = "М " + Convert.ToString(b0/(b0-2));
            }


        }
        private void DrawRozpodilMinus1()
        {
            int Minus1Max=0, Minus1Min=10, Plus1Max, Plus1Min;
            double StanMinus1Max=0, StanMinus1Min=5, StanPlus1Max, StanPlus1Min;
            // Получим панель для рисования
            GraphPane pane = zedGraphMinus1.GraphPane;
            pane.Title.Text = "Стан -1 "+comboBoxRozpodilMinus.SelectedItem.ToString();
            pane.XAxis.Title.Text = "Значення";
            pane.YAxis.Title.Text = "Індекс";

            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            pane.CurveList.Clear();

            // Створюємо список точок
            PointPairList list = new PointPairList();

            // Заповнюємо список точок
            if (StanMinus1[0] != 0)
            {
                list.Add(0, StanMinus1[0]);
                StanMinus1Max = StanMinus1[1];
                StanMinus1Min = StanMinus1[1];
                
                for (int i = 2; i <= n ; i = i + 2)
                {
                    double y = StanMinus1[i];
                    list.Add(i, y);
                    if (StanMinus1[i] > StanMinus1Max) 
                    {
                        StanMinus1Max = StanMinus1[i];
                        Minus1Max = i;
                    }
                    if (StanMinus1[i] < StanMinus1Max)
                    {
                        StanMinus1Min = StanMinus1[i];
                        Minus1Min = i;
                    }
                }
            }
            else
            {
                for (int i = 1; i <= n; i = i + 2)
                {
                    double y = StanMinus1[i];
                    list.Add(i, y);
                    StanMinus1Max = StanMinus1[0];
                    StanMinus1Min = StanMinus1[0];
                    if (StanMinus1[i] > StanMinus1Max)
                    {
                        StanMinus1Max = StanMinus1[i];
                        Minus1Max = i;
                    }
                    if (StanMinus1[i] < StanMinus1Max)
                    {
                        StanMinus1Min = StanMinus1[i];
                        Minus1Min = i;
                    }
                }
            }
            
            // !!!
            // Создадим кривую с названием "Scatter".
            // Обводка ромбиков будут рисоваться голубым цветом (Color.Blue),
            // Опорные точки - ромбики (SymbolType.Diamond)
            LineItem myCurve = pane.AddCurve("Scatter", list, Color.DarkBlue, SymbolType.Diamond);

            // !!!
            // У кривой линия будет невидимой
            myCurve.Line.IsVisible = false;

            // !!!
            // Цвет заполнения отметок (ромбиков) - колубой
            //myCurve.Symbol.Fill.Color = Color.Blue;

            // !!!
            // Тип заполнения - сплошная заливка
            myCurve.Symbol.Fill.Type = FillType.Solid;

            // !!!
            // Размер ромбиков
            myCurve.Symbol.Size = 5;


            // Устанавливаем интересующий нас интервал по оси X
            pane.XAxis.Scale.Min = 0;
            pane.XAxis.Scale.Max = n;

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
        private void DrawRozpodilNull()
        {
            int NullMax = 0, NullMin = 10;
            double StanNullMax = 0, StanNullMin = 5;
            // Получим панель для рисования
            GraphPane pane = zedGraphNull.GraphPane;
            pane.Title.Text = "Стан 0 " + comboBoxRozpodilNull.SelectedItem.ToString();
            pane.XAxis.Title.Text = "Значення";
            pane.YAxis.Title.Text = "Індекс";

            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            pane.CurveList.Clear();

            // Створюємо список точок
            PointPairList list = new PointPairList();

            // Заповнюємо список точок
            if (StanNull[0] != 0)
            {
                list.Add(0, StanNull[0]);
                StanNullMax = StanNull[1];
                StanNullMin = StanNull[1];

                for (int i = 2; i <= n; i = i + 2)
                {
                    double y = StanNull[i];
                    list.Add(i, y);
                    if (StanNull[i] > StanNullMax)
                    {
                        StanNullMax = StanNull[i];
                        NullMax = i;
                    }
                    if (StanNull[i] < StanNullMax)
                    {
                        StanNullMin = StanNull[i];
                        NullMin = i;
                    }
                }
            }
            else
            {
                for (int i = 1; i <= n; i = i + 2)
                {

                    double y = StanNull[i];
                    list.Add(i, y);
                    StanNullMax = StanNull[0];
                    StanNullMin = StanNull[0];
                    if (StanNull[i] > StanNullMax)
                    {
                        StanNullMax = StanNull[i];
                        NullMax = i;
                    }
                    if (StanNull[i] < StanNullMax)
                    {
                        StanNullMin = StanNull[i];
                        NullMin = i;
                    }
                }
            }

            // !!!
            // Создадим кривую с названием "Scatter".
            // Обводка ромбиков будут рисоваться голубым цветом (Color.Blue),
            // Опорные точки - ромбики (SymbolType.Diamond)
            LineItem myCurve = pane.AddCurve("Scatter", list, Color.DarkBlue, SymbolType.Diamond);

            // !!!
            // У кривой линия будет невидимой
            myCurve.Line.IsVisible = false;

            // !!!
            // Цвет заполнения отметок (ромбиков) - колубой
            //myCurve.Symbol.Fill.Color = Color.Blue;

            // !!!
            // Тип заполнения - сплошная заливка
            myCurve.Symbol.Fill.Type = FillType.Solid;

            // !!!
            // Размер ромбиков
            myCurve.Symbol.Size = 5;


            // Устанавливаем интересующий нас интервал по оси X
            pane.XAxis.Scale.Min = 0;
            pane.XAxis.Scale.Max = n;

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
        private void IdentPerehid()
        {
           /*
            MatrixPerehid[0, 0] = Convert.ToDouble(textBoxP11.Text);
            MatrixPerehid[0, 1] = Convert.ToDouble(textBoxP12.Text);
            MatrixPerehid[0, 2] = Convert.ToDouble(textBoxP13.Text);

            MatrixPerehid[1, 0] = Convert.ToDouble(textBoxP21.Text);
            MatrixPerehid[1, 1] = Convert.ToDouble(textBoxP22.Text);
            MatrixPerehid[1, 2] = Convert.ToDouble(textBoxP23.Text);

            MatrixPerehid[2, 0] = Convert.ToDouble(textBoxP31.Text);
            MatrixPerehid[2, 1] = Convert.ToDouble(textBoxP32.Text);
            MatrixPerehid[2, 2] = Convert.ToDouble(textBoxP33.Text);
            // Inicialization MatrixofSwichings

            PC.MatrixofSwitchings[0, 0] = Convert.ToDouble(textBoxP11.Text);
            PC.MatrixofSwitchings[0, 1] = Convert.ToDouble(textBoxP12.Text);
            PC.MatrixofSwitchings[0, 2] = Convert.ToDouble(textBoxP13.Text);

            PC.MatrixofSwitchings[1, 0] = Convert.ToDouble(textBoxP21.Text);
            PC.MatrixofSwitchings[1, 1] = Convert.ToDouble(textBoxP22.Text);
            PC.MatrixofSwitchings[1, 2] = Convert.ToDouble(textBoxP23.Text);

            PC.MatrixofSwitchings[2, 0] = Convert.ToDouble(textBoxP31.Text);
            PC.MatrixofSwitchings[2, 1] = Convert.ToDouble(textBoxP32.Text);
            PC.MatrixofSwitchings[2, 2] = Convert.ToDouble(textBoxP33.Text);

            // Inicialization Matrix of StartDistribution
            PC.StartDistribution[0] = Convert.ToDouble(textBoxP11.Text);
            PC.StartDistribution[1] = Convert.ToDouble(textBoxP12.Text);
            PC.StartDistribution[2] = Convert.ToDouble(textBoxP13.Text);

            */
         

 
        }
        private int Perehid(int stan, double[,] MatrixP)
        {
            double x=0;
            int nextStan=3;
            stan = stan + 1;
            x = realRnd.NextDouble();
            if (x <= MatrixP[stan, 0]) { nextStan = -1;}
            if ((x > MatrixP[stan, 0] )&&(x <= MatrixP[stan, 0] + MatrixP[stan, 1])) { nextStan = 0; }
            if (x > MatrixP[stan, 0] + MatrixP[stan, 1]) { nextStan = 1; }
            return nextStan;
            
        }
        private void DrawRozpodilPlus1()
        {
            // Получим панель для рисования
            GraphPane pane = zedGraphPlus1.GraphPane;
            pane.Title.Text ="Стан +1 "+ comboBoxRozpodilPlus.SelectedItem.ToString();
            pane.XAxis.Title.Text = "Значення";
            pane.YAxis.Title.Text = "Індекс";

            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            pane.CurveList.Clear();

            // Создадим список точек
            PointPairList list = new PointPairList();

            // Заполняем список точек
            if (StanPlus1[0] != 0)
            {
                list.Add(0, StanPlus1[0]);
                for (int i = 2; i < n; i = i + 2)
                {
                    // 
                    double y = StanPlus1[i];
                    //int x = i / 2;
                    list.Add(i, y);
                }
            }
            else
            {
                for (int i = 1; i < n; i = i + 2)
                {
                    // 
                    double y = StanPlus1[i];
                    //int x = i / 2;
                    list.Add(i, y);
                }
            }

            // !!!
            // Создадим кривую с названием "Scatter".
            // Обводка ромбиков будут рисоваться голубым цветом (Color.Blue),
            // Опорные точки - ромбики (SymbolType.Diamond)
            LineItem myCurve = pane.AddCurve("Scatter", list, Color.DarkGreen, SymbolType.Diamond);
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
        private void DrawGraph()
        {
            // Получим панель для рисования

            GraphPane pane = zedGraph.GraphPane;

            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            pane.CurveList.Clear();

            // Создадим список точек
            PointPairList list = new PointPairList();

            double xmin = -50;
            double xmax = 50;

            // Заполняем список точек
            for (double x = xmin; x <= xmax; x += 0.01)
            {
                // добавим в список точку
                list.Add(x, 1);
            }

            // Создадим кривую с названием "Sinc", 
            // которая будет рисоваться голубым цветом (Color.Blue),
            // Опорные точки выделяться не будут (SymbolType.None)
            LineItem myCurve = pane.AddCurve("Sinc", list, Color.Blue, SymbolType.None);

            // Вызываем метод AxisChange (), чтобы обновить данные об осях. 
            // В противном случае на рисунке будет показана только часть графика, 
            // которая умещается в интервалы по осям, установленные по умолчанию
            zedGraph.AxisChange();

            // Обновляем график
            zedGraph.Invalidate();
        }
        /*private void CreateTable()
        {
            //PC.AmountofSwitchings = Convert.ToInt32(textBox1.Text);
            double[,] Stann = new double[Convert.ToInt32(textBox1.Text), 3];
            Stann = PC.Process(Convert.ToInt32(textBox1.Text));
            double SumStan1 = 0, SumStan2 = 0, SumStan0 = 0;
            int ntable;
            KilkPerebyvNull=KilkPerebyvPlus = KilkPerebyvMinus = 0;

            for (int k = 0; k < Convert.ToInt32(textBox1.Text); k++)
            {
                if (Stann[k,0] != 0)
                    KilkPerebyvMinus++;
                if (Stann[k,2] != 0)
                    KilkPerebyvPlus++;
                if (Stann[k,1] != 0)
                    KilkPerebyvNull++;
            }
            if (Convert.ToInt32(textBox1.Text) > 600) ntable = 600; else ntable = Convert.ToInt32(textBox1.Text);
            dataGridView1.RowCount = 5;
            dataGridView1.ColumnCount = ntable+3;
            
            dataGridView1.Rows[0].Cells[0].Value = Convert.ToString("номер переходу");
            dataGridView1.Rows[1].Cells[0].Value = Convert.ToString("Час в -1");
            dataGridView1.Rows[2].Cells[0].Value = Convert.ToString("Час в 0");
            dataGridView1.Rows[3].Cells[0].Value = Convert.ToString("Час в +1");
            dataGridView1.Rows[4].Cells[0].Value = Convert.ToString("Тривалість процесу");
            //Stan1.DefaultIfEmpty();
            for (int i = 0; i <= ntable-1; i++)
            {
                dataGridView1.Rows[0].Cells[i+3].Value = Convert.ToString(i);
                dataGridView1.Rows[1].Cells[i+3].Value = Convert.ToString(Stann[i,0]);
                dataGridView1.Rows[2].Cells[i+3].Value = Convert.ToString(Stann[i,1]);
                dataGridView1.Rows[3].Cells[i+3].Value = Convert.ToString(Stann[i,2]);
                dataGridView1.Rows[4].Cells[i+3].Value = Convert.ToString(Time[i]);
                //SumStan1 = SumStan1 + Stan1[i - 1];
                //SumStan2 = SumStan2 + Stan2[i - 1];
            }
            for (int i = 0; i < n; i++)
            {
               // SumStan1 = SumStan1 + Stann[i, 0];
               // SumStan2 = SumStan2 + Stann[i, 1];
               // SumStan0 = SumStan0 + Stann[i, 2];
            }
            
              dataGridView1.Rows[0].Cells[1].Value = Convert.ToString("сумарний час");
              dataGridView1.Rows[1].Cells[1].Value = Convert.ToString(SumStan1);
              dataGridView1.Rows[2].Cells[1].Value = Convert.ToString(SumStan0);
              dataGridView1.Rows[3].Cells[1].Value = Convert.ToString(SumStan2);
              dataGridView1.Rows[4].Cells[1].Value = Convert.ToString(SumStan1 + SumStan2 + SumStan0);

              dataGridView1.Rows[0].Cells[2].Value = Convert.ToString("К-сть перебувань");
              dataGridView1.Rows[1].Cells[2].Value = Convert.ToString(KilkPerebyvMinus);
              dataGridView1.Rows[2].Cells[2].Value = Convert.ToString(KilkPerebyvNull);
              dataGridView1.Rows[3].Cells[2].Value = Convert.ToString(KilkPerebyvPlus);
              dataGridView1.Rows[4].Cells[2].Value = Convert.ToString(KilkPerebyvMinus + KilkPerebyvNull + KilkPerebyvPlus);
        }
        */
        private void DrawProcess()
        {
            GraphPane pane = zedGraph.GraphPane;
            pane.Title.Text="Процес з трьома станами";
            pane.XAxis.Title.Text = "Час";
            pane.YAxis.Title.Text = "Стан";
            // Очистимо список ламаних
            pane.CurveList.Clear();
            // створюємо список точок
            PointPairList list = new PointPairList();
            list.Add(0, StartStan);
            list.Add(Time[0], StartStan);
            //StartStan = -StartStan;
            list.Add(Time[0], PoslidStaniv[1]);
            // Заповнюємо список точок
            for (int i = 1; i < n ; i++)
            {
                list.Add(Time[i], PoslidStaniv[i]);
                   // StartStan = -StartStan;
                list.Add(Time[i], PoslidStaniv[i+1]);
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
        private void DrawPSO()
        {
            GraphPane pane = zedGraphPSO.GraphPane;
            pane.Title.Text = "Процедура стохастичної оптимізації";
            pane.XAxis.Title.Text = "Час";
            pane.YAxis.Title.Text = "delta(u)";
            // Очистимо список ламаних
            pane.CurveList.Clear();
            // створюємо список точок
            PointPairList list = new PointPairList();
            // Заповнюємо список точок
            list.Add(0, PSOTime[0]);
            for (int i = 1; i <= n; i++)
            {
                list.Add(Time[i-1], PSOTime[i]);
            }
            // Створюємо ламану "переходи", 
            LineItem myCurve = pane.AddCurve("ПСО", list, Color.Red, SymbolType.Circle);
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

            // Аналогично задаем вид пунктирной линии для крупных рисок по оси Y
            pane.YAxis.MajorGrid.DashOn = 10;
            pane.YAxis.MajorGrid.DashOff = 5;


            // Включаем отображение сетки напротив мелких рисок по оси X
            //pane.YAxis.MinorGrid.IsVisible = true;

            // Задаем вид пунктирной линии для крупных рисок по оси Y: 
            // Длина штрихов равна одному пикселю, ... 
            pane.YAxis.MinorGrid.DashOn = 1;

            // затем 2 пикселя - пропуск
            pane.YAxis.MinorGrid.DashOff = 2;

            // Включаем отображение сетки напротив мелких рисок по оси Y
            //pane.XAxis.MinorGrid.IsVisible = true;

            // Аналогично задаем вид пунктирной линии для крупных рисок по оси Y
            pane.XAxis.MinorGrid.DashOn = 1;
            pane.XAxis.MinorGrid.DashOff = 2;



        }
        private void DrawEvol()
        {
            GraphPane pane = zedGraphEvol.GraphPane;
            pane.Title.Text = "Еволюція і збурення";
            pane.XAxis.Title.Text = "Час";
            pane.YAxis.Title.Text = "Еволюція";
            // Очистимо список ламаних
            pane.CurveList.Clear();
            // створюємо список точок
            PointPairList list2 = new PointPairList();
            // Заповнюємо список точок
            list2.Add(0, Function(0, 0));
            for (int i = 0; i < n; i++)
            {

                list2.Add(Time[i], Function(Time[i], 0));
                //list2.Add(Time[i + 1], Function(EvolTimeZbur[i], PoslidStaniv[i]));

            }
            // Створюємо ламану "переходи", 
            LineItem myCurve2 = pane.AddCurve("ПСО", list2, Color.Black, SymbolType.None);
            PointPairList list = new PointPairList();
            // Заповнюємо список точок
            list.Add(0, Function(0, 0));
            list.Add(Time[0], Function(Time[0], 0));
            for (int i = 0; i < n; i++)
            {

                list.Add(Time[i], Function(Time[i], PoslidStaniv[i+1]));
                list.Add(Time[i+1], Function(Time[i + 1], PoslidStaniv[i+1]));

            }
            // Створюємо ламану "переходи", 
            LineItem myCurve = pane.AddCurve("ПСО", list, Color.Red, SymbolType.None);

            PointPairList list1 = new PointPairList();
            // Заповнюємо список точок
            list1.Add(0, Function(0, 0));
            list1.Add(Time[0], Function(Time[0], 0));
            for (int i = 1; i < n; i++)
            {

                list1.Add(Time[i], Function(Time[i], PoslidStaniv[i]));
                //list1.Add(Time[i+1], Function(Time[i+1], PoslidStaniv[i]));

            }
            // Створюємо ламану "переходи", 
            LineItem myCurve1 = pane.AddCurve("ПСО", list1, Color.Blue, SymbolType.None);

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

            // Аналогично задаем вид пунктирной линии для крупных рисок по оси Y
            pane.YAxis.MajorGrid.DashOn = 10;
            pane.YAxis.MajorGrid.DashOff = 5;


            // Включаем отображение сетки напротив мелких рисок по оси X
            //pane.YAxis.MinorGrid.IsVisible = true;

            // Задаем вид пунктирной линии для крупных рисок по оси Y: 
            // Длина штрихов равна одному пикселю, ... 
            pane.YAxis.MinorGrid.DashOn = 1;

            // затем 2 пикселя - пропуск
            pane.YAxis.MinorGrid.DashOff = 2;

            // Включаем отображение сетки напротив мелких рисок по оси Y
            //pane.XAxis.MinorGrid.IsVisible = true;

            // Аналогично задаємо вид пунктирної лінії для жирних рисок по осі Y
            pane.XAxis.MinorGrid.DashOn = 1;
            pane.XAxis.MinorGrid.DashOff = 2;
        }
        private bool Checking()
        {

            if (Convert.ToInt32(textBox1.Text) > 99999)
            {
                MessageBox.Show("Кількість переходів повинна бути меншою 99999", "Помилка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error); p = false;
            }
            
            if (comboBox1.SelectedItem.ToString() == "тривалість")
            {
                MessageBox.Show("Опція знаходиться в стані розробки. Виберіть к-сть переходів", "Зауваження",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                p = false;
            } 
            if ((comboBoxRozpodilMinus.Text == null)||(comboBoxRozpodilMinus.Text == null))
            {
                MessageBox.Show("Ви не вибрали розподілу для одного з станів", "Зауваження",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                p = false;
            }
            return p;
        }
        void zedGraph_ZoomEvent(ZedGraphControl sender, ZoomState oldState, ZoomState newState)
        {
            GraphPane pane = sender.GraphPane;

            // Для простоты примера будем ограничивать масштабирование
            // только в сторону уменьшения размера графика

            // Проверим интервал для каждой оси и
            // при необходимости скорректируем его

            if (pane.XAxis.Scale.Min <= -100)
            {
                pane.XAxis.Scale.Min = -100;
            }

            if (pane.XAxis.Scale.Max >= 100)
            {
                pane.XAxis.Scale.Max = 100;
            }

            if (pane.YAxis.Scale.Min <= -1)
            {
                pane.YAxis.Scale.Min = -1;
            }

            if (pane.YAxis.Scale.Max >= 2)
            {
                pane.YAxis.Scale.Max = 2;
            }
        }
        /*
        public void button1_Click(object sender, EventArgs e)
        {
            //ProcessModeling.Classes.ProcessClass PC = new ProcessModeling.Classes.ProcessClass();
            a0 = Convert.ToDouble(textBoxParamMinusA.Text);
            b0 = Convert.ToDouble(textBoxParamMinusB.Text);

            a1 = Convert.ToDouble(textBoxParamPlusA.Text);
            b1 = Convert.ToDouble(textBoxParamPlusB.Text);

            aNull = Convert.ToDouble(textBoxParamNullA.Text);
            bNull = Convert.ToDouble(textBoxParamNullB.Text);

            
            /*if (comboBoxRozpodiMinus.SelectedItem.ToString() == "Рівномірний")
            {
                    a0 =Convert.ToDouble(textBoxParamMinusA.Text);
                    b0 =Convert.ToDouble(textBoxParamMinusB.Text);
                    p = true;
             }
            if (comboBoxRozpodiMinus.SelectedItem.ToString() == "Експоненційний")
            {
                a0 = Convert.ToDouble(textBoxParamMinusA.Text);
                b0 = Convert.ToDouble(textBoxParamMinusB.Text);
                p = true;
            }
            if (comboBoxRozpodiMinus.SelectedItem.ToString() == "Нормальний розподіл")
            {
                a0 = Convert.ToDouble(textBoxParamMinusA.Text);
                b0 = Convert.ToDouble(textBoxParamMinusB.Text);
                p = true;
            }
            if (comboBoxRozpodiMinus.SelectedItem.ToString() == "розподіл Вейбула")
            {
                a0 = Convert.ToDouble(textBoxParamMinusA.Text);
                b0 = Convert.ToDouble(textBoxParamMinusB.Text);
                p = true;
            }*/

        /*
            if (Checking() == true)
            {
                if (comboBox1.SelectedItem.ToString() == "к-сть переходів")
                {
                    //PC.AmountofSwitchings = Convert.ToInt32(textBox1.Text);
                    PC.Process(Convert.ToInt32(textBox1.Text));
                    //Gen2StanPer(n);
                }
                else
                {
                    EndTime = Convert.ToDouble(textBox2.Text);
                    //Gen2StanTruv(n);
                }
                IdentPerehid();    
                CreateTable();
                DrawProcess();
                DrawRozpodilMinus1();
                DrawRozpodilPlus1();
                DrawRozpodilNull();
                MinMax(StanMinus1,StanPlus1);
                EvolZbur();
                PSO();
                Evol();
                DrawPSO();
                DrawEvol();
            }
        }*/
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "к-сть переходів")
            {
                textBox1.Visible = true;
                textBox2.Visible = false;
                label2.Visible = false;
                label1.Visible = true;
            }
            if (comboBox1.SelectedItem.ToString() == "тривалість")
            {
                textBox2.Visible = true;
                textBox1.Visible = false;
                label1.Visible = false;
                label2.Visible = true;
            }
        }
        private void comboBoxRozpodilMinus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRozpodilMinus.SelectedItem.ToString() == "Рівномірний")
            {
                textBoxParamMinusA.Visible = true;
                textBoxParamMinusB.Visible = true;
                labelparamMinusA.Visible = true;
                labelparamMinusB.Visible = true;
                labelparamMinusA.Text = "параметр a";
                labelparamMinusB.Text = "параметр b";
                
            }

            if (comboBoxRozpodilMinus.SelectedItem.ToString() == "Експоненційний")
            {
                textBoxParamMinusA.Visible = true;
                labelparamMinusA.Text = "інтенсивність";
                textBoxParamMinusB.Visible = true;
                labelparamMinusA.Visible = true;
                labelparamMinusB.Visible = true;
                labelparamMinusB.Text = "параметр зсуву";

            }
            if (comboBoxRozpodilMinus.SelectedItem.ToString() == "розподіл Вейбула")
            {
                textBoxParamMinusA.Visible = true;
                textBoxParamMinusB.Visible = true;
                labelparamMinusA.Visible = true;
                labelparamMinusB.Visible = true;
                labelparamMinusA.Text = "параметр a";
                labelparamMinusB.Text = "параметр b";
                
            }
            if (comboBoxRozpodilMinus.SelectedItem.ToString() == "Нормальний розподіл")
            {
                textBoxParamMinusA.Visible = true;
                textBoxParamMinusB.Visible = true;
                labelparamMinusA.Visible = true;
                labelparamMinusB.Visible = true;
                labelparamMinusA.Text = "мат. сподівання";
                labelparamMinusB.Text = "сигма";   
            }
            if (comboBoxRozpodilMinus.SelectedItem.ToString() == "Бета-розподіл")
            {
                textBoxParamMinusA.Visible = true;
                textBoxParamMinusB.Visible = true;
                labelparamMinusA.Visible = true;
                labelparamMinusB.Visible = true;
                labelparamMinusA.Text = "параметр n1";
                labelparamMinusB.Text = "параметр n2"; 
            }
            if (comboBoxRozpodilMinus.SelectedItem.ToString() == "Логарифмічно нормальний")
            {
                textBoxParamMinusA.Visible = true;
                textBoxParamMinusB.Visible = true;
                labelparamMinusA.Visible = true;
                labelparamMinusB.Visible = true;
                labelparamMinusA.Text = "параметр a";
                labelparamMinusB.Text = "параметр s"; 
            }
            if (comboBoxRozpodilMinus.SelectedItem.ToString() == "Ерланга")
            {
                textBoxParamMinusA.Visible = true;
                textBoxParamMinusB.Visible = true;
                labelparamMinusA.Visible = true;
                labelparamMinusB.Visible = true;
                labelparamMinusA.Text = "параметр k";
                labelparamMinusB.Text = "параметр a"; 
            }
            if (comboBoxRozpodilMinus.SelectedItem.ToString() == "хі-квадрат")
            {
                textBoxParamMinusA.Visible = true;
                textBoxParamMinusB.Visible = false;
                labelparamMinusA.Visible = true;
                labelparamMinusB.Visible = false;
                labelparamMinusA.Text = "параметр n";
            }
            if (comboBoxRozpodilMinus.SelectedItem.ToString() == "розподіл Релея")
            {
                textBoxParamMinusA.Visible = true;
                textBoxParamMinusB.Visible = false;
                labelparamMinusA.Visible = true;
                labelparamMinusB.Visible = false;
                labelparamMinusA.Text = "параметр s";
            }  
            if (comboBoxRozpodilMinus.SelectedItem.ToString() == "Стьюдента")
            {
                textBoxParamMinusA.Visible = true;
                textBoxParamMinusB.Visible = false;
                labelparamMinusA.Visible = true;
                labelparamMinusB.Visible = false;
                labelparamMinusA.Text = "параметр n";
                //labelparamMinusB.Text = "параметр n2"; 
            }
            if (comboBoxRozpodilMinus.SelectedItem.ToString() == "Фішера")
            {
                textBoxParamMinusA.Visible = true;
                textBoxParamMinusB.Visible = true;
                labelparamMinusA.Visible = true;
                labelparamMinusB.Visible = true;
                labelparamMinusA.Text = "параметр n1";
                labelparamMinusB.Text = "параметр n2"; 
            }
        }
        public double Function(double u, int x)
        {
            double res;
            res = Math.Pow((u + x),3) - x*x;
            return res;
        }
        public double Nabla(double u, int x,int i, double u1, int x1)
        {
            double res,b;
            b = 1 / Math.Pow((Time[i]),(1/4));
            res = (Function(u + b, x) - Function(u1 - b, x1)) / (2 * b);
            return res;
        }
        private void PSO()
        {
            Array.Clear(GradTime,0,GradETime.Length);
            Array.Clear(PSOTime,0,PSOTime.Length);
            for (int i = 1; i < n; i++)
            {
                GradTime[i] = Nabla(PSOTime[i + 1], PoslidStaniv[i + 1], i, PSOTime[i - 1], PoslidStaniv[i - 1]);
                PSOTime[i] = PSOTime[i - 1] - (1 / Time[i]) * GradTime[i];
            }
        }
        private void PSOn()
        {
            Array.Clear(GradTime, 0, GradETime.Length);
            Array.Clear(PSOTime, 0, PSOTime.Length);
            for (int i = 1; i < n; i++)
            {
                GradTime[i] = Nabla(PSOTime[i + 1], PoslidStaniv[i + 1], i, PSOTime[i - 1], PoslidStaniv[i - 1]);
                PSOTime[i] = PSOTime[i - 1] - (1 / Time[i]) * GradTime[i];
            }
        }
        private void Evol()
        {
            for (int i = 1; i <= n; i++)
            {
                GradETime[i] = 0;
                EvolTime[i] = 0;
            }
            //EvolTime[0] = 1.2;
            for (int i = 0; i < n-1; i++)
            {
                //GradETime[i] = Nabla(EvolTime[i + 1], 0, i, EvolTime[i - 1], 0);
                EvolTime[i] = Function(i, 0);// +(1 / Time[i]) * GradETime[i];
            }
        }
        private void EvolZbur()
        {
            Array.Clear(GradETime, 0, GradETime.Length);
            Array.Clear(EvolTime,0,EvolTime.Length);
            //EvolTime[0] = 1.2;
            for (int i = 0; i < n - 1; i++)
            {
                EvolTimeZbur[i] = Function(i, PoslidStaniv[i]);// +(1 / Time[i]) * GradETime[i];
            }
        }
        private void comboBoxRozpodilPlus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRozpodilPlus.SelectedItem.ToString() == "Рівномірний")
            {
                textBoxParamPlusA.Visible = true;
                textBoxParamPlusB.Visible = true;
                labelParamPlusA.Visible = true; 
                labelParamPlusB.Visible = true;
                labelParamPlusA.Text = "параметр a";
                labelParamPlusB.Text = "параметр b";
                
            }

            if (comboBoxRozpodilPlus.SelectedItem.ToString() == "Експоненційний")
            {
                textBoxParamPlusA.Visible = true;
                labelParamPlusA.Text = "інтенсивність";
                textBoxParamPlusB.Visible = true;
                labelParamPlusA.Visible = true;
                labelParamPlusB.Visible = true;
                labelParamPlusB.Text = "параметр зсуву";

            }
            if (comboBoxRozpodilPlus.SelectedItem.ToString() == "розподіл Вейбула")
            {
                textBoxParamPlusA.Visible = true;
                textBoxParamPlusB.Visible = true;
                labelParamPlusA.Visible = true;
                labelParamPlusB.Visible = true;
                labelParamPlusA.Text = "параметр a";
                labelParamPlusB.Text = "параметр b";

            }
            if (comboBoxRozpodilPlus.SelectedItem.ToString() == "Нормальний розподіл")
            {
                labelParamPlusA.Visible = true;
                labelParamPlusB.Visible = true;
                textBoxParamPlusA.Visible = true;
                textBoxParamPlusB.Visible = true;
                labelParamPlusA.Text = "мат. сподівання";
                labelParamPlusB.Text = "сер. квадрат. відхил.";

            }

        }

        private void labelparametrMinusB_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxRozpodilMinus_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxPerehid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPerehid.SelectedItem.ToString() == "Матриця переходів")
            {
                groupBoxMatrixPereh.Visible = true;
            }
            if (comboBoxPerehid.SelectedItem.ToString() == "Послідовний (0,1,-1)")
            {
                groupBoxMatrixPereh.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //start distribution
            double[] StartDistribution = new double[3];
            //elements of masive describes accumulated time of process
            double[] GeneralTime = new double[Convert.ToInt32(textBox1.Text)];
            //transition matrix
            double[,] MatrixofSwitchings = new double[3, 3];
            
            
            //Initialization matrix of switchings and start distribution vector
            M2.Classes.InitializationClass Initialization = new M2.Classes.InitializationClass();
            Initialization.InitTransitionMatrix(MatrixofSwitchings);
            Initialization.InitializeStartDistribution(StartDistribution);

            //matrix contains elements (state value; time being in state)
            double[,] matrixOfProcess = new double[Convert.ToInt32(textBox1.Text),2];

            //Creating of the distribution objects for every state
            StateClass State = new StateClass();
            DistributionClass DistributionMinus = new DistributionClass(Convert.ToDouble(textBoxParamMinusA.Text), Convert.ToDouble(textBoxParamMinusB.Text), comboBoxRozpodilMinus.SelectedItem.ToString(), State.StateValue);
            DistributionClass DistributionZero = new DistributionClass(Convert.ToDouble(textBoxParamNullA.Text), Convert.ToDouble(textBoxParamNullB.Text), comboBoxRozpodilNull.SelectedItem.ToString(), State.StateValue);
            DistributionClass DistributionPlus = new DistributionClass(Convert.ToDouble(textBoxParamPlusA.Text), Convert.ToDouble(textBoxParamPlusB.Text),comboBoxRozpodilPlus.SelectedItem.ToString(),State.StateValue);
            //Generator of Random Numbers
            Random rnd = new Random();                  
            
            //Generating first state and time being in it
            State.StateValue = State.FirstStateChoice(StartDistribution, rnd.NextDouble());
            matrixOfProcess[0, 0] = State.StateValue;
            if (State.StateValue == -1)
            {
                DistributionMinus.realRnd1 = rnd.NextDouble();
                matrixOfProcess[0, 1] = DistributionMinus.DistributionChoice();
            }
            if (State.StateValue == 0)
            {
                DistributionZero.realRnd1 = rnd.NextDouble();
                matrixOfProcess[0, 1] = DistributionZero.DistributionChoice();
            }
            if (State.StateValue == 1)
            {
                DistributionPlus.realRnd1 = rnd.NextDouble();
                matrixOfProcess[0, 1] = DistributionPlus.DistributionChoice();
            }
            
            //Generating all states and time being in everyone of them
            for (int i = 1; i < Convert.ToInt32(textBox1.Text); i++)
            {
                State.StateValue = State.Switch(MatrixofSwitchings, rnd.NextDouble());
                matrixOfProcess[i, 0] = State.StateValue;
                if (State.StateValue == -1)
                {
                    DistributionMinus.realRnd1 = rnd.NextDouble();
                    matrixOfProcess[i, 1] = DistributionMinus.DistributionChoice();
                }
                if (State.StateValue == 0)
                {
                    DistributionZero.realRnd1 = rnd.NextDouble();
                    matrixOfProcess[i, 1] = DistributionZero.DistributionChoice();
                }
                if (State.StateValue == 1)
                {
                    DistributionPlus.realRnd1 = rnd.NextDouble();
                    matrixOfProcess[i, 1] = DistributionPlus.DistributionChoice();
                }
            }

            //Creating table that contains states and time in them
            ProcessClass PC = new ProcessClass();
            GeneralTime = ProcessModeling.Classes.ProcessClass.Accumulation(matrixOfProcess);
            M2.Classes.TableClass Table = new M2.Classes.TableClass();
            Table.colls = Convert.ToInt32(textBox1.Text);
            Table.rows = 2;
            Table.CreateTable(matrixOfProcess, dataGridView1);

            //Creating graphs
            M2.Classes.GraphConsructingClass GraphProcess = new M2.Classes.GraphConsructingClass();
            GraphProcess.DrawProcess(zedGraph, matrixOfProcess, GeneralTime);
            GraphProcess.DrawStateDistribution(zedGraphMinus1, PC.State(matrixOfProcess,-1));
            GraphProcess.DrawStateDistribution(zedGraphNull, PC.State(matrixOfProcess, 0));
            GraphProcess.DrawStateDistribution(zedGraphPlus1, PC.State(matrixOfProcess, 1));

            double[,] SOPMatrix;
            PoslidStaniv = ProcessModeling.Classes.ProcessClass.SequenceOfStates(matrixOfProcess);
            string Equation = textBoxFunction.Text;

            //string func = "(1/t)/(2*(1/t^(1/4)))*((u+(1/t^(1/4))+(" + Convert.ToString(PoslidStaniv[i + 1]) + "))^2-(u-(1/t^(1/4))+(" + Convert.ToString(PoslidStaniv[i + 1]) + "))^2)";
            if (checkBoxSOP.Checked)
            {
                M2.Classes.SOPClass SOP = new M2.Classes.SOPClass();
                SOPMatrix = SOP.StochOptimProcedure(matrixOfProcess, Equation);

                GraphProcess.DrawSOProcedure(zedGraphPSO, SOPMatrix);
                //GraphProcess.DrawEvolution(zedGraphPSO, matrixOfProcess);
            }
            GraphProcess.DrawEvolution(zedGraphEvol, matrixOfProcess);
            //GraphProcess.DrawEvolution(zedGraphPSO, matrixOfProcess);

                           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxP12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxP11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
        
}

