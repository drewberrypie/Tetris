using System;
using System.Drawing;

namespace TetrisProject
{
    // Delegate objects
    public delegate void LinesClearedHandler(int x);
    public delegate void GameOverHandler();

    /// <summary>
    /// Board Interface
    /// </summary>
    public interface IBoard
    {
        event LinesClearedHandler LinesCleared;
        event GameOverHandler GameOver;

        /// <summary>
        /// Gets the Shape
        /// </summary>
        IShape Shape { get; }

        /// <summary>
        /// Indexer which returns colors from the board
        /// </summary>
        /// <param name="x">Row</param>
        /// <param name="y">Column</param>
        /// <returns>Returns the color in the specified location</returns>
        Color this[int x, int y] { get; }

        /// <summary>
        /// Gets the length of the specified rank
        /// </summary>
        /// <param name="rank">Specified rank</param>
        /// <returns>Size of specified rank in array</returns>
        int GetLength(int rank);
    }
}
