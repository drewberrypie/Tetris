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

        /// <summary>
        /// Shape object proxy which allows the board to interact with any shape
        /// </summary>
        /// <param name="board">board referenced</param>
        /// <param name="current">Shape subclass used</param>
        public ShapeProxy(IBoard board)
        {

            this.board = board;
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

        /// <summary>
        /// Determines which shape the Proxy will be
        /// </summary>
        public void DeployNewShape()
        {
            //Randomize between the 7 shapes that can be taken, O, S, Z, I, J, L, T
            int decider = random.Next(1, 8);

            switch (decider)
            {
                case 1:
                    current = new ShapeO(board);
                    break;
                case 2:
                    current = new ShapeS(board);
                    break;
                case 3:
                    current = new ShapeZ(board);
                    break; 
                case 4:
                    current = new ShapeI(board);
                    break;
                case 5:
                    current = new ShapeJ(board);
                    break;
                case 6:
                    current = new ShapeL(board);
                    break;
                case 7:
                    current = new ShapeT(board);
                    break;
                default:
                    break;
            }
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

        /// <summary>
        /// Reset block to top middle of shape
        /// </summary>
        public void Reset()
        {
            current.Reset();
        }

        /// <summary>
        /// Method which fires the JoinPile event when a shape stops
        /// </summary>
        protected void OnJoinPile()
        {
            JoinPile(current);
        }
    }
}
