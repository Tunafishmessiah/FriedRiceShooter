using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Media;

namespace FriedRiceShooter
{
    class Sprite
    {
        public Texture2D texture;
        public Vector2 Position;
        public Color color;


        public Sprite(Vector2 Pos)
        {
            color = Color.White;
            Position = Pos;
        }

        public void LoadContent(ContentManager content, string Path)
        {
            texture = content.Load<Texture2D>(Path);
        }

        public void Draw(SpriteBatch sprite)
        {
            sprite.Draw(texture, Position, color);
        }
    }
}
