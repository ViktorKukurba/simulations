using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExplorationTestResults;

namespace M2.DbManager
{
    public class DbManage : BaseService
    {
        private TestIterationsService _testService;
        public DbManage()
        {
            _testService = new TestIterationsService();
        }
        public int SaveInDb(List<double> results)
        {
            var index = 0;
            Test test = new Test()
                            {
                                IsReal = false,
                                TestName = "Generated"
                            };
            test = _testService.InsertOrUpdateTest(test);
            foreach (var result in results)
            {
                TestIteration iteration = new TestIteration()
                                              {
                                                  Iteration = index++,
                                                  TestID = test.ID,
                                                  ErrorsCount = (int)result
                                              };

                _testService.InsertOrUpdateTestIteration(iteration);
            }
            return test.ID;
        }
    }
}
