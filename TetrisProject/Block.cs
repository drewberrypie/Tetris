using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisProject
{
    /// <summary>
    /// Block object which contains a color and coordinates on a 2D board
    /// </summary>
    public class Block
    {
        private IBoard board;
        private Color colour;
        private Point position;

        /// <summary>
        /// Block object to be placed into a shape and then on a board
        /// </summary>
        /// <param name="board">Reference board</param>
        public Block(IBoard board, Point position)
        {
            this.board = board;
            this.position = position;
        }

        /// <summary>
        /// Gets the color of the block
        /// </summary>
        public Color Colour
        {
            get;
        }

        /// <summary>
        /// Gets or sets the position of the block
        /// </summary>
        public Point Position
        {
            get;
            set;
        }

        /// <summary>
        /// Verify if it is possible for the current block to move left
        /// </summary>
        /// <returns>Returns true if left move is possible, otherwise false</returns>
        public bool TryMoveLeft()
        {
            if (position.X > 0 && board[position.X - 1, position.Y].Equals(Color.Gray))
                return true;
            else
                return false;
        }

        /// <summary>
        /// Verify if it is possible for the current block to move right
        /// </summary>
        /// <returns>Returns true if right move is possible, otherwise false</returns>
        public bool TryMoveRight()
        {
            if (position.X < board.GetLength(0) && board[position.X + 1, position.Y].Equals(Color.Gray))
                return true;
            else
                return false;
        }

        /// <summary>
        /// Verify if it is possible for the current block to move down
        /// </summary>
        /// <returns>Returns true if down move is possible, otherwise false</returns>
        public bool TryMoveDown()
        {
            if (position.Y < board.GetLength(1) && board[position.X + 1, position.Y].Equals(Color.Gray))
                return true;
            else
                return false;
        }

        /// <summary>
        /// Check to see if the Block can move into the new rotation position
        /// </summary>
        /// <param name="offset">New position for block</param>
        public bool TryRotate(Point offset)
        {
            bool clear = true;
            Point test = new Point(position.X, position.Y);
            test.Offset(offset.X, offset.Y);

            if (board[test.X, test.Y].Equals(Color.Gray))
                clear = false;

            return clear;
        }

        /// <summary>
        /// Moves the block left if it is possible
        /// </summary>
        public void MoveLeft()
        {
            if (TryMoveLeft())
                position.X--;
        }

        /// <summary>
        /// Moves the block right if possible
        /// </summary>
        public void MoveRight()
        {
            if (TryMoveRight())
                position.X++;
        }

        /// <summary>
        /// Moves the block down if possible
        /// </summary>
        public void MoveDown()
        {
            if (TryMoveDown())
                position.Y++;
        }

        /// <summary>
        /// Rotates the block in a counter-clockwise direction if possible
        /// </summary>
        /// <param name="offset">Position to translate to</param>
        public void Rotate(Point offset)
        {
            if (TryRotate(offset))
                Position.Offset(offset.X, offset.Y);
        }
    }
}
