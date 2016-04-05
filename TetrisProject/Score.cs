using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisProject
{
    /// <summary>
    /// Score object which holds the game's level, lines cleared, and current score
    /// </summary>
    public class Score
    {
        private int level = 1;
        private int lines = 0;
        private int highscore = 0;

        /// <summary>
        /// Takes a board as an object and observes the lines cleared by the board
        /// </summary>
        /// <param name="board">Board object to be observed</param>
        public Score(IBoard board)
        {
            board.LinesCleared += incrementLinesCleared;
        }

        /// <summary>
        /// Gets the current level
        /// </summary>
        public int Level
        {
            get { return level; }
        }

        /// <summary>
        /// Gets the number of lines cleared
        /// </summary>
        public int Lines
        {
            get { return lines; }
        }

        /// <summary>
        /// Gets the current score
        /// </summary>
        public int Highscore
        {
            get { return highscore; }
        }

        /// <summary>
        /// Event Handler: Increases the number of lines cleared, difficulty, and player score
        /// </summary>
        /// <param name="cleared">Number of lines cleared</param>
        private void incrementLinesCleared(int cleared)
        {
            //Increase lines cleared
            lines++;

            //Increase current score
            switch (cleared)
            {
                case 1:
                    highscore += 40 * Level;
                    break;
                case 2:
                    highscore += 100 * Level;
                    break;
                case 3:
                    highscore += 300 * Level;
                    break;
                case 4:
                    highscore += 1200 * Level;
                    break;
                default:
                    break;
            }

            //Increase level relative to lines cleared (to a maximum of 10)
            level = Math.Min((lines / 10 + 1), 10);
        }
    }
}
