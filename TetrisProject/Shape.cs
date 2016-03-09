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
        /// Event to keep track board blocks
        /// </summary>
        public event JoinPileHandler JoinPile;

        public abstract void setShape();

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

        }

        /// <summary>
        /// Rotate the Shape clockwise relative to the position offset
        /// </summary>
        public void Rotate()
        {
            bool clear = true;
            int rotation = 0;

            if ((currentRotation + 1) >= rotationOffset.GetLength(0))
                rotation = -currentRotation;
            else
                rotation = 1;

            //Check if each block can rotate
            for (int i = 0; i < Length; i++)
                if (!blocks[i].TryRotate(rotationOffset[currentRotation + rotation][i]))
                    clear = false;

            if (clear)
            {
                currentRotation += rotation;

                for (int i = 0; i < Length; i++)
                    blocks[i].Rotate(rotationOffset[currentRotation][i]);
            }
        }

        /// <summary>
        /// Reset shape to the top middle and at rotation 0
        /// </summary>
        public void Reset()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Method which fires the JoinPile event when a shape stops
        /// </summary>
        protected void OnJoinPile()
        {
            JoinPile(this);
        }
    }
}