using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Experiment
{
    abstract public class Experiment
    {
        abstract public void setUpEnvironment();
        abstract public void run();
    }
}
