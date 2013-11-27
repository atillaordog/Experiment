using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Experiment;

namespace TestExperiment
{
    class TestOutputter : Experiment.Outputter
    {
        public override void write()
        {
            Console.Clear();

            int width = this.e.getSize()[0];
            int height = this.e.getSize()[1];

            int[,] map = new int[width,height];
            
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    map[i, j] = 0;

                    if (this.e.getPosition(i, j).getIsKnowledge())
                    {
                        map[i, j] = 2;
                    }

                    Console.Write("" + map[i,j]);
                }
               
                Console.WriteLine("");
            }
        }
    }
}
