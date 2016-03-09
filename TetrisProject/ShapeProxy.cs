using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisProject
{
    /// <summary>
    /// Bridge class between Boards and Shapes
    /// </summary>
    public class ShapeProxy : IShapeFactory, IShape
    {
        Random random = new Random();
        IShape current;
        IBoard board;

        public event JoinPileHandler JoinPile;

        public ShapeProxy(IBoard board, IShape current)
        {
            this.board = board;
            this.current = current;
        }

        /// <summary>
        /// Gets the current Shape Length
        /// </summary>
        public int Length
        {
            get { return current.Length; }
        }

        /// <summary>
        /// Returns the block object in the specified index of the current Shape
        /// </summary>
        /// <param name="index">Index</param>
        /// <returns>Block at position i</returns>
        public Block this[int index]
        {
            get { return current[index]; }
        }

        public void DeployNewShape()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Moves the current Shape Left if possible
        /// </summary>
        public void MoveLeft()
        {
            current.MoveLeft();
        }

        /// <summary>
        /// Moves the current Shape right if possible
        /// </summary>
        public void MoveRight()
        {
            current.MoveRight();
        }

        /// <summary>
        /// Moves the current Shape down one block
        /// </summary>
        /// <returns>Returns True if the move was successful, otherwise false</returns>
        public bool MoveDown()
        {
            return current.MoveDown();
        }

        /// <summary>
        /// Moves the current Shape down completely
        /// </summary>
        public void Drop()
        {
            current.Drop();
        }

        /// <summary>
        /// Rotate the current Shape clockwise relative to the position offset
        /// </summary>
        public void Rotate()
        {
            current.Rotate();
        }

        public void Reset()
        {
            current.Reset();
        }
    }
}
