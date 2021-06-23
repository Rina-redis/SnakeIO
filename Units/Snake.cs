using System;
using System.Collections.Generic;
using System.Text;
using SFML.Graphics;
using SFML.System;
using System.IO;

namespace SnakeIO
{
    class Snake : Actor
    {
        private int currentLenght = 2;
       
        private Clock clock;
        public List<SnakePart> body = new List<SnakePart>();
        public Snake()
        {
            SetTexture(ObjectsTextureDirectory.SnakeHead);
            clock = new Clock();
        }
        public void IncreaseLenght() => currentLenght++;
        public void Update()
        {
            UpdateSprite();
            //for (int i = 0; i < currentLenght - 1; i++)
            //{
            //    SnakePart snakePart = new SnakePart();
            //    body.Add(snakePart);
            //}
        }
        public void UpdateSprite()
        {
          //  while (needToUpdateSprite)
          //  {
                float time = clock.ElapsedTime.AsSeconds();
                if(time> 0.1f)
                {
                    if (size.Left == 320)
                    {
                        size.Left = 0;
                    }
                    else
                    {
                       // size = new IntRect(size.Left + 64, size.Top, size.Width, size.Height);
                        size.Left += 64;
                       // size.Width += 64;
                    }

                    sprite.TextureRect = size;
                    clock.Restart();
                
              //  }
            }
        }
    }
}
