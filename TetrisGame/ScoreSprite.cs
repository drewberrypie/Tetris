using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TetrisProject;

namespace TetrisGame
{
    class ScoreSprite : DrawableGameComponent
    {
        private Score score;
        private Game game;
        private SpriteBatch spriteBatch;
        private SpriteFont font;

        /// <summary>
        /// The ScoreSprite is responsible for writing score-related information, such as the level, number of lines cleared, and the score.
        /// </summary>
        /// <param name="game">Game</param>
        /// <param name="score">Score</param>
        public ScoreSprite(Game game, Score score) : base(game)
        {
            this.game = game;
            this.score = score;
        }

        /// <summary>
        /// Allows the game to run logic such as updating the Score
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public override void Update(GameTime gameTime)
        {
            // TODO Update time elapsed
            base.Update(gameTime);
        }
    }
}
