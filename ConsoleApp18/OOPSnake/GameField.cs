using ConsoleApp18.OOPSnake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp18
{
    public class GameField
    {
        public int Width { get; set; }
        public int Height { get; set; }

        Snake snake;
        Apple apple;

        public Snake Snake
        {
            get
            {
                return snake;
            }
        }

        public Apple Apple
        {
            get
            {
                return apple;
            }
        }

        Randomizer randomizer;

        public GameField()
        {
            randomizer = new Randomizer(this);
            randomizer.GenerateCoordinates(out int x,
                out int y);
            this.snake = new Snake(x, y);
            this.apple = new Apple(randomizer);
        }

        internal bool Intersect(int x, int y)
        {
            if (snake == null)
                return false;
            return snake.CheckSnakeIntersectCoordinate(x, y);
        }

        internal StepResult CalculateGameStep(Direction direction, DrawGame _drawGame)
        {
            _drawGame.CleanTail(Snake.Tail);
            Snake.Move(direction);
            _drawGame.DrawHead(Snake.Head);
            if (Snake.CheckSnakeEatSelf())
            {
                return StepResult.GameOver;
            }
            else if (Snake.CheckSnakeEatApple(Apple))
            {
                return StepResult.EatApple;
            }
            return StepResult.Nothing;
        }
    }
}
