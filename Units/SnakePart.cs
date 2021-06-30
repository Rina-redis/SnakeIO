using System;
using System.Collections.Generic;
using System.Text;
using SFML.System;

namespace SnakeIO
{
    class SnakePart : Actor
    {
        private Vector2f directionToMove;
        public SnakePart()
        {
            SetTexture(ObjectsTextureDirectory.SnakePart);
            sprite.Position = new Vector2f(0, 0);
        }
        public void Update()
        {
            MoveToPoint(directionToMove);
        }
    }
}
