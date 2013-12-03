using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Experiment
{
    abstract public class Experiment
    {
        public bool experimentRuns = false;

        public Environment environment;

        abstract public void setUpEnvironment();
        abstract public void run();
    }
}
