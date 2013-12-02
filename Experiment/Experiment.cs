using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Experiment
{
    abstract public class Experiment
    {
        public static bool experimentRuns = false;

        abstract public void setUpEnvironment();
        abstract public void run();
    }
}
