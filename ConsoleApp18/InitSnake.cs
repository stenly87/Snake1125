using System.Collections.Generic;
namespace ConsoleApp18
{
    partial class Program
    {
        private static void InitSnake()
        {
            // проиинициализировать коллекцию snake
            // добавить в коллекцию ячейку со значением {10, 10}. Это будут начальные координаты змейки
            // direction установить направо
            // speed назначить в 250 мс. это скорость движения змейки

            snake = new List<int[]>();
            int [] znachenia = { 20, 20 };
            snake.Add(znachenia);
            direction = 2;
            speed = 250;
        }
    }
}