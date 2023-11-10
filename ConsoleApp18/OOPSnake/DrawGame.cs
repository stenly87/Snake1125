using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18.OOPSnake
{
    public class DrawGame
    {
        Graphics graphics;
        Font font;
        Font gameOverFont;
        public int TextX { get; set; }
        public int TextY { get; set; }

        public DrawGame()
        {
            graphics = Graphics.FromHwnd(
                Process.GetCurrentProcess().MainWindowHandle);
            graphics.Clear(Color.Black); // очистка экрана

            font = new Font(FontFamily.GenericSansSerif, 20);
            gameOverFont = new Font(FontFamily.GenericSansSerif, 50);
        }
        internal void CleanTail(SnakeTail tail)
        {
            graphics.FillEllipse(Brushes.Black, tail.X, tail.Y, 10, 10);
        }

        internal void DrawHead(SnakeHead head)
        {
            graphics.FillEllipse(Brushes.Green, head.X, head.Y, 10, 10); // нарисовать красный круг размером 10 на 10 по координатам нулевой ячейки змейки
        }
        internal void DrawScores(int amount)
        {
            graphics.FillRectangle(Brushes.Black, TextX, TextY, 200, 50);
            graphics.DrawString($"Кол-во очков {amount}", font, Brushes.White, TextX, TextY);
        }

        internal void GameOver()
        {
            graphics.Clear(Color.Black);
            graphics.DrawString("Потрачено", gameOverFont, Brushes.Red, 100, 100);
        }

        internal void DrawApple(Apple apple)
        {
            graphics.FillEllipse(Brushes.Red, apple.X, apple.Y, 10, 10); // нарисовать красный круг размером 10 на 10 по координатам нулевой ячейки змейки
        }
    }
}
