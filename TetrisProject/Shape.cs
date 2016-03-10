using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisProject
{
    /// <summary>
    /// Base object for all shapes involved in the board
    /// </summary>
    public abstract class Shape : IShape
    {
        private IBoard board;
        protected Block[] blocks;
        protected Point[][] rotationOffset;
        protected int currentRotation = 0;

        /// <summary>
        /// Event to keep track of shapes coming to a stop in a board
        /// </summary>
        public event JoinPileHandler JoinPile;

        /// <summary>
        /// Shape constructor
        /// </summary>
        /// <param name="board">Board to be placed on</param>
        public Shape(IBoard board)
        {
            this.board = board;
        }

        /// <summary>
        /// Gets the Shape Length
        /// </summary>
        public int Length
        {
            get { return blocks.Length; }
        }

        /// <summary>
        /// Returns the block object in the specified index
        /// </summary>
        /// <param name="index">Index</param>
        /// <returns>Block at position i</returns>
        public Block this[int index]
        {
            get { return blocks[index]; }
        }

        /// <summary>
        /// Moves the Shape Left if possible
        /// </summary>
        public void MoveLeft()
        {
            bool clear = true;

            foreach (Block b in blocks)
                if (!b.TryMoveLeft())
                    clear = false;

            if (clear)
                foreach (Block b in blocks)
                    b.MoveLeft();
        }

        /// <summary>
        /// Moves the Shape right if possible
        /// </summary>
        public void MoveRight()
        {
            bool clear = true;

            foreach (Block b in blocks)
                clear = b.TryMoveRight();

            if (clear)
                foreach (Block b in blocks)
                    b.MoveRight();
        }

        /// <summary>
        /// Moves the Shape down one block
        /// </summary>
        /// <returns>Returns True if the move was successful, otherwise false</returns>
        public bool MoveDown()
        {
            bool clear = true;

            foreach (Block b in blocks)
                clear = b.TryMoveDown();

            if (clear)
                foreach (Block b in blocks)
                    b.MoveDown();
            else
                OnJoinPile();

            return clear;
        }

        /// <summary>
        /// Moves the Shape down completely
        /// </summary>
        public void Drop()
        {
            bool canMove = true;

            while (canMove)
                canMove = MoveDown();

            OnJoinPile();
        }

        /// <summary>
        /// Rotate the Shape counter clockwise relative to the position offset
        /// </summary>
        public void Rotate()
        {
            if (rotationOffset[0].Length == 1)
                return;

            bool clear = true;
            int temp = currentRotation + 1;

            if (temp >= rotationOffset[0].Length)
                temp = 0;

            //Check if each block can rotate
            for (int i = 0; i < 4; i++)
                clear &= blocks[i].TryRotate(rotationOffset[i][temp]);

            if (clear)
            {
                currentRotation = temp;

                for (int i = 0; i < 4; i++)
                    blocks[i].Rotate(rotationOffset[i][currentRotation]);
            }
        }

        /// <summary>
        /// Reset shape to the top middle and at rotation 0
        /// </summary>
        public abstract void Reset();

        /// <summary>
        /// Method which fires the JoinPile event when a shape stops
        /// </summary>
        protected void OnJoinPile()
        {
            if (JoinPile != null)
                JoinPile(this);
        }
    }
}