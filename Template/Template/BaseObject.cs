using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Template
{
    class BaseObject
    {
        Texture2D _Object;
        Vector2 _Pos;
        Rectangle _HitBox;
        public BaseObject(Vector2 pos, Rectangle hitBox)
        {

            _Pos = pos;
            _HitBox = hitBox;

        }

        public void LoadContent(ContentManager content, string fileName)
        {
            _Object = content.Load<Texture2D>(fileName);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(_Object, _HitBox, Color.Black);
            spriteBatch.End();
        }
    }
}
