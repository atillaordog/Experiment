using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Experiment;

namespace TestExperiment
{
    class TestKnowledge : Experiment.Knowledge
    {
        public override void use()
        {
            this.creature.increaseEnergy();
        }
    }
}
