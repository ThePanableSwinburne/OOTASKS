namespace ConsoleApp6
{
    public class Cookie
    {
        private int weight;
        private string shape;
        private Colour colour;

        public Cookie(int weight, string shape, Colour colour)
        {
            this.weight = weight;
            this.shape = shape;
            this.colour = colour;
        }

        public int Weight
        {
            get => weight;
            set => weight = value;
        }

        public string Shape
        {
            get => shape;
            set => shape = value;
        }

        public Colour Colour
        {
            get => colour;
            set => colour = value;
        }
    }
}