using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Experiment;
using System.Threading;

namespace TestExperiment
{
    class TestExperiment : Experiment.Experiment
    {
        Experiment.Environment environment;

        override public void setUpEnvironment()
        {
            this.environment = new Experiment.Environment();

            this.environment.setSize(20, 20);
            this.environment.initialize();

            for (int i = 0; i < 20; i++)
            {
                TestCreature c = new TestCreature(i);
                c.setEnergy(10);
                this.environment.addCreatureToPosition(0, i, c);
            }
            Random rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                this.environment.addKnowledgeToPosition(rand.Next(2, 19), rand.Next(2, 19), new TestKnowledge());
            }
        }

        override public void run()
        {
            TestOutputter outputter = new TestOutputter();
            int counter = 19;
            while (counter > 0)
            {
                // Check if there is creature left with any energy or a creature got to the end
                bool is_energy_left = false, is_finished = false;

                for (int i = 0, m = this.environment.getPositions().Count; i < m; i++)
                {
                    if (this.environment.getPositions()[i].getIsCreature())
                    {
                        if (this.environment.getPositions()[i].getCreature().getEnergy() > 0)
                        {
                            is_energy_left = true;
                        }

                        if (this.environment.getPositions()[i].getCreature().getLocation().x == 19)
                        {
                            is_finished = true;
                        }
                    }
                }
               
                if (!is_energy_left || is_finished)
                {
                    Console.SetCursorPosition(this.environment.getSize()[0] + 1, this.environment.getSize()[1] + 1);
                    Console.WriteLine("Experiment finished");
                    break;
                }
                else
                {
                    outputter.passEnvironment(this.environment);
                    outputter.write();
                    this.environment.doOneStepProcedural();
                }

                counter--;
            }
        }
    }
}
