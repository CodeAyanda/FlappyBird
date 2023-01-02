using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FlappyBird
{
    class Pipes
    {
        Point topStart;
        Point bottomStart;

        static int width = 60;
        int topHeight;

        static int screenHeight = 754;

        static int numPipes = 1000;
        static int topBottomSpacing = 200;

        public static Pipes[] allPipes = new Pipes[numPipes];

        static Pen white = new Pen(Color.White);

        static Random rnd = new Random();



        public Pipes(int space)
        {

            this.topStart = new Point(space, 0);
            this.topHeight = rnd.Next(0, screenHeight-200);

            this.bottomStart = new Point(this.topStart.X, this.topHeight + topBottomSpacing);

        }

        public static void GeneratePipes()
        {
            for (int i = 0; i < numPipes; i++)
            {
                Pipes newPipe = new Pipes(i*250);
                allPipes[i] = newPipe;
            }
        }

        static int pipeSpeed;
        public static void Draw(Graphics g)
        {
            pipeSpeed = 3;
            

            foreach (Pipes pipe in allPipes)
            {
                Rectangle top = new Rectangle(pipe.topStart.X, pipe.topStart.Y, width, pipe.topHeight);
                Rectangle bottom = new Rectangle(pipe.bottomStart.X, pipe.bottomStart.Y, width, screenHeight - pipe.bottomStart.Y);

                g.DrawRectangle(white, top);
                g.DrawRectangle(white, bottom);

                pipe.topStart.X -= pipeSpeed;
                pipe.bottomStart.X -= pipeSpeed;

                Rectangle bird = new Rectangle(Bird.x, (int)Bird.y, Bird.width, Bird.width);

                if(pipe.topStart.X > 0 && pipe.topStart.X < 80)
                {
                    if (top.IntersectsWith(bird))
                    {
                        g.FillRectangle(new SolidBrush(Color.Red), top);
                    }
                    else if(bottom.IntersectsWith(bird))
                    {
                        g.FillRectangle(new SolidBrush(Color.Red), bottom);

                    }

                }



            }


        }

    }
}
