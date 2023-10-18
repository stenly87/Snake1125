

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    partial class Program
    {
        private static bool CheckSnakeIntersect()
        {
            int a = snake[0][0];
            int b = snake[0][1];

            for (int i = 1; i < snake.Count; i++)
            {
                if (snake[i][0] == a && snake[i][1] == b)
                    return true;// вернуть true, если координаты нулевой ячейки змейки совпадают с одной из других ее ячеек
            }
            return false;
        }
    }
}
