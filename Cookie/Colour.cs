namespace ConsoleApp6
{
    public class Colour
    {
        private int red, green, blue;
        private string name;

        public Colour(int red, int green, int blue, string name)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.name = name;
        }

        public int Red
        {
            get => red;
            set => red = value;
        }

        public int Green
        {
            get => green;
            set => green = value;
        }

        public int Blue
        {
            get => blue;
            set => blue = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }
    }
}