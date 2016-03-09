﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisProject
{
    public class ShapeO : Shape
    {
        public ShapeO(IBoard board) : base(board)
        {
            blocks = new Block[4]
                {
                    new Block(board, new Point(4, 0)),
                    new Block(board, new Point(5 ,0)),
                    new Block(board, new Point(4, 1)),
                    new Block(board, new Point(5, 1))
                };

            rotationOffset = new Point[][]
            {
                //1 2
                //3 4
                new Point[] { new Point(0, 0) },
                new Point[] { new Point(0, 0) },
                new Point[] { new Point(0, 0) },
                new Point[] { new Point(0, 0) }
            };
        }
    }
}