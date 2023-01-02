using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Pipes.GeneratePipes();
        }

        public static bool gameOver = false;

        private void Draw(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Bird.Draw(g);
            Pipes.Draw(g);
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate();

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                Bird.up = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == ' ')
            {
                Bird.up = false;
            }
        }
    }
}
