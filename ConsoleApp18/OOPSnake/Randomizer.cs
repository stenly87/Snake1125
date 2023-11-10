using System;

namespace ConsoleApp18
{
    public class Randomizer
    {
        GameField field;
        Random rnd = new Random();

        public Randomizer(GameField field)
        {
            this.field = field;
        }

        internal void GenerateCoordinates(out int x, out int y)
        {
            /* другой вариант решения
            var cells = field.GetFreeCells();
            int index = rnd.Next(0, cells.Count);
            return cells[index];
            */
            do
            {
                x = rnd.Next(0, field.Width/10)*10;
                y = rnd.Next(0, field.Height/10)*10;
            }
            while (field.Intersect(x,y));
        }
    }
}