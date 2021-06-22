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
        public Snake()
        {
            SetTexture(ObjectsTextureDirectory.SnakeHead);
          
            
        }
        public void IncreaseLenght() => currentLenght++;
    }
}
