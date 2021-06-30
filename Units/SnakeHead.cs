using SFML.System;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeIO.Units
{
    class SnakeHead : Actor
    {
        private Clock clock = new Clock();
        public SnakeHead()
        {
            SetTexture(ObjectsTextureDirectory.SnakeHead);
            sprite.Position = new Vector2f(100, 100);
        }
        public void Update()
        {
            UpdateSprite();
        }
        public void UpdateSprite()
        {
            float time = clock.ElapsedTime.AsSeconds();
            if (time > 0.1f)
            {
                if (size.Left == 320)
                {
                    size.Left = 0;
                }
                else
                {
                    size.Left += 64;

                }
                sprite.TextureRect = size;
                clock.Restart();
            }
        }
    }
}
