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
    class ContentLoader : Game1
    {
        private const int Width = 80;
        private const int Height = 100;





        private Texture2D Main;
        public SpriteCreator TrexIdle;
        public SpriteCreator TrexIdle2;
        public void ContentLoad(ContentManager Content)
        {
            Main = Content.Load<Texture2D>("Main");
            TrexIdle = new SpriteCreator(Main, new Rectangle(80, 1, Width, Height));
            TrexIdle = new SpriteCreator(Main, new Rectangle(1770, 1, Width, Height));
            
        }
    }
}
