using System;
using System.Drawing;

namespace MyGame
{
    abstract class BaseObject : ICollision
    {
        protected Point Pos;
        protected Point Dir;
        protected Size Size;

        protected BaseObject(Point pos, Point dir, Size size)
        {
            Pos = pos;
            Dir = dir;
            Size = size;
        }

        public Point Position // за пределами наследуемых классов можно получить значение Pos через этот геттер
        {
            get
            {
                return Pos;
            }
        }

        public abstract void Draw();
        public abstract void Update();

        public delegate void Message();

        // Так как переданный объект тоже должен будет реализовывать интерфейс ICollision, мы 
        // можем использовать его свойство Rect и метод IntersectsWith для обнаружения пересечения с
        // нашим объектом (а можно наоборот)
        public bool Collision(ICollision o) => o.Rect.IntersectsWith(this.Rect);

        public Rectangle Rect => new Rectangle(Pos, Size);




    }
}