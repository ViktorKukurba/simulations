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
        public abstract List<MLVPoint> Generate(double start, double finish, double a, double b, double c, double d, double nStart, double pStart);
        public abstract List<MLVPoint> SAPProcess(double start, double finish, double a, double b, double c, double d, double nStart, double pStart, double alpha);
    }

    /// <summary>
    /// Python used for simulation
    /// </summary>
    public class PyLVSimulation : LVSimulation
    {
        public override List<MLVPoint> Generate(double start, double finish, double a, double b, double c, double d, double nStart, double pStart)
        {
            var options = new Dictionary<string, object>();
            options["Frames"] = true;
            options["FullFrames"] = true;
            var ipy = Python.CreateRuntime(options);
            dynamic test = ipy.UseFile("..\\..\\Python\\test.py");
            var t = test.LotkaVolterra(start, finish, a, b, c, d, nStart,pStart);
            var list = new List<MLVPoint>();
            var length2 = ((Array)t[0]).Length; //temp.Array; //t.NumberOfElements;
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

        public override List<MLVPoint> SAPProcess(double start, double finish, double a, double b, double c, double d, double nStart, double pStart, double alpha)
        {
            throw new NotImplementedException();
        }
    }
    /// <summary>
    /// MatLab Lib is used for simulations
    /// </summary>
    public class MatLabLVSimulation: LVSimulation
    {
        public override List<MLVPoint> Generate(double start, double finish, double a, double b, double c, double d, double nStart, double pStart)
        {
            var lotka = new ModelLotkaVolterra.LotkaVolterra();
            var tspan = new double[] { start, finish };
            var tspan1 = new double[] { nStart, pStart };
            var mwtspan = new MWNumericArray(tspan);
            var mwtspan2 = new MWNumericArray(tspan1);
            var mwArrayOut = lotka.MLV(2, mwtspan, mwtspan2,a,b,c,d);
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

        public override List<MLVPoint> SAPProcess(double start, double finish, double a, double b, double c, double d, double nStart, double pStart, double alpha = 1.00)
        {
            var lotka = new ModelLotkaVolterra.LotkaVolterra();
            var tspan = new double[] { start, finish };
            var tspan1 = new double[] { nStart, pStart };
            var mwtspan = new MWNumericArray(tspan);
            var mwtspan2 = new MWNumericArray(tspan1);
            var mwArrayOut = lotka.MLV_SAP(2, mwtspan, mwtspan2, a, b, c, d, alpha);
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
