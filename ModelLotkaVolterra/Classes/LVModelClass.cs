using System;
using System.Collections.Generic;
using IronPython.Hosting;
using MathWorks.MATLAB.NET.Arrays;

namespace LotkaVolterra.Classes
{
        /// <summary>
        /// Describes Model L-V Point
        /// </summary>
        public class MLVPoint
        {
            public double NValue { get; set; }
            public double TimePoint { get; set; }
            public double PValue { get; set; }
        }

    public abstract class LVSimulation
    {
        public abstract List<MLVPoint> Generate(double start, double finish, double a, double b, double c, double d, double nStart, double pStart, double j);
        public abstract List<MLVPoint> SAPProcess(double start, double finish, double a, double b, double c, double d, double nStart, double pStart, double alpha, double j);
    }

    /// <summary>
    /// Python used for simulation
    /// </summary>
    public class PyLVSimulation : LVSimulation
    {
		public PyLVSimulation()
		{
			var options = new Dictionary<string, object>();
			options["Frames"] = true;
			options["FullFrames"] = true;
			var ipy = Python.CreateRuntime(options);
			test = ipy.UseFile("..\\..\\Python\\test.py");
		}
		private dynamic test;
        public override List<MLVPoint> Generate(double start, double finish, double a, double b, double c, double d, double nStart, double pStart, double j)
        {
			//var t = test.LotkaVolterra(start, finish, a, b, c, d, nStart, pStart);
            var t = test.LotkaVolterra();
            var list = new List<MLVPoint>();
			var temp = t[0];
			var temp2 = temp[0];
            var length2 = t[0].Size; //temp.Array; //t.NumberOfElements;
            for (var i = 0; i < length2; i++)
            {
                var psoPoint = new MLVPoint()
                                   {
                                       TimePoint = t[0][i],
                                       NValue = t[1][i],
                                       PValue = t[2][i]
                                   };
                list.Add(psoPoint);
            }
            return list;
        }

        public override List<MLVPoint> SAPProcess(double start, double finish, double a, double b, double c, double d, double nStart, double pStart, double alpha, double j)
        {
            throw new NotImplementedException();
        }
    }
    /// <summary>
    /// MatLab Lib is used for simulations
    /// </summary>
    public class MatLabLVSimulation: LVSimulation
    {
        public override List<MLVPoint> Generate(double start, double finish, double a, double b, double c, double d, double nStart, double pStart, double j)
        {
            var lotka = new MLV2.LotkaVolterra();
            var tspan = new double[] { start, finish };
            var tspan1 = new double[] { nStart, pStart };
            var mwtspan = new MWNumericArray(tspan);
            var mwtspan2 = new MWNumericArray(tspan1);
            var mwArrayOut = lotka.MLV2(2, mwtspan, mwtspan2,a,b,c,d, j);
            var list = new List<MLVPoint>();
            var length = mwArrayOut[0].NumberOfElements;
            for (var i = 0; i < length; i++)
            {
                var psoPoint = new MLVPoint()
                {
                    TimePoint = ((double[])((MWNumericArray)mwArrayOut[0]).ToVector(MWArrayComponent.Real))[i],
                    NValue = ((double[])((MWNumericArray)mwArrayOut[1]).ToVector(MWArrayComponent.Real))[i],
                    PValue = ((double[])((MWNumericArray)mwArrayOut[1]).ToVector(MWArrayComponent.Real))[i + length]
                };
                list.Add(psoPoint);
            }
            return list;
        }

        public override List<MLVPoint> SAPProcess(double start, double finish, double a, double b, double c, double d, double nStart, double pStart, double alpha, double j)
        {
            var lotka = new MLV2.LotkaVolterra();
            var tspan = new double[] { start, finish };
            var tspan1 = new double[] { nStart, pStart };
            var mwtspan = new MWNumericArray(tspan);
            var mwtspan2 = new MWNumericArray(tspan1);
            var mwArrayOut = lotka.MLV_SAP2(2, mwtspan, mwtspan2, a, b, c, d, alpha, j);
            var list = new List<MLVPoint>();
            var length = mwArrayOut[0].NumberOfElements;
            for (var i = 0; i < length; i++)
            {
                var psoPoint = new MLVPoint()
                {
                    TimePoint = ((double[])((MWNumericArray)mwArrayOut[0]).ToVector(MWArrayComponent.Real))[i],
                    NValue = ((double[])((MWNumericArray)mwArrayOut[1]).ToVector(MWArrayComponent.Real))[i],
                    PValue = ((double[])((MWNumericArray)mwArrayOut[1]).ToVector(MWArrayComponent.Real))[i + length]
                };
                list.Add(psoPoint);
            }
            return list;
        }
    }
}
