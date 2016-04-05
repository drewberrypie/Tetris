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
        private bool play = true;

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
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            font = game.Content.Load<SpriteFont>("scoreFont");

            base.LoadContent();
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

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public override void Draw(GameTime gameTime)
        {
            string time = gameTime.TotalGameTime.Minutes + ":" + gameTime.TotalGameTime.Seconds + ":" + gameTime.TotalGameTime.Milliseconds;

            spriteBatch.Begin();
            if (play)
            {
                spriteBatch.DrawString(font, "Score: " + score.Highscore, new Vector2(310, 60), Color.Black);
                spriteBatch.DrawString(font, "Level: " + score.Level, new Vector2(310, 85), Color.Black);
                spriteBatch.DrawString(font, "Time: " + time, new Vector2(310, 165), Color.Black);
            }            
            spriteBatch.End();
        }

        /// <summary>
        /// Default set to true, set play to false when the game is over
        /// </summary>
        public bool Play
        {
            set { play = value; }
        }
    }
}
