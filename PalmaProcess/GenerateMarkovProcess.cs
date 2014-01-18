using System;
using System.Collections.Generic;
using System.Linq;
using ProcessModeling.Classes;

namespace M2
{
    public class GenerateMarkovProcess
    {
        public static double GenerateMarkovP(List<double> testResults)
        {
            var n = testResults.Count;
            var k = 1+3.222*Math.Log10(n);
            testResults.RemoveRange(0,n-(int)k);
            var mt = 1/testResults.Average();
            Random x = new Random();
            DistributionClass distributionClass = new DistributionClass(mt, 0, "Експоненційний", x.NextDouble());
            var me = distributionClass.Exponential(1,0);
            return me;
        }
    }
}
