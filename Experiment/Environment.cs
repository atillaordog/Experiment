using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Experiment
{
    public class Environment
    {
        /**
         * @var List positions The container of the world, every position can have a knowledge and a creature
         */
        protected List<Position> positions = new List<Position>();

        protected int width = 0, height = 0;

        /**
         * Sets the size of the world explicitely
         * @param int width The width or x dimension of the world
         * @param int height The height or y dimension of the world
         */
        public void setSize(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public int[] getSize()
        {
            int[] a = {0,0};
            a[0] = this.width;
            a[1] = this.height;

            return a;
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

        /**
         * Set knowledge to given position
         * @param int x Coordinate
         * @param int y Coordinate
         * @param Knowledge k A class that extends Knowledge
         */ 
        public void addKnowledgeToPosition(int x, int y, Knowledge k)
        {
            // We search for the coordinates if they exist and add the Knowledge
            for (int i = 0, m = this.positions.Count; i < m; i++)
            {
                if (this.positions[i].getLocation().x == x && this.positions[i].getLocation().y == y)
                {
                    k.setLocation(this.positions[i].getLocation());
                    this.positions[i].setKnowledge(k);
                    break;
                }
            }
        }

        /**
         * Set creature to given position
         * @param int x Coordinate
         * @param int y Coordinate
         * @param Creature c A class that extends Creature
         */
        public void addCreatureToPosition(int x, int y, Creature c)
        {
            // We search for the coordinates if they exist and add the Creature
            for (int i = 0, m = this.positions.Count; i < m; i++)
            {
                if (this.positions[i].getLocation().x == x && this.positions[i].getLocation().y == y)
                {
                    c.setLocation(this.positions[i].getLocation());
                    this.positions[i].setCreature(c);
                    break;
                }
            }
        }

        public Position getPosition(int x, int y)
        {
            // Search the position by coordinates and return it
            for (int i = 0, m = this.positions.Count; i < m; i++)
            {
                if (this.positions[i].getLocation().x == x && this.positions[i].getLocation().y == y)
                {
                    return this.positions[i];
                }
            }

            return new Position();
        }

        public List<Position> getPositions()
        {
            return this.positions;
        }

        public void doOneStepProcedural()
        {
            List<int> p_to_do = new List<int>();

            for (int i = 0, m = this.positions.Count; i < m; i++)
            {
                if (this.positions[i].getIsCreature())
                {
                    p_to_do.Add(i);
                }
            }

            for (int i = 0, m = p_to_do.Count; i < m; i++)
            {
                this.positions[p_to_do[i]].getCreature().passEnvironment(this);
                this.positions[p_to_do[i]].getCreature().doAction();
            }
        }

        public void doOneStepThreaded()
        {
            List<Thread> threads = new List<Thread>();

            for (int i = 0, m = this.positions.Count; i < m; i++)
            {
                if (this.positions[i].getIsCreature())
                {
                    this.positions[i].getCreature().passEnvironment(this);

                    Thread t = new Thread(new ThreadStart(this.positions[i].getCreature().doAction));

                    t.Start();
                    threads.Add(t);
                }
            }
        }

    }
}
