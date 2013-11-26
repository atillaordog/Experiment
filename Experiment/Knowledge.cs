using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Experiment
{
    abstract class Knowledge
    {
        protected Location location;

        protected int id = 0;

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
    }
}
