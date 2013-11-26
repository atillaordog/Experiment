using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Experiment
{
    public class Position
    {
        protected Location location;
        protected bool is_location = false;
        protected Creature creature;
        protected bool is_creature = false;
        protected Knowledge knowledge;
        protected bool is_knowledge = false;

        public void setLocation(Location l)
        {
            this.location = l;
            this.is_location = true;
        }

        public Location getLocation()
        {
            return this.location;
        }

        public void resetLocation()
        {
            this.is_location = false;
        }

        public bool getIsLocation()
        {
            return this.is_location;
        }

        public Creature getCreature()
        {
            return this.creature;
        }

        public void setCreature(Creature c)
        {
            this.creature = c;
            this.is_creature = true;
        }

        public void resetCreature()
        {
            this.is_creature = false;
        }

        public bool getIsCreature()
        {
            return this.is_creature;
        }

        public Knowledge getKnowledge()
        {
            return this.knowledge;
        }

        public void setKnowledge(Knowledge k)
        {
            this.knowledge = k;
            this.is_knowledge = true;
        }

        public void resetKnowledge()
        {
            this.is_knowledge = false;
        }

        public bool getIsKnowledge()
        {
            return this.is_knowledge;
        }
    }
}
