using System;
using System.Collections.Generic;
using System.Text;
using SFML.Graphics;
using SFML.System;
using System.IO;
using SnakeIO.Units;

namespace SnakeIO
{
    class Snake 
    {
        private int currentLenght = 5;
        private SnakeHead head;
        private List<SnakePart> body = new List<SnakePart>();
        public List<Sprite> sprites = new List<Sprite>();
        public Snake()
        {
            head = new SnakeHead();
            CreateBody();     
        }
        public void IncreaseLenght() => currentLenght++;
        public void Move(Vector2f direction)
        {
           head.MoveByVector(direction);
           Console.WriteLine(head.sprite.Position);
           Console.WriteLine(body[0].sprite.Position);
           for (int snakePartNumber = 0; snakePartNumber<body.Count; snakePartNumber++)
            {
                if(snakePartNumber == 0)
                {
                    body[snakePartNumber].MoveToPoint(head.sprite.Position);
                }
                else
                {
                    var previousSnakePart = body[snakePartNumber - 1];
                    body[snakePartNumber].MoveToPoint(previousSnakePart.sprite.Position);
                }
               
            }
        }
        public void Update()
        {
        
            
        }
        private void CreateBody()
        {
            sprites.Add(head.sprite);
            for (int i = 0; i < currentLenght - 1; i++)
            {
                SnakePart snakePart = new SnakePart();
                body.Add(snakePart);
                sprites.Add(snakePart.sprite);
            }
        }
    }
}
