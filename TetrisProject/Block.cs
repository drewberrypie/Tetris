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
        public Block(IBoard board, Point position, Color colour)
        {
            this.board = board;
            this.position = position;
            this.colour = colour;
        }

        /// <summary>
        /// Gets the color of the block
        /// </summary>
        public Color Colour
        {
            get { return colour; }
        }

        /// <summary>
        /// Gets or sets the position of the block
        /// </summary>
        public Point Position
        {
            get { return position; }
            set { position = value; }
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
            if (position.X < board.GetLength(0) - 1 && board[position.X + 1, position.Y].Equals(Color.Gray))
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
            if (position.Y < board.GetLength(1) - 1 && board[position.X, position.Y + 1].Equals(Color.Gray))
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
            Point check = new Point(position.X, position.Y);
            check.Offset(offset.X, offset.Y);

            try
            {
                if (check.X > board.GetLength(0) || check.Y > board.GetLength(1))
                    clear = false;

                if (!board[check.X, check.Y].Equals(Color.Gray))
                    clear = false;
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Rotation Failure "+e);
                clear = false;
            }

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
                position.Offset(offset.X, offset.Y);
        }
    }
}
