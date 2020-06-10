using System;
using System.Drawing;

namespace MyGame
{
    class UFO : BaseObject
    {
        protected Double Radius;
        protected Double Angle;
        protected Double Speed;

        public UFO(Point pos, Double radius, Double angle, double speed, Size size) : base (pos, pos, size)
        {
            Pos = pos;
            Radius = radius;
            Angle = angle;
            Size = size;
            Speed = speed;
        }

        public override void Draw()
        {
            int x = (int) (Radius * (Math.Cos(Angle)));
            int y = (int) (Radius * (Math.Sin(Angle)));
            Game.Buffer.Graphics.DrawRectangle(Pens.White, Pos.X+x, Pos.Y+y, Size.Width, Size.Height);
        }
        public override void Update()
        {
            Angle += Speed;
        }
    }
}