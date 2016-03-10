using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisProject
{
    /// <summary>
    /// Board object for the tetris game, contains all the blocks and colors
    /// </summary>
    public class Board : IBoard
    {
        private Color[,] board = new Color[10, 20];
        private IShape shape;
        private IShapeFactory shapeFactory;

        //Events
        public event GameOverHandler GameOver;
        public event LinesClearedHandler LinesCleared;

        /// <summary>
        /// Board Constructor
        /// </summary>
        public Board()
        {
            for (int x = 0; x<board.GetLength(0); x++)
                for (int y = 0; y<board.GetLength(1); y++)
                 board[x, y] = Color.Gray;

            ShapeProxy proxy = new ShapeProxy(this);
            shapeFactory = proxy;
            shape = proxy;

            shape.JoinPile += addToPile;
        }

        /// <summary>
        /// Gets the Shape
        /// </summary>
        public IShape Shape
        {
            get;
        }

        /// <summary>
        /// Indexer which returns colors from the board
        /// </summary>
        /// <param name="x">Row</param>
        /// <param name="y">Column</param>
        /// <returns>Returns the color in the specified location</returns>
        public Color this[int x, int y]
        {
            get { return board[x, y]; }
        }

        /// <summary>
        /// Gets the length of the dimension. 0 for rows, 1 for columns
        /// </summary>
        /// <param name="rank">Specified rank</param>
        /// <returns>Size of specified rank in array</returns>
        public int GetLength(int rank)
        {
            return board.GetLength(rank);
        }

        /// <summary>
        /// Method which fires the LinesCleared event when the user clears lines
        /// </summary>
        /// <param name="lines">Number of lines the player cleared</param>
        protected void OnLinesCleared(int lines)
        {
            LinesCleared(lines);
        }

        /// <summary>
        /// Method which fires the GameOver event when the game ends
        /// </summary>
        protected void OnGameOver()
        {
            GameOver();
        }

        /// <summary>
        /// Event handler for the JoinPile event
        /// </summary>
        /// <param name="shape"></param>
        private void addToPile(IShape shape)
        {

        }
    }
}
