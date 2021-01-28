using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Template.Scripts
{
    class SpriteCreator : Game1
    {
        private Texture2D In;
        private Texture2D Out;
        private Rectangle Source;

        public SpriteCreator(Texture2D _In, Rectangle _Source)
        {
            In = _In;
            Source = _Source;
        }

        public void LoadContent(ContentLoader Content)
        {
            
        }

        public void Draw(SpriteBatch spriteBatch, Rectangle Location)
        {
            spriteBatch.Draw(In, Location, Source, Color.White);
        }

    }
}
