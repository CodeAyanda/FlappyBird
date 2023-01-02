using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FlappyBird
{
    class Bird
    {
        static int screenHeight = 754;


        public static int x = 25;
        public static double y = 300;
        static double ySpeed = 1.2;
        static double gravity = 0.4;
        public static int width = 30;
        public static bool up = false;


        static Pen white = new Pen(Color.White);
        static SolidBrush whiteFill = new SolidBrush(Color.White);

        public static void Draw(Graphics g)
        {
            y += ySpeed;
            ySpeed += gravity;

            if(y>screenHeight-width)
            {
                y = screenHeight / 2;
                ySpeed = 0;
            }

            if(y<0)
            {
                y = screenHeight / 2;
                ySpeed = 0;
            }

            if (up)
            {
                ySpeed += (-gravity*14);
                ySpeed = ySpeed * 0.6;

            }
            g.FillEllipse(whiteFill, x, (int)y, width, width);


        }

    }
}
