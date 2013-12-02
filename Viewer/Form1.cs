using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TestExperiment;

namespace Viewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
            this.SetClientSizeCore(500,200);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g;

            g = e.Graphics;

            Pen myPen = new Pen(Color.Red);
            myPen.Width = 30;
            g.DrawLine(myPen, 30, 30, 45, 65);

            g.DrawLine(myPen, 1, 1, 45, 65);
        }
    }
}
