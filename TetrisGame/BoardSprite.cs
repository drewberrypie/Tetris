﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TetrisProject;

namespace TetrisGame
{
    class BoardSprite : DrawableGameComponent
    {
        private IBoard board;
        private Game game;
        private SpriteBatch spriteBatch;

        //To render
        private Texture2D emptyBlock;
        private Texture2D filledBlock;

        /// <summary>
        /// The BoardSprite is responsible for drawing the Board (the pile is distinguished from the rest by its Colors).
        /// </summary>
        /// <param name="game">Game</param>
        /// <param name="board">Board</param>
        public BoardSprite(Game game, IBoard board) : base(game)
        {
            this.game = game;
            this.board = board;
        }

        public override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            filledBlock = game.Content.Load<Texture2D>("FilledBlock");
            emptyBlock = game.Content.Load<Texture2D>("EmptyBlock");
            base.LoadContent();
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public override void Update(GameTime gameTime)
        {
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();
            for (int i = 0; i < board.GetLength(0) * 25; i += 25)
            {
                for (int j = 0; j < board.GetLength(1) * 25; j += 25)
                {
                    System.Drawing.Color c = board[i / 25, j / 25];
                    if (Equals(c, System.Drawing.Color.Gray))
                        spriteBatch.Draw(emptyBlock, new Rectangle(50 + i, 50 + j, 25, 25), Color.DarkSlateGray);
                    else
                        spriteBatch.Draw(filledBlock, new Rectangle(50 + i, 50 + j, 25, 25), new Color(c.R, c.G, c.B));
                }
            }
            spriteBatch.End();
        }
    }
}
