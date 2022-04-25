namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Colour red = new Colour(255, 0, 0, "red");
            Colour green = new Colour(0, 255, 0, "green");
            
            Cookie cookie1 = new Cookie(200, "round?", red);
            Cookie cookie2 = new Cookie(200, "round?", red);
            Cookie cookie3 = new Cookie(200, "star?", green);
            Cookie cookie4 = new Cookie(200, "star?", green);
            
        }
    }
}
