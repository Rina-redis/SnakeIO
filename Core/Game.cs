using SFML.Graphics;
using SFML.Window;
using SnakeIO.Units;
using System;
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
            gameUI.Init();
            gameUI.SetObjectsToDraw(snake.sprites);
            Thread uiThread = new Thread(gameUI.Start);
            uiThread.Start();
          
            ConnectEvents();
        }

        private void LogicPart()
        {          
            snake.Update();
            snake.Move(inputManager.GetDirection());          
        }
        private void UiPart()
        {
            DrawAllObjects();
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
            foreach (Sprite sprite in snake.sprites)
            {
                gameUI.DrawObject(sprite);
            }
        }
    }
  
}
