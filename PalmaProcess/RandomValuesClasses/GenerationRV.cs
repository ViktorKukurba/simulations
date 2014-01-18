using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace ProcessModeling.RandomValuesClasses
{
    public class GenerationRV
    {
        public List<double> RandomValuesList { get; private set; }
        public double GenPoissonRandomValue(double a, int k, double m)
        { 
            var result = Math.Round(- m * Math.Log(a) / k);
            return result;
        }

        public List<double> GenPoissonValues(int n, double m, int r)
        {
            List<double> t = new List<double>();
            Random x = new Random();

            for (int i = r; i < n; i++)
            {
                t.Add(GenPoissonRandomValue(x.NextDouble(), i + 1, m));
            }
            return t;
        }
    }
}
