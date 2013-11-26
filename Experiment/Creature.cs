using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Experiment
{
    abstract public class Creature
    {
        protected Location location;

        protected List<Knowledge> knowledgestack;

        protected int energy = 0;

        protected int id = 0;

        protected Environment environment;

        public Creature(int id)
        {
            this.id = id;

            this.location = new Location();
            this.knowledgestack = new List<Knowledge>();
        }

        public int getId()
        {
            return this.id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public void setLocation(Location l)
        {
            this.location = l;
        }

        public Location getLocation()
        {
            return this.location;
        }

        public void gatherKnowledge(Knowledge k)
        {
            this.knowledgestack.Add(k);
        }

        abstract public void useKnowledge();

        public int getEnergy()
        {
            return this.energy;
        }

        public void setEnergy(int e)
        {
            this.energy = e;
        }

        public void increaseEnergy()
        {
            this.energy++;
        }

        public void decreaseEnergy()
        {
            if (this.energy > 0)
            {
                this.energy--;
            }
        }

        public bool deleteKnowledge(int id)
        {
            for (int i = 0, m = this.knowledgestack.Count; i < m; i++)
            {
                if (this.knowledgestack[i].getId() == id)
                {
                    this.knowledgestack.Remove(knowledgestack[i]);
                    return true;
                }
            }

            return false;
        }

        public void passEnvironment(Environment e)
        {
            this.environment = e;
        }

        abstract public void doAction();
    }
}
