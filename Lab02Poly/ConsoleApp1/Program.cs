namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ex1
            Console.WriteLine("Ex1: ");
            Shape s1 = new Rectangle("red", 4, 5); // Upcast

            Console.WriteLine(s1); // Run Rectangle's toString()

            Console.WriteLine("Area is " + s1.getArea()); // Run Rectangle's getArea()

            Shape s2 = new Triangle("blue", 4, 5); // Upcast

            Console.WriteLine(s2); // Run Triangle's toString()

            Console.WriteLine("Area is " + s2.getArea()); // Run Triangle's getArea()

            //ex2
            Console.WriteLine("Ex2: ");
            Circle c = new Circle(5);
            Console.WriteLine(c);

            Console.WriteLine("Circle area: " + c.GetArea());

            Cylinder cy = new Cylinder(9);

            Console.WriteLine(cy);
            Console.WriteLine("Cylinder area: " + cy.GetArea());
        }
    }
}
