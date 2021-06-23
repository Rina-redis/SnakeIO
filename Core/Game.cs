using SFML.Graphics;
using SFML.Window;
using SnakeIO.Units;
using System;
using System.Collections.Generic;
using System.Threading;

namespace SnakeIO
{
    class Game
    {
        public UI gameUI = new UI();
        private InputManager inputManager = new InputManager();
        Snake snake = new Snake();
 
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
           // Thread uiThread = new Thread(gameUI.Start);
          //  uiThread.Start();
            gameUI.Init();
            ConnectEvents();
           
          //  gameUI.snaketemp = snake.sprite;
            // gameUI.drawable.Add(snake.sprite);

        }

        private void LogicPart()
        {          
            snake.Update();
            snake.Move(inputManager.GetDirection());          
        }
        private void UiPart()
        {
            gameUI.DrawObject(snake.sprite);
            gameUI.ClearWindow();
           
            gameUI.Dispatch();
        }

        private void ActorsCycle()
        {

        }

        private void ConnectEvents()
        {         
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
