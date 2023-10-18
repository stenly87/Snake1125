using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    partial class Program
    {
        private static void IncreaseSnake()
        {
            // надо взять последнюю ячейку змейки и добавить в коллекцию snake еще одну ячейку с такими же значениями
            int[] last = { snake.Last()[0], snake.Last()[1] };
            snake.Add(last);
        }
    }
}
