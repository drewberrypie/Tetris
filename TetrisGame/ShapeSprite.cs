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

            int dropDelay = (int)((11 - score.Level) * 0.05);
            if (counterMoveDown == dropDelay)
            {
                shape.Drop();
                counterMoveDown = 0;
            }
            else
            {
                counterMoveDown++;
            }
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            int size = 25;
            //spriteBatch.Begin();
            base.Draw(gameTime);
        }

        private void checkInput()
        {

        }
    }
}
