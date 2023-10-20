using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    partial class Program
    {
        private static void CheckPressedKey(ConsoleKeyInfo key)
        {
            // проверить кнопку можно через свойство key.Key
            // Если кнопка совпадает с кнопкой вверх, то direction установить в 1
            // Если кнопка совпадает с кнопкой направо, то direction установить в 2
            // Если кнопка совпадает с кнопкой вниз, то direction установить в 3
            // Если кнопка совпадает с кнопкой налево, то direction установить в 4
            // Добавить кнопку для выхода, запускать метод GameOver
            // Если кнопка совпадает с пробелом, то запустить метод ChangeGamePause
            
            if (key.Key == ConsoleKey.UpArrow && direction != 3)
                direction = 1;
            if (key.Key == ConsoleKey.RightArrow && direction != 4)
                direction = 2;
            if (key.Key == ConsoleKey.DownArrow && direction != 1)
                direction = 3;
            if (key.Key == ConsoleKey.LeftArrow && direction != 2)
                direction = 4;
            if (key.Key == ConsoleKey.Escape)
                GameOver();
            if (key.Key == ConsoleKey.Spacebar)
                ChangeGamePause();
        }
    }
}
