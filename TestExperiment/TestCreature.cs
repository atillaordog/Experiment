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
                this.knowledgestack.Remove(this.knowledgestack[0]);
            }
        }

        public override void doAction()
        {
            if (this.environment.getSize()[0] >= this.location.x + 1 
                && this.energy > 0
                && !this.environment.getPosition(this.location.x+1, this.location.y).getIsCreature())
            {
                this.environment.getPosition(this.location.x, this.location.y).resetCreature();
                
                this.location.x++;
                
                this.environment.addCreatureToPosition(this.location.x, this.location.y, this);

                if (this.environment.getPosition(this.location.x, this.location.y).getIsKnowledge())
                {
                    this.gatherKnowledge(this.environment.getPosition(this.location.x, this.location.y).getKnowledge());
                }

                this.energy--;
            }

            this.useKnowledge();

            Console.SetCursorPosition(this.location.x, this.location.y);
            Console.Write(this.energy);
        }
    }
}
