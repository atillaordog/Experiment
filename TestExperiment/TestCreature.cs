using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Experiment;

namespace TestExperiment
{
    class TestCreature : Experiment.Creature
    {
        public TestCreature(int id) : base(id)
        {
            
        }

        public override void useKnowledge()
        {
            // Find knowledge to use
            if (this.knowledgestack.Count > 0)
            {
                this.knowledgestack[0].passCreature(this);
                this.knowledgestack[0].use();
            }
        }

        public override void doAction()
        {
            if (this.environment.getSize()[0] >= this.location.x + 1 && this.environment.getPosition(this.location.x, this.location.y).getIsCreature())
            {
                Position p = this.environment.getPosition(this.location.x, this.location.y);
                p.resetCreature();

                p = this.environment.getPosition(this.location.x + 1, this.location.y);
                p.setCreature(this);

                this.location.x++;

                if (p.getIsKnowledge())
                {
                    this.gatherKnowledge(p.getKnowledge());
                }
            }

            this.useKnowledge();

            Console.WriteLine("Creature ID."+this.id+" is on position "+this.location.x+"x"+this.location.y+" with energy level: "+this.energy);
        }
    }
}
