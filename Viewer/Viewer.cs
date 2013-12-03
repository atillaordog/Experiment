using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Experiment;

namespace Viewer
{
    public class Viewer
    {
        public int creatureSize = 5;
        public int KnowledgeSize = 5;
        public int envWidth = 0;
        public int envHeight = 0;

        protected Experiment.Experiment experiment;

        public void attachToExperiment(Experiment.Experiment e)
        {
            this.experiment = e;
        }

        public void calculateSizes()
        {
            int width = this.experiment.environment.getSize()[0], height = this.experiment.environment.getSize()[1];

            int objectSize = 0;
            if (this.creatureSize > this.KnowledgeSize)
            {
                objectSize = this.creatureSize;
            }
            else
            {
                objectSize = this.KnowledgeSize;
            }

            this.envWidth = width * (objectSize + 1);
            this.envHeight = height * (objectSize + 1);
            
        }

        public Experiment.Experiment getExperiemnt()
        {
            return this.experiment;
        }
    }
}
