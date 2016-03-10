using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisProject
{
    /// <summary>
    /// O shape object
    /// </summary>
    public class ShapeO : Shape
    {
        /// <summary>
        /// Shape constructor
        /// </summary>
        /// <param name="board">board referenced</param>
        public ShapeO(IBoard board) : base(board)
        {
            blocks = new Block[4]
                {
                    new Block(board, new Point(4, 0), Color.Yellow),
                    new Block(board, new Point(5 ,0), Color.Yellow),
                    new Block(board, new Point(4, 1), Color.Yellow),
                    new Block(board, new Point(5, 1), Color.Yellow)
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
        
        /// <summary>
        /// Reset block position to top-middle of board
        /// </summary>
        public override void Reset()
        {
            blocks[1].Position = new Point(4, 0);
            blocks[2].Position = new Point(5, 0);
            blocks[3].Position = new Point(4, 1);
            blocks[4].Position = new Point(5, 1);

            currentRotation = 0;
        }
    }
}
