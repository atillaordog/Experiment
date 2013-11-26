using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Experiment
{
    class Location
    {
        public int x = 0, y = 0;

        public int[] getLocation()
        {
            int[] a ={0,0};
            a[0] = this.x;
            a[1] = this.y;

            return a;
        }
    }
}
