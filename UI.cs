﻿using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeIO
{
    class UI
    {
        private Font font;
        public RenderWindow window;

        public void DrawObject(Drawable shape)
        {
            window.Draw(shape);
        }
        public void ClearWindow()
        {
            window.Clear(Color.White);
        }
        public void Init()
        {
            font = new Font(@"H:\програмирование\AgarIO\bin\Debug\Data\milk.otf");
            window = SetupRenderWindow();
        }
        private RenderWindow SetupRenderWindow()
        {
            RenderWindow window = new RenderWindow(new VideoMode(Constants.windowWidth, Constants.windowHeight), "Game window");
            window.SetFramerateLimit(1000);

            return window;
        }
        public void DrawText(int radius)
        {
            Text textWithRadius = new Text("Current radius:  " + radius.ToString(), font);
            textWithRadius.CharacterSize = 24;
            textWithRadius.FillColor = Color.Red;
            textWithRadius.Position = new Vector2f(100, 100);
            DrawObject(textWithRadius);
        }
        public void Dispatch()
        {
            window.DispatchEvents();
            window.Display();
        }
    }
}
