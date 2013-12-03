using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Experiment;
using System.Threading;

namespace TestExperiment
{
    public class TestExperiment : Experiment.Experiment
    {
        override public void setUpEnvironment()
        {
            this.environment = new Experiment.Environment();

            this.environment.setSize(100, 100);
            this.environment.initialize();

            for (int i = 0; i < 100; i++)
            {
                TestCreature c = new TestCreature(i);
                c.setEnergy(19);
                this.environment.addCreatureToPosition(0, i, c);
            }
            Random rand = new Random();
            for (int i = 0; i < 5000; i++)
            {
                TestKnowledge k = new TestKnowledge();
                k.setId(i);

                this.environment.addKnowledgeToPosition(rand.Next(0, 99), rand.Next(0, 99), k);
            }
        }

        override public void run()
        {
            this.experimentRuns = true;

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

                        if (this.environment.getPositions()[i].getCreature().getLocation().x == 99)
                        {
                            is_finished = true;
                        }
                    }
                }
               
                if (!is_energy_left || is_finished)
                {
                    /*Console.SetCursorPosition(this.environment.getSize()[0] + 1, this.environment.getSize()[1] + 1);
                    Console.WriteLine("Experiment finished");*/
                    break;
                }
                else
                {
                   // outputter.passEnvironment(this.environment);
                   // outputter.write();
                    this.environment.doOneStepProcedural();
                    Thread.Sleep(200);
                   
                }

                //counter--;
            }

            this.experimentRuns = false;
        }
    }
}
