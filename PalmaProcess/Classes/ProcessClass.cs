using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProcessModeling.Classes
{
    class ProcessClass
    {
        // returns massive wich elements are sums of previous a[i]=b[i-1]+b[i]
        public static double[] Accumulation(double[,] Matrix)
        {
            double[] result=new double[Matrix.Length/2+1];
            result[0] = 0;
            for (int i=1; i <= Matrix.Length/2; i++)
            {
                result[i] = result[i-1]+Matrix[i-1, 1];
            }
           
            return result;
        }
        // returns matrix of elements that describes only one state
        public double[,] State(double[,] Matrix, int state)
        {
            int k=0,t=0;
            for (int i = 0; i < Matrix.Length/2; i++)
            {
                if (Matrix[i, 0] == state) k++;
            }
            double[,] resalt = new double[k+1,2];
            for (int i = 0; i < Matrix.Length/2; i++)
            {
                if (Matrix[i, 0] == state) 
                {
                    t++;
                    resalt[t,0] = Matrix[i, 0];
                    resalt[t, 1] = Matrix[i, 1];

                }
            }
            return resalt;
        }

        // increase length of double massive
        public static double[] IncreaseLength(double[] arr, int delta)
        {
            double[] tmp = new double[arr.Length + delta];
            Array.Copy(arr, 0, tmp, 0, arr.Length);
            arr = tmp;
            return tmp;
        }

        public static int[] SequenceOfStates(double[,] Matrix)
        {
            int[] result = new int[Matrix.Length / 2];
            for (int i = 0; i < Matrix.Length / 2; i++)
            {
                result[i] =Convert.ToInt32(Matrix[i, 0]);
            }
            return result;
        }
        // returns Sum of second row in matrix
        public double MatrixSum(double[,] Matrix)
        {
            double result = 0;
            double[] massive = new double[Matrix.Length/2];
            for (int i = 0; i < Matrix.Length / 2; i++)
            {
                result = result+Matrix[i, 1];

            }
            return result;
        }
        //public int AmountofSwitchings;
        public double[] StartDistribution = new double[3];
       /* public double[,] MatrixofSwitchings = new double[3, 3];
        public double[,] Process(int AmountofSwitchings)
        {
            int s=0;

            StateClass StateMinusOne = new StateClass();
            StateClass StateZero = new StateClass();
            StateClass StatePlusOne = new StateClass();
 /*           StateClass.State Stan = new StateClass.State();
            StateMinusOne.Rozpodil.a=Convert.ToDouble(1);
            StatePlusOne.Rozpodil.a = Convert.ToDouble(1);
            StateZero.Rozpodil.a=Convert.ToDouble(1);
            StateMinusOne.Rozpodil.b=Convert.ToDouble(0);
            StatePlusOne.Rozpodil.b=Convert.ToDouble(0);
            StateZero.Rozpodil.b=Convert.ToDouble(0);
            double[,] MatrixProcess = new double[1000, 3];
            Random rnd = new Random();
            if (rnd.NextDouble() < StartDistribution[0]) Stan = StateClass.State.MinusOne;
            else if (rnd.NextDouble() < StartDistribution[1]) Stan = StateClass.State.Zero;
            else Stan = StateClass.State.PlusOne;

            for (int i = 0; i < AmountofSwitchings; i++)
            {
                if (Stan == StateClass.State.MinusOne) { s = 0; MatrixProcess[i, 0] = DistributionChoice(StateMinusOne); MatrixProcess[i, 1] = 0; MatrixProcess[i, 2] = 0; Stan = StateMinusOne.Switch(); }
                else if (Stan == StateClass.State.Zero) { s = 1; MatrixProcess[i, 1] = DistributionChoice(StateZero); MatrixProcess[i, 0] = 0; MatrixProcess[i, 2] = 0; Stan = StateZero.Switch(); }
                else if (Stan == StateClass.State.PlusOne) { s = 2; MatrixProcess[i, 2] = DistributionChoice(StatePlusOne); MatrixProcess[i, 0] = 0; MatrixProcess[i, 1] = 0; Stan = StatePlusOne.Switch(); }
                   //MatrixProcess[i, s] = DistributionChoice();                
            }

                return MatrixProcess;
        }
        private double DistributionChoice(StateClass State)
        {
            State.DistributionName = "Експоненційний";
                   double x = 0;
                   if (State.DistributionName == "Рівномірний")
                       x = State.Rozpodil.Rivnomirnuj(State.Rozpodil.a, State.Rozpodil.b);

                   if (State.DistributionName == "Експоненційний")
                       x = State.Rozpodil.Exponential(State.Rozpodil.a, State.Rozpodil.b);

                   if (State.DistributionName == "розподіл Вейбула")
                       x = State.Rozpodil.RVejbyla(State.Rozpodil.a, State.Rozpodil.b);

                   if (State.DistributionName == "Нормальний розподіл")
                       x = State.Rozpodil.RNormal(State.Rozpodil.a, State.Rozpodil.b);

                   if (State.DistributionName == "Логарифмічно нормальний")
                       x = State.Rozpodil.RLogNorm(State.Rozpodil.a, State.Rozpodil.b);

                   if (State.DistributionName == "Ерланга")
                       x = State.Rozpodil.RErlang(State.Rozpodil.a, State.Rozpodil.b);

                   if (State.DistributionName == "хі-квадрат")
                       x = State.Rozpodil.RHiKvadrat(State.Rozpodil.a);

                   if (State.DistributionName == "розподіл Релея")
                       x = State.Rozpodil.RReleja(State.Rozpodil.a);

                   if (State.DistributionName == "Стьюдента")
                       x = State.Rozpodil.RStudenta(State.Rozpodil.a);

                   if (State.DistributionName == "Фішера")
                       x = State.Rozpodil.RFischera(State.Rozpodil.a, State.Rozpodil.b);

                   if (State.DistributionName == "Бета-розподіл")
                       x = State.Rozpodil.RBeta(State.Rozpodil.a, State.Rozpodil.b);
                   return x;
    */


    }
    }
