using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace TurtleTraining
{
    class Program
    {
        /*static void Write_T(int size)
        {
            Turtle.Move(size);
            Turtle.TurnLeft();
            Turtle.Move(size / 3);
            Turtle.Angle = 90;
            Turtle.Move((size / 3) * 2);
        }

        static void Write_O(int size)
        {
            for(int i = 0; i<4; i++)
            {
                Turtle.Move(size);
                Turtle.TurnRight();
            }
        }

        static void Write_P(int size)
        {
            Turtle.Move(size);
            Turtle.TurnRight();
            for(int i = 0; i<3; i++)
            {
                Turtle.Move(size / 2);
                Turtle.TurnRight();
            }
            
        }


        static void Main(string[] args)
        {
            Turtle.Speed = 9;
            Turtle.X = 100;
            Turtle.Y = 200;

            Write_T(100);

            Turtle.X = 150;
            Turtle.Y = 200;
            Turtle.Angle = 0;

            Write_O(50);

            Turtle.X = 250;
            Turtle.Y = 250;
            Turtle.Angle = 0;

            Write_P(100);

            Turtle.X = 350;
            Turtle.Y = 200;

            Write_T(50);*/

       static void Write_А(int size)
        {
            Turtle.Angle = 20;
            Turtle.Move(size);
            Turtle.Turn(140);
            Turtle.Move(size);
            Turtle.Turn(180);
            Turtle.Move(size / 2);
            Turtle.Angle = 270;
            Turtle.Move(size / 2);
        }

        static void Write_Н(int size)
        {
            Turtle.Move(size);
            Turtle.Turn(180);
            Turtle.Move(size / 2);
            Turtle.TurnLeft();
            Turtle.Move(size / 2);
            Turtle.Angle = 0;
            Turtle.Move(size / 2);
            Turtle.Turn(180);
            Turtle.Move(size);
        }

        static void Write_У(int size)
        {
            Turtle.Angle = 340;
            Turtle.Move(size);
            Turtle.Turn(180);
            Turtle.Move(size);
            Turtle.Angle = 20;
            Turtle.Move(size);
            Turtle.Turn(180);
            Turtle.Move(size * 2);
        }

        static void Write_Ш(int size)
        {
            Turtle.Move(size);
            Turtle.Turn(180);
            Turtle.Move(size);
            Turtle.TurnLeft();
            Turtle.Move(size/2);
            Turtle.TurnLeft();
            Turtle.Move(size);
            Turtle.Turn(180);
            Turtle.Move(size);
            Turtle.TurnLeft();
            Turtle.Move(size/2);
            Turtle.TurnLeft();
            Turtle.Move(size);
        }

        static void Write_К(int size)
        {
            Turtle.Move(size);
            Turtle.Turn(180);
            Turtle.Move(size / 2);
            Turtle.Angle = 40;
            Turtle.Move(size );
            Turtle.Turn(180);
            Turtle.Move(size );
            Turtle.Angle = 140;
            Turtle.Move(size);
        }

        static void Main(string[] args)
        {
            Turtle.Speed = 9;
            Turtle.X = 100;
            Turtle.Y = 200;
            
            Write_А(100);

            Turtle.X = 200;
            Turtle.Y = 200;
            Turtle.Angle = 0;

            Write_Н(50);

            Turtle.X = 250;
            Turtle.Y = 200;
            Turtle.Angle = 0;

            Write_Н(50);

            Turtle.X = 300;
            Turtle.Y = 200;
            Turtle.Angle = 0;

            Write_У(50);

            Turtle.X = 340;
            Turtle.Y = 200;
            Turtle.Angle = 0;

            Write_Ш(50);

            Turtle.X = 400;
            Turtle.Y = 200;
            Turtle.Angle = 0;

            Write_К(50);

            Turtle.X = 450;
            Turtle.Y = 200;
            Turtle.Angle = 0;

            Write_А(50);

        }
    }
}
