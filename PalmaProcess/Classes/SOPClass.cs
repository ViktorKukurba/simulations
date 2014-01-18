using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;
using Ode1;
using System.Collections;

namespace M2.Classes
{
    class SOPClass
    {
        public static double Function(double u, int x)
        {
            double res;
            res = Math.Log10(u + x);
            return res;
        }
       /* public double Nabla(double u, double Time, int i)
        {
            double res, b;
            int x = PoslidStaniv[i];
            b = 1 / Math.Pow((Time), (1 / 4));
            res = (1 / Time) * (Function(u + b, x) - Function(u - b, x)) / (2 * b);
            return res;
        }*/
       /* private void PSO()
        {
            Array.Clear(GradTime, 0, GradETime.Length);
            Array.Clear(PSOTime, 0, PSOTime.Length);
            PSOTime[0] = 1.2;
            for (int i = 1; i < n; i++)
            {
                GradTime[i] = Nabla(PSOTime[i], Time[i], i);
                PSOTime[i] = PSOTime[i - 1] - (1 / Time[i]) * GradTime[i];
            }
        }*/
        public double[,] StochOptimProcedure(double[,] Matrix, string func)
        {
            double[] PSOTime = new double[Matrix.Length/2];
            double[] PSOResult = new double[Matrix.Length/2];
            double[] PSOTime1 = new double[Matrix.Length / 2];
            double[] PSOResult1 = new double[Matrix.Length / 2];

            double[] GradTime = new double[Matrix.Length];
            double[] Time;
            int[] PoslidStaniv;
            double[] tspan = new double[2];
            string st0, st1, su0, function="";
            int amountOfX=0;
            for (int i = 0; i < func.Length; i++)
            {
                if (func[i] == 'x') amountOfX++;
            }        

            MWArray[] mwArrayOut = null;
            MWNumericArray mwT1 = null;
            MWNumericArray mwY1 = null;
            MWNumericArray SmwT1 = null;
            MWNumericArray SmwY1 = null;
            Array.Clear(GradTime, 0, GradTime.Length);
            Array.Clear(PSOTime, 0, PSOTime.Length);
            PSOTime[0] = 0;
            double a, b;
            int k = 1;
            ProcessModeling.Classes.ProcessClass PC = new ProcessModeling.Classes.ProcessClass();
            Time = ProcessModeling.Classes.ProcessClass.Accumulation(Matrix);
            double u0 = Convert.ToDouble(PSOTime[0]);
            u0 = 0.5;
            PSOResult[0] = u0;
            PSOTime1[0] = 0;
            //func = textBoxFunc.Text;
            Ode1Class obj = new Ode1Class();
            double t0, t1;
            PoslidStaniv = ProcessModeling.Classes.ProcessClass.SequenceOfStates(Matrix);
            Time[0]=0.001;
            for (int i = 0; i <Matrix.Length/2-1; i++)
            {

                t0 = Convert.ToDouble(Time[i]);
                t1 = Convert.ToDouble(Time[i + 1]);

                tspan[0] = t0;
                tspan[1] = t1;

                a = 1 / Time[i];
                b = 1 / Math.Pow(Time[i], (0.25));
                for(int j = 0;j<amountOfX;j++)
                {
                    function += func.Split('x')[j] + Convert.ToString(PoslidStaniv[i + 1]);
                }
                function += func.Split('x')[amountOfX];

                //func = a.ToString(CultureInfo.InvariantCulture) + "/(2*" + b.ToString(CultureInfo.InvariantCulture) + ")*((u+" + b.ToString(CultureInfo.InvariantCulture) + "+(" + Convert.ToString(PoslidStaniv[i+1]) + "))^2-";
                //func += "(u-" + b.ToString(CultureInfo.InvariantCulture) + "+(" + Convert.ToString(PoslidStaniv[i+1]) + "))^2)";
      //func = "(1/t)/(2*(1/t^(1/4)))*((u+(1/t^(1/4))+(" + Convert.ToString(PoslidStaniv[i + 1]) + "))^2-(u-(1/t^(1/4))+(" + Convert.ToString(PoslidStaniv[i + 1]) + "))^2)";
                //func += "(u-" + "(1/t^(1/4))" + "+(" + Convert.ToString(PoslidStaniv[i]) + "*(-1)))^2)";
                //func = "(1/t) *((u+" + "t" + "))^2";
                //func += "(u-" + "(1/t^(1/4))" + "+(" + Convert.ToString(PoslidStaniv[1]) + "))^2)";
                MWCharArray mw_strfunc = new MWCharArray(function);
                MWNumericArray mw_tspan = new MWNumericArray(tspan);

              //  t0 = Time[i];
              //  t1 = Time[i + 1];
                u0 = PSOResult1[k - 1];//Function(PSOTime1[k], PoslidStaniv[i + 1]);//PSOResult[i];

                MWCharArray mwstrfunc = new MWCharArray(function.ToString());

               // tspan[0] = t0;
               // tspan[1] = t1;

                MWNumericArray mwtspan = new MWNumericArray(tspan);

                //textBoxFunc.Text = func;
                //func="0.0223065921057307/(2*0.386463343154655)*((u+0.386463343154655+(1))^2-(u-0.386463343154655+(1))^2)";
                mwArrayOut = obj.ode45_1(2, mwstrfunc, mwtspan, u0);

                mwT1 = (MWNumericArray)mwArrayOut[0];
                mwY1 = (MWNumericArray)mwArrayOut[1];
                PSOTime = (double[])mwT1.ToVector(MWArrayComponent.Real);
                PSOResult = (double[])mwY1.ToVector(MWArrayComponent.Real);
                PSOTime1=ProcessModeling.Classes.ProcessClass.IncreaseLength(PSOTime1, PSOTime.Length);
                PSOResult1=ProcessModeling.Classes.ProcessClass.IncreaseLength(PSOResult1, PSOResult.Length);
                //textBoxFunc.Text = (PSOTime.Max()).ToString();
                PSOTime.CopyTo(PSOTime1, k);
                //textBoxu0.Text = (PSOResult.Max()).ToString();
                PSOResult.CopyTo(PSOResult1, k);
                k += PSOResult.Length;
                function = "";
            }
            double[,] SOPMatrix = new double[PSOResult1.Length, 2];
            for (int i = 0; i < PSOResult1.Length; i++)
            {
                SOPMatrix[i, 0] = PSOResult1[i];
                SOPMatrix[i, 1] = PSOTime1[i];
            }
                //obj.myplot(mwT1, mwY1);
            //double[] native1 = (double[])mwT1.ToArray();
            //double[] native2 = (double[])mwT1.ToArray(MWArrayComponent.Real);
            return SOPMatrix;
        }


    }
}
