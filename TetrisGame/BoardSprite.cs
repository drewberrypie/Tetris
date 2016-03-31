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
    class BoardSprite
    {
        IBoard board;

        Game game;
        SpriteBatch spriteBatch;

        Texture2D emptyBlock;
        Texture2D filledBlock;

        public BoardSprite(Game game, IBoard board)
        {
            this.game = game;
            this.board = board;
        }

        public void Initialize()
        {
            
        }

        protected void LoadContent()
        {

        }

        public void Update(GameTime gameTime)
        {

        }

        public void Draw(GameTime gameTime)
        {

        }
    }
}
