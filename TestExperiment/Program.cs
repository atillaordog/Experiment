using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TestExperiment
{
    class Program
    {
        static void Main(string[] args)
        {
            TestExperiment experiment = new TestExperiment();
            experiment.setUpEnvironment();
            experiment.run();

            Console.ReadKey(true);

            Console.ReadKey();
        }
    }
}
