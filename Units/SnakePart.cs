using System;
using System.Collections.Generic;
using System.Text;
using SFML.System;

namespace SnakeIO
{
    class SnakePart : Actor
    {
        public SnakePart()
        {
            SetTexture(ObjectsTextureDirectory.SnakePart);
            sprite.Position = new Vector2f(300, 300);
        }
    }
}
