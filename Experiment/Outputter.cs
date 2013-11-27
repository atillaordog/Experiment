using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Experiment
{
    public abstract class Outputter
    {
        protected Environment e;

        public void passEnvironment(Environment e)
        {
            this.e = e;
        }

        abstract public void write();
    }
}
