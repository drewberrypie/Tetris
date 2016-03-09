using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisProject
{
    public class ShapeJ : Shape
    {
        public ShapeJ(IBoard board) : base(board)
        {
            blocks = new Block[4]
                {
                    new Block(board, new Point(4, 0)),
                    new Block(board, new Point(5 ,0)),
                    new Block(board, new Point(6, 0)),
                    new Block(board, new Point(6, 1))
                };

            rotationOffset = new Point[][]
            {
                //1 2 3
                //    4
                new Point[] { new Point(-1, 1), new Point(1, 1), new Point(1, -1), new Point(-1, -1) },
                new Point[] { new Point(0, 0), new Point(0, 0), new Point(0, 0), new Point(0, 0) },
                new Point[] { new Point(1, -1), new Point(-1, -1), new Point(-1, 1), new Point(1, 1) },
                new Point[] { new Point(2, 0), new Point(0, -2), new Point(-2, 0), new Point(0, 2) }
            };
        }
    }
}
