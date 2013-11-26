using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Experiment
{
    abstract public class Knowledge
    {
        protected Location location;

        protected int id = 0;

        protected Creature creature;

        abstract public void use();
        
        public void setLocation(Location l)
        {
            this.location = l;
        }

        public Location getLocation()
        {
            return this.location;
        }

        public int getId()
        {
            return this.id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public void passCreature(Creature c)
        {
            this.creature = c;
        }
    }
}
