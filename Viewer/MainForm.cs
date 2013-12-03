using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TestExperiment;
using System.Threading;

namespace Viewer
{
    public partial class MainForm : Form
    {
        public Viewer v;

        public MainForm(Viewer v)
        {
            this.v = v;
            InitializeComponent();

            this.v.calculateSizes();

            this.SetClientSizeCore(v.envWidth,v.envHeight);

            Thread experiment = new Thread(new ThreadStart(this.v.getExperiemnt().run));
            experiment.Start();

            Thread form = new Thread(new ThreadStart(this.drawExperiment));
            form.Start();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        public void drawExperiment()
        {
            while (this.v.getExperiemnt().experimentRuns)
            {
                this.Invalidate();

                Graphics g = this.CreateGraphics();

                Pen redPen = new Pen(Color.Red), bluePen = new Pen(Color.Blue);
                redPen.Width = 1;
                bluePen.Width = 1;

                for (int i = 0, m = this.v.getExperiemnt().environment.getPositions().Count; i < m; i++)
                {
                    if (this.v.getExperiemnt().environment.getPositions()[i].getIsCreature())
                    {

                        int x = this.v.getExperiemnt().environment.getPositions()[i].getLocation().x * (this.v.creatureSize + 1);

                        int y = this.v.getExperiemnt().environment.getPositions()[i].getLocation().y * (this.v.creatureSize + 1);

                        g.DrawEllipse(redPen, x, y, this.v.creatureSize, this.v.creatureSize);
                    }
                    else
                    {
                        if (this.v.getExperiemnt().environment.getPositions()[i].getIsKnowledge())
                        {

                            int x = this.v.getExperiemnt().environment.getPositions()[i].getLocation().x * (this.v.KnowledgeSize + 1);

                            int y = this.v.getExperiemnt().environment.getPositions()[i].getLocation().y * (this.v.KnowledgeSize + 1);

                            g.DrawEllipse(bluePen, x, y, this.v.KnowledgeSize, this.v.KnowledgeSize);
                        }
                    }
                    
                }

                    
            }

            Thread.Sleep(200);
        }
    }
}
