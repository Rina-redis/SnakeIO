using SFML.Graphics;
using SFML.System;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeIO
{
    class UI
    {
        private Font font;
        public RenderWindow window;
        public List<Drawable> drawable = new List<Drawable>();
        public Sprite snaketemp;
        private Clock clock = new Clock();

        public void DrawObject(Drawable shape)
        {
            if(shape!= null)
            {
                window.Draw(shape);
            }
           
        }
        public void ClearWindow()
        {
            float time = clock.ElapsedTime.AsSeconds();
            if (time > 0.001f)
            {
                window.Clear(Color.Black);
                clock.Restart();
            }         
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
        public void SetObjectsToDraw(List<Drawable> objectsToDraw)
        {
            
        }
        public void Start()
        {
            Init();
            while (true)
            {
                //for(int i = 1; i<= drawable.Count; i++)
                // {
                //     DrawObject(drawable[i-1]);
                // }      
                DrawObject(snaketemp);
            }
        }
    }

    public static class ObjectsTextureDirectory
    {
        public static string Food = @"\Content\apple.png";
        public static string SnakePart = @"\Content\snake_part.png";
        public static string SnakeHead = @"\Content\snake_head_list.png";

    }
}
