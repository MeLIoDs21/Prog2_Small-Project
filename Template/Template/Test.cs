using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    class Test 
    {
        Texture2D _Object;
        Vector2 _Pos;
        Rectangle _HitBox;
        public Test(Vector2 pos)
        {



            _Pos = pos;
            _HitBox = new Rectangle(0, 0, 100, 100);
            
        }

        public void LoadContent(ContentManager Content)
        {
            
            _Object = Content.Load<Texture2D>("shuttle");
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(_Object, _HitBox, Color.Black);
            spriteBatch.End();
        }
    }
}
