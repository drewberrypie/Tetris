using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisProject
{
    /// <summary>
    /// Delegate object
    /// </summary>
    /// <param name="Shape">Shape which will be joining the pile</param>
    public delegate void JoinPileHandler(IShape Shape);

    /// <summary>
    /// Shape Interface
    /// </summary>
    public interface IShape
    {
        /// <summary>
        /// Event to keep track board blocks
        /// </summary>
        event JoinPileHandler JoinPile;

        /// <summary>
        /// Gets the Shape Length
        /// </summary>
        int Length { get; }

        /// <summary>
        /// Indexer
        /// </summary>
        /// <param name="index">Index</param>
        /// <returns>Block at position i</returns>
        Block this[int index] { get; }

        /// <summary>
        /// Moves the current Shape Left
        /// </summary>
        void MoveLeft();

        /// <summary>
        /// Moves the current Shape right
        /// </summary>
        void MoveRight();

        /// <summary>
        /// Moves the current Shape down one block
        /// </summary>
        /// <returns>Returns True if the move was successful, otherwise false</returns>
        Boolean MoveDown();

        /// <summary>
        /// Moves the current Shape down completely
        /// </summary>
        void Drop();

        /// <summary>
        /// Rotate the Block clockwise
        /// </summary>
        void Rotate();

        /// <summary>
        /// Reset something
        /// </summary>
        void Reset();
    }
}
