using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp18.OOPSnake
{
    internal class Control
    {
        private bool controlBlock;
        Game game;

        public Control(Game game)
        {
            this.game = game;
        }

        public void RunControl()
        {
            while (game.Status != Status.GameOver)
            {   // в цикле читаем нажатую кнопку.
                ConsoleKeyInfo key = Console.ReadKey();
                Console.SetCursorPosition(100, 0);
                if (controlBlock)   // если controlBlock стоит в значении true, то переход к следующей итерации
                    continue;
                controlBlock = true; // временная блокировка управления, снимается в GetNextCoordinates
                //var oldDirection = game.Direction;
                CheckPressedKey(key); // меняем направление по клавишам
                if (game.Status == Status.Pause)
                    controlBlock = false;
                
            }
        }

        private void CheckPressedKey(ConsoleKeyInfo key)
        {
            if (key.Key == ConsoleKey.UpArrow)
                game.Direction = Direction.Up;
            if (key.Key == ConsoleKey.RightArrow)
                game.Direction = Direction.Right;
            if (key.Key == ConsoleKey.DownArrow)
                game.Direction = Direction.Down;
            if (key.Key == ConsoleKey.LeftArrow)
                game.Direction = Direction.Left;
            if (key.Key == ConsoleKey.Escape)
                game.GameOver();
            if (key.Key == ConsoleKey.Spacebar)
                game.ChangeGamePause();
        }

        internal void FreeBlock()
        {
            controlBlock = false;
        }
    }
}
