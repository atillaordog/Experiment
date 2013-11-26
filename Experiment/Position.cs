using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Experiment
{
    class Position
    {
        protected Location location;
        protected Creature creature;
        protected Knowledge knowledge;

        public void setLocation(Location l)
        {
            this.location = l;
        }

        public Location getLocation()
        {
            return this.location;
        }

        public Creature getCreature()
        {
            return this.creature;
        }

        public void setCreature(Creature c)
        {
            this.creature = c;
        }

        public Knowledge getKnowledge()
        {
            return this.knowledge;
        }

        public void setKnowledge(Knowledge k)
        {
            this.knowledge = k;
        }
    }
}
