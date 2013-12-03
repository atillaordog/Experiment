using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.IO;

namespace Experiment
{
    public abstract class Outputter
    {
        protected Environment e;

        public void passEnvironment(Environment e)
        {
            this.e = e;
        }

        abstract public void write();

        public string serializeToString()
        {
            string serialized = "size=" + this.e.getSize()[0] + "," + this.e.getSize()[1]+"::::";
            // This is actually a simple thing, we create a big string that contains all the positions and creatures and knowledges
            for (int i = 0, m = this.e.getPositions().Count; i < m; i++)
            {
                serialized += "position=" + this.e.getPositions()[i].getLocation().x + "," + this.e.getPositions()[i].getLocation().y;
                serialized += ";iscreature=" + this.e.getPositions()[i].getIsCreature();
                serialized += ";isknowledge=" + this.e.getPositions()[i].getIsKnowledge();

                if (i != m - 1)
                {
                    serialized += "][";
                }
            }

            return serialized;
        }

    }
}
