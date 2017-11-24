using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawTriangleMethod
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            Pen pen = new Pen(Color.Red, 10);
        }

        public void DrawTriangle(Pen pen, int x1, int y1, int x2, int y2, int x3, int y3)
        {
            Graphics fG = this.CreateGraphics();
            

            fG.DrawLine(pen, x1, y1, x2, y2);
            fG.DrawLine(pen, x2, y2, x3, y3);
            fG.DrawLine(pen, x3, y3, x1, y1);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
        }
    }
}
