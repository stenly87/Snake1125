using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Diagnostics;
using System.Threading;
using ConsoleApp18.OOPSnake;

namespace ConsoleApp18
{
    partial class Program
    {
        static void Main(string[] args)
        {
            DrawGame drawGame = new DrawGame { TextX = 250, TextY = 10 };
            
            new Game(new GameField(120, 120, drawGame),
                new Scores(),
                drawGame);

            Console.ReadLine(); // остановка программы при остановке игры
        }
    }
}
