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
        protected Stream s;

        public void passEnvironment(Environment e)
        {
            this.e = e;
        }

        abstract public void write();

        public void serializeToBinary()
        {
            try
            {
                this.s = File.Open("data.bin", FileMode.Create);
               
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(this.s, this.e.getPositions());
            }
            catch (Exception)
            {
            }

        }

    }
}
