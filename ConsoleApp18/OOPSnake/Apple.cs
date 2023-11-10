namespace ConsoleApp18
{
    public class Apple
    {
        private readonly Randomizer randomizer;

        int _x;
        int _y;
        public int X 
        {
            get { return _x; }
            set { _x = value; }
        }
        public int Y 
        {
            get { return _y; }
            set { _y = value; }
        }

        public Apple(Randomizer randomizer)
        {
            this.randomizer = randomizer;
            Generate();
        }

        public void Generate()
        {
            randomizer.GenerateCoordinates(out _x, out _y);
        }
    }
}