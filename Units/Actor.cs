using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SnakeIO
{
    class Actor
    {
        public IntRect size = new IntRect(0, 0, 64, 64);
        public Sprite sprite;
        public float speed = 0.001f;
        public Actor()
        {

        }
        public void  SetTexture(string path)
        {
            Texture texture = new Texture(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + path);
            sprite = new Sprite(texture, size);
        }
        public void MoveToPoint(Vector2f direction)
        {
            if (direction != new Vector2f(0, 0))
            {
                float distance = MathHelper.DistanceToPoint(GetCenter(), direction);
                //if (distance > 10)
                //{
                //    speed = 0.1f;
                //}
                Vector2f directionTemp = new Vector2f( (direction.X - GetCenter().X)/distance,
                                                       (direction.Y - GetCenter().Y)/ distance);
                Vector2f newPos = sprite.Position;
                newPos += directionTemp;
                sprite.Position = newPos;
            }
            
        }
        public void MoveByVector(Vector2f direction)
        {
            sprite.Position += direction * 0.1f;
        }
        public Vector2f GetCenter()
        {
            return new Vector2f(sprite.Position.X + sprite.Position.X/2, sprite.Position.Y + sprite.Position.Y / 2);
        }

    }
}
