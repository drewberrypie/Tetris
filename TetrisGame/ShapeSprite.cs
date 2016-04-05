using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using TetrisProject;

namespace TetrisGame
{
    class ShapeSprite: DrawableGameComponent
    {
        private IShape shape;
        private IBoard board;

        private Score score;
        private int counterMoveDown;

        private KeyboardState oldState;
        private int counterInput;
        private int threshold;

        private Game game;
        private SpriteBatch spriteBatch;

        private Texture2D filledBlock;

        public ShapeSprite(Game game, IBoard board, Score score): base(game)
        {
            this.game = game;
            this.score = score;
            shape = board.Shape;
        }

        public override void Initialize()
        {
            oldState = Keyboard.GetState();
            threshold = 6;
            counterInput = 0;
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            filledBlock = game.Content.Load<Texture2D>("FilledBlock");
            base.LoadContent();
        }

        public override void Update(GameTime gameTime)
        {
            checkInput();

            int dropDelay = (int)((11 - score.Level) * 0.5);
            if (counterInput == threshold)
            {
                if (counterMoveDown == dropDelay)
                {
                    shape.MoveDown();
                    counterMoveDown = 0;
                }
                else
                {
                    counterMoveDown++;
                }
                counterInput = 0;
            }
            else
                counterInput++;
        }

        public override void Draw(GameTime gameTime)
        {
            int size = 25;
            spriteBatch.Begin();
            for(int i = 0; i < shape.Length; i++)
            {
                System.Drawing.Color color = shape[i].Colour;
                spriteBatch.Draw(filledBlock, new Vector2(50 + shape[i].Position.X * size, 50 + shape[i].Position.Y * size), new Color(color.R, color.G, color.B));
            }
            spriteBatch.End();
        }

        private void checkInput()
        {
            KeyboardState newState = Keyboard.GetState();

            if (counterInput == threshold)
            {
                if (newState.IsKeyDown(Keys.Right))
                {
                    shape.MoveRight();
                }
                if (newState.IsKeyDown(Keys.Left))
                {
                    shape.MoveLeft();
                }
                if (newState.IsKeyDown(Keys.Down))
                {
                    shape.MoveDown();
                }
                if (newState.IsKeyDown(Keys.Up))
                {
                    shape.Drop();
                }
                if (newState.IsKeyDown(Keys.Space))
                {
                    shape.Rotate();
                }
                counterInput = 0;
            }
            else
                counterInput++;
        }
    }
}
