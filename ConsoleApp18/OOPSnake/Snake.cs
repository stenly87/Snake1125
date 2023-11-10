using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace ConsoleApp18
{
    public class Snake
    {
        SnakeHead _head;
        SnakeTail _tail;

        public SnakeHead Head
        {
            get
            {
                return _head;
            }
        }

        public SnakeTail Tail
        {
            get
            {
                Tail.X = cells.Last().X;
                Tail.Y = cells.Last().Y;
                return _tail;
            }
        }

        List<SnakeCell> cells;

        public Snake(int x, int y)
        {
            cells = new List<SnakeCell>();
            _head = new SnakeHead { X = x, Y = y };
            _tail = new SnakeTail();
            cells.Add(_head);
        }

        public void Move(Direction direction)
        {
            ReindexBody();
            CalcNewHeadCoordinate(direction);
        }

        public bool CheckSnakeEatApple(Apple apple)
        {
            if (apple.X == Head.X && apple.Y == Head.Y)
            {
                Increase();
                apple.Generate();
                return true;
            }
            return false;
        }

        public bool CheckSnakeIntersectCoordinate(int x, int y)
        {
            for (int i = 0; i < cells.Count; i++)
                if (x == cells[i].X && y == cells[i].Y)
                {
                    return true;
                }
            return false;
        }

        private void Increase()
        {
            SnakeTail snakeTail = new SnakeTail
            { X = Tail.X, Y = Tail.Y };
            cells.Add(snakeTail);
        }

        public bool CheckSnakeEatSelf()
        {
            for (int i = 1; i < cells.Count; i++)
            {
                if (cells[i].X == Head.X && cells[i].Y == Head.Y)
                    return true;// вернуть true, если координаты нулевой ячейки змейки совпадают с одной из других ее ячеек
            }
            return false;
        }

        private void CalcNewHeadCoordinate(Direction direction)
        {
            if (direction == Direction.Up)
                Head.Y -= 10;
            if (direction == Direction.Right)
                Head.X += 10;
            if (direction == Direction.Down)
                Head.Y += 10;
            if (direction == Direction.Left)
                Head.X -= 10;
        }

        private void ReindexBody()
        {   // сдвиг ячеек внутри змейки
            // нужно для отслеживания пересечения змейки с головой
            int maxIndex = cells.Count - 1;
            if (maxIndex == 0)
                return;
            for (int i = maxIndex; i > 0; i--)
            {
                cells[i].X = cells[i - 1].X;
                cells[i].Y = cells[i - 1].Y;
            }
        }


    }

    public class SnakeCell
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class SnakeHead : SnakeCell
    {

    }

    public class SnakeTail : SnakeCell
    {

    }
}