using System;
using System.Collections.Generic;
using System.Linq;
using ExplorationTestResults;

namespace M2.ChiSquare
{
    public class ChiSquareMethod
    {
        private TestIterationsService _testService;
        public ChiSquareMethod()
        {
            _testService = new TestIterationsService();
        }
        public bool ProofChiSquare(int testId)
        {
            double chiEmp;
            double chiTeor;
            testId = 330;
            List<TestIteration> results = _testService.GetTestIterationsByTestID(testId);
            int k = results.Count - (int)(1+3.222*Math.Log10(results.Count));
            int t = 0;
            do
            {
                List<TestIteration> empiricalResults = results.Where(i=>i.Iteration>=t).ToList();
                double sumErrors = (double) (from ir in empiricalResults
                                             select ir.Iteration*ir.ErrorsCount).Sum();
                double parLambda = (double)empiricalResults.Select(i => i.ErrorsCount).Sum() / empiricalResults.Count;
                //sumErrors / (double)empiricalResults.Select(i => i.ErrorsCount).Sum();
                //var emp = empiricalResults.Select(i => i.ErrorsCount).Sum();
                List<double> theoreticalResults = GetTheoreticalDistribution(parLambda, empiricalResults.Count, t,
                                                                             (double)
                                                                             empiricalResults.Select(i => i.ErrorsCount)
                                                                                 .Sum());
                chiEmp = GetChiEmpirical(theoreticalResults,
                                                empiricalResults.Select(i => (double) i.ErrorsCount).ToList());
                int stepSvb = empiricalResults.Count - 2;
                chiTeor = GetChiTheor(stepSvb);
                t += 1;
            }while(chiEmp > chiTeor && t < results.Count);
            var r = results.Where(i => i.Iteration >= t).ToList();
            return chiEmp<chiTeor;
        }

        public double GetChiEmpirical(List<double> theoretical, List<double> empirical)
        {
            double chiEmp = 0;
            for (int i = 0; i < theoretical.Count; i++)
            {
                chiEmp += Math.Pow((theoretical[i]-empirical[i]),2);
            }
            return chiEmp;
        }

        public List<double> GetTheoreticalDistribution(double lambda, int n, int startNumber, double sumErrors)
        {
            List<double> list = new List<double>();
            for (int i = 0; i < n; i++)
            {
                double p = (double)(Math.Pow(lambda, i)) / Factorial(i) * Math.Exp(-lambda) * sumErrors;
                p = (double.IsInfinity(p) || double.IsNaN(p)) ? 0 : p;
                list.Add(p);
            }
            var s = list.Sum();
                return list;
        }

        public double GetChiTheor( int stepSvob)
        {
            switch (stepSvob)
            {
                case 1: return 0.00393;
                case 2: return 0.00393;
                case 3: return 0.00393;
                case 4: return 0.00393;
                case 5: return 0.00393;
                case 6: return 0.00393;
                case 7: return 0.00393;
                case 8: return 0.00393;
                case 9: return 0.00393;
                case 10: return 0.00393;
                case 11: return 0.00393;
                case 12: return 0.00393;
                default: return stepSvob + 2 * Math.Sqrt(2*stepSvob);
            }
        }

        static double Factorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * Factorial(n - 1);
        }
    }
}
