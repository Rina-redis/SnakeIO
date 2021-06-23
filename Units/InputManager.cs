using SFML.System;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeIO.Units
{
    class InputManager
    { 
        public Vector2f GetDirection()
        {
            if (Keyboard.IsKeyPressed(Keyboard.Key.W))
            {
                return new Vector2f(0, -1);
            }
            if (Keyboard.IsKeyPressed(Keyboard.Key.A))
            {
                return new Vector2f(-1, 0);
            }
            if (Keyboard.IsKeyPressed(Keyboard.Key.S))
            {
                return new Vector2f(0, 1);
            }
            if (Keyboard.IsKeyPressed(Keyboard.Key.D))
            {
                return new Vector2f(1, 0);
            }
            return new Vector2f(0, 0);
        }
    }
}
