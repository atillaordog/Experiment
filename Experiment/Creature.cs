using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Experiment
{
    abstract class Creature
    {
        protected Location location;

        protected List<Knowledge> knowledgestack;

        protected int energy = 0;

        Creature()
        {
            this.location = new Location();
            this.knowledgestack = new List<Knowledge>();
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
    }
}
