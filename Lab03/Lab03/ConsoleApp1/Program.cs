namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ex1
            Console.WriteLine("ex1");
            Triangle t = new Triangle("red", 2, 4);
            Console.WriteLine(t.GetArea());
            Console.WriteLine(t);

            Rectangle r = new Rectangle("white", 3, 9);
            Console.WriteLine(r.GetArea());
            Console.WriteLine(r);

            //ex2
            Console.WriteLine("ex2");
            MovablePoint m = new MovablePoint(0, 0);

            Console.WriteLine("Old position: " + m);

            m.MoveUp();
            m.MoveLeft();
            Console.WriteLine("After moving up and left: " + m);

            m.MoveDown();
            m.MoveRight();
            Console.WriteLine("After moving down and right: " + m);

            //ex3
            Spider s = new Spider();
            s.Eat();

            Cat c = new Cat("Cat");
            c.Eat();
            c.Play();
            c.Walk();

            Fish f = new Fish("Fish");
            f.Eat();
            f.Walk();
            f.Play();
        }
    }
}
