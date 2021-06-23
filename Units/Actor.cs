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
        public float speed = 0.1f;
        public Actor()
        {

        }
        public void  SetTexture(string path)
        {
            Texture texture = new Texture(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + path);
            sprite = new Sprite(texture, size);
        }
        public void Move(Vector2f direction)
        {
            if (direction != new Vector2f(0, 0))
            {              
                sprite.Position += direction * speed;
                // directionXAbs and directionYAbs in the formule makes x or y 0 if it is 0.If vector is 0,1 ,then x for moving will be 0.
            }
        }
        public Vector2f GetCenter()
        {
            return new Vector2f(sprite.Position.X + sprite.Position.X/2, sprite.Position.Y + sprite.Position.Y / 2);
        }

    }
}
