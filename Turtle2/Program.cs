﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace Turtle2
{
    class Program
    {
        static void Main(string[] args)
        {
            Turtle.Speed = 9;
            for( int i = 0; i < 4; i++ )
            {
                Turtle.Move(20);
                Turtle.TurnRight();
                Turtle.Move(20);
                Turtle.TurnRight();
                Turtle.Move(20);
                Turtle.TurnLeft();
                Turtle.Move(20);
                Turtle.TurnLeft();
                
            }

        }
    }
}
