using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    partial class Program
    {
        private static void DrawHead()
        {
            graphics.FillEllipse(System.Drawing.Brushes.YellowGreen, snake[0][0], snake[0][1], 10, 10); // Ты
        }
    }
}
