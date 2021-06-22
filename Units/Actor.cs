using SFML.Graphics;
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
        public Actor()
        {

        }
        public void  SetTexture(string path)
        {
            Texture texture = new Texture(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + path);
            sprite = new Sprite(texture, size);
        }

    }
}
