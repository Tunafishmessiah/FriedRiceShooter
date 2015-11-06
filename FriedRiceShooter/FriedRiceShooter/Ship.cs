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
    class Ship : Sprite
    {
        int HitPoints;
        const int speed = 20;
        GraphicsDeviceManager graphics;

        public Ship(Vector2 position, GraphicsDeviceManager graphics)
            : base(position)
        {
            this.HitPoints = 10;
            this.graphics = graphics;
        }

        public void MoveRight()
        {
            this.Position = new Vector2(this.Position.X + speed, this.Position.Y);

            if (this.Position.X > this.graphics.PreferredBackBufferWidth)
            {
                this.Position.X = 0 - this.texture.Width;
            }
        }
        public void MoveLeft()
        {
            this.Position = new Vector2(this.Position.X - speed, this.Position.Y);

            if (this.Position.X < 0 - this.texture.Width)
            {
                this.Position.X = this.graphics.PreferredBackBufferWidth;
            }
        }
        public void MoveUp()
        {
            this.Position = new Vector2(this.Position.X, this.Position.Y - speed);

            if (this.Position.Y < 0 - this.texture.Height)
            {
                this.Position.Y = this.graphics.PreferredBackBufferHeight;
            }
        }
        public void MoveDown()
        {
            this.Position = new Vector2(this.Position.X, this.Position.Y + speed);

            if (this.Position.Y > this.graphics.PreferredBackBufferHeight)
            {
                this.Position.Y = 0 - this.texture.Height;
            }
        }

        public void Hit()
        {
            this.HitPoints = this.HitPoints--;
        }

        public int GetHp()
        { return this.HitPoints; }
    }
}