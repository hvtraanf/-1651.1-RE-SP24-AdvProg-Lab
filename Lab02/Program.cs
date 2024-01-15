namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inheritance eg 2

            Console.WriteLine("Inheritance eg2");

            Point2d p2a = new Point2d(1, 2);
            Console.WriteLine(p2a);
            Point2d p2b = new Point2d();
            Console.WriteLine(p2b);

            //Test Setters and Getters
            p2a.x = 3;
            p2b.y = 4;
            Console.WriteLine(p2a);
            Console.WriteLine("x is: " + p2a.x);
            Console.WriteLine("y is: " + p2a.y);

            /* Test Point3d*/
            // Test constructors and toString()
            Point3d p3a = new Point3d(11, 12, 13);
            Console.WriteLine(p3a);
            Point2d pb3 = new Point3d();

            Console.WriteLine(p3a);
            //Test setters and getters
            p3a.x = 21;
            p3a.y = 22;
            p3a.z = 23;
            Console.WriteLine(p3a);
            Console.WriteLine("x is: " + p3a.x);
            Console.WriteLine("y is: " + p3a.y);
            Console.WriteLine("z is: " + p3a.z);


            // Inheritance eg 4

            Console.WriteLine("Inheritance eg 4");

            Circle c = new Circle(9, "Blue", true);
            Console.WriteLine(c);
            Console.WriteLine(c.getArea() + " " + c.getPerimeter());

            Rectangle r = new Rectangle(5, 10, "Grey", false);
            Console.WriteLine(r);
            Console.WriteLine(r.getArea() + " " + r.getPerimeter());

            Square s = new Square(5);
            Console.WriteLine(s);
            Console.WriteLine(s.getArea()+ " " + s.getPerimeter());

            s.Side = 4;
            Console.WriteLine(s.getArea() + " " + s.getPerimeter());

            s.Side = 8;
            Console.WriteLine(s.getArea() + " " + s.getPerimeter());
        }
    }
}
