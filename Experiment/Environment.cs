using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Experiment
{
    class Environment
    {
        protected List<Position> positions;

        protected int width = 0, height = 0;

        public void setSize(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        /**
         * Initialize the environment, by instantiating positions with their coordinates
         */
        public void initialize()
        {
            for (int i = 0; i < this.height; i++)
            {
                for (int j = 0; j < this.width; j++)
                {
                    Location location = new Location();
                    location.x = i;
                    location.y = j;

                    Position p = new Position();
                    p.setLocation(location);

                    this.positions.Add(p);
                }
            }
        }
    }
}
