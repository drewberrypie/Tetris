using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisProject
{
    /// <summary>
    /// L Shape Object
    /// </summary>
    public class ShapeL : Shape
    {
        /// <summary>
        /// Shape constructor
        /// </summary>
        /// <param name="board">board referenced</param>
        public ShapeL(IBoard board) : base(board)
        {
            blocks = new Block[4]
                {
                    new Block(board, new Point(4, 0), Color.Orange),
                    new Block(board, new Point(5 ,0), Color.Orange),
                    new Block(board, new Point(6, 0), Color.Orange),
                    new Block(board, new Point(4, 1), Color.Orange)
                };

            rotationOffset = new Point[][]
                {
                    //0 1 2
                    //3
                    new Point[] { new Point(-1, 1), new Point(1, 1), new Point(1, -1), new Point(-1, -1) },
                    new Point[] { new Point(0, 0), new Point(0, 0), new Point(0, 0), new Point(0, 0) },
                    new Point[] { new Point(1, -1), new Point(-1, -1), new Point(-1, 1), new Point(1, 1) },
                    new Point[] { new Point(0, 2), new Point(2, 0), new Point(0, -2), new Point(-2, 0) }
                };
        }

        /// <summary>
        /// Reset block position to top-middle of board
        /// </summary>
        public override void Reset()
        {
            blocks[0].Position = new Point(4, 0);
            blocks[1].Position = new Point(5, 0);
            blocks[2].Position = new Point(6, 0);
            blocks[3].Position = new Point(4, 1);

            currentRotation = 0;
        }
    }
}
