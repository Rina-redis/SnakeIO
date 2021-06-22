using SFML.Graphics;
using SFML.Window;
using System;
using System.Collections.Generic;

namespace SnakeIO
{
    class Game
    {
        private UI gameUI = new UI();
        Snake snake = new Snake();
        SnakePart snakePart = new SnakePart();
        public void Start()
        {
            SetupGame();
            while (CanPlay())
            {
                GameCycle();
            }
        }
        private void GameCycle()
        {       
            LogicPart();
            UiPart();
        }
        private void SetupGame()
        {
            gameUI.Init();
            

        }

        private void LogicPart()
        {
           
        }
        private void UiPart()
        {
            gameUI.DrawObject(snake.sprite);
            gameUI.DrawObject(snakePart.sprite);
            //   gameUI.ClearWindow();

            //  DrawAllObjects();
            gameUI.Dispatch();
        }

        private void ActorsCycle()
        {

        }

        private void ConnectEvents()
        {
            gameUI.window.KeyPressed += OnKeyPressed; //kak to po ploho...
          //  gameUI.window.MouseMoved += heroController.MouseMoved;
            gameUI.window.Closed += WindowClosed;
        }

        private void OnKeyPressed(object sender, KeyEventArgs e)
        {
            if (e.Code == Keyboard.Key.F)
            {

            }
            while (Keyboard.IsKeyPressed(Keyboard.Key.Space))
            {

            }
        }
        private static void WindowClosed(object sender, EventArgs e)
        {
            RenderWindow w = (RenderWindow)sender;
            w.Close();
        }

        private bool CanPlay()
        {

            return true;
        }
        private void DrawAllObjects()
        {

        }
    }
  
}
