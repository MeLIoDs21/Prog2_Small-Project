using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Template.Scripts
{
    class Player : ContentLoader
    {
        public Texture2D Texture { get; private set; }
        public Vector2 Position { get; private set; }


    }
}
