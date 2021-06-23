using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeIO
{
    class Food : Actor
    {
        public Food()
        {
            SetTexture(ObjectsTextureDirectory.Food);
        }
    }
}
