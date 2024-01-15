namespace Lab01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ex1
            Console.WriteLine("Ex 1");
            Circle c = new Circle(5.0d);
            c.getArea();
            c.getCircumference();
            Console.WriteLine(c.area + " " + c.circumference);
            Console.WriteLine(c);

            //ex2
            Console.WriteLine("Ex 2");
            Employee e = new Employee(1, "H", "T", 10000);
            e.getFullName();
            e.getAnnualSalary();
            Console.WriteLine("old salary: " + e.Salary + "old annual salary: " + e.AnnualSalary);
            e.raiseSalary(100);
            e.getAnnualSalary();
            Console.WriteLine("New Salary: " + e.Salary + " " + e.FullName + " New Annual Salary: " + e.AnnualSalary);
            Console.WriteLine(e);

            //ex3
            Console.WriteLine("Ex 3");
            Author ahTeck = new Author("Tan Ah Teck", "ahteck@nowhere.com", 'm'); // Test the constructor

            Console.WriteLine(ahTeck); // Test ToString()

            ahTeck.Email = "paulTan@nowhere.com"; // Test setter

            Console.WriteLine("Name is: " + ahTeck.Name); // Test getter

            Console.WriteLine("Email is: " + ahTeck.Email); // Test getter

            Console.WriteLine("Gender is: " + ahTeck.Gender);

            //ex4
            Console.WriteLine("Ex 4");
            // Construct an author instance

            Console.WriteLine(ahTeck); // Author's ToString()

            Book dummyBook = new Book("Java for dummy", ahTeck, 19.95, 99); // Test Book's Constructor

            Console.WriteLine(dummyBook); // Test Book's ToString()

            // Test Getters and Setters

            dummyBook.Price = 29.95;

            dummyBook.Quantity = 28;

            Console.WriteLine("name is: " + dummyBook.Name);

            Console.WriteLine("price is: " + dummyBook.Price);

            Console.WriteLine("qty is: " + dummyBook.Quantity);

            Console.WriteLine("Author is: " + dummyBook.Author); // Author's ToString()

            Console.WriteLine("Author's name is: " + dummyBook.Author.Name);

            Console.WriteLine("Author's email is: " + dummyBook.Author.Email);

            // Use an anonymous instance of Author to construct a Book instance

            Book anotherBook = new Book("more Java", new Author("Paul Tan", "paul@somewhere.com", 'm'), 29.95);

            Console.WriteLine(anotherBook); // ToString

            Console.WriteLine(dummyBook.Author.Name + " " + dummyBook.Author.Email);

            //ex5
            Console.WriteLine("Ex5");
            // Declare and allocate an array of Authors

            Author[] authors = new Author[2];

            authors[0] = new Author("Tan Ah Teck", "AhTeck@somewhere.com", 'm');

            authors[1] = new Author("Paul Tan", "Paul@nowhere.com", 'm');

            // Declare and allocate a Book instance

            Book1 javaDummy = new Book1("Java for Dummy", authors, 19.99, 99);

            Console.WriteLine(javaDummy); // ToString()
        }
    }
}
