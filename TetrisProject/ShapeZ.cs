using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisProject
{
    /// <summary>
    /// Z Shape Object
    /// </summary>
    public class ShapeZ : Shape
    {
        /// <summary>
        /// Shape constructor
        /// </summary>
        /// <param name="board">board referenced</param>
        public ShapeZ(IBoard board) : base(board)
        {
            blocks = new Block[4]
                {
                    new Block(board, new Point(4, 0)),
                    new Block(board, new Point(5 ,0)),
                    new Block(board, new Point(5, 1)),
                    new Block(board, new Point(6, 1))
                };

            rotationOffset = new Point[][]
                {
                    //1 2
                    //  3 4
                    new Point[] { new Point(1, 1), new Point(-1, -1) },
                    new Point[] { new Point(0, 0), new Point(0, 0) },
                    new Point[] { new Point(1, -1), new Point(1, -1) },
                    new Point[] { new Point(0, -2), new Point(0, 2) }
                };
        }

        /// <summary>
        /// Reset block position to top-middle of board
        /// </summary>
        public override void Reset()
        {
            blocks[1].Position = new Point(4, 0);
            blocks[2].Position = new Point(5, 0);
            blocks[3].Position = new Point(5, 1);
            blocks[4].Position = new Point(6, 1);

            currentRotation = 0;
        }
    }
}
