using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Experiment;

namespace TestExperiment
{
    class TestExperiment : Experiment.Experiment
    {
        Experiment.Environment environment;

        override public void setUpEnvironment()
        {
            this.environment = new Experiment.Environment();

            this.environment.setSize(200, 200);
            this.environment.initialize();

            for (int i = 0; i < 200; i++)
            {
                this.environment.addCreatureToPosition(0, i, new TestCreature(i));
                this.environment.addKnowledgeToPosition(new Random().Next(0, 199), i, new TestKnowledge());
            }
        }

        override public void run()
        {
            this.environment.doOneStepThreaded();
        }
    }
}
