using System;


//namespace YouveGotClassLab
//{
    public class Parallelogram
    {
        public int Length;
        public int Width;
        public double GetArea()
        {
            return Length * Width;
        }
        public double GetPerimeter()
        {
            return Length + Length + Width + Width;
        }
        public void Print()
        {
            Console.WriteLine("This is your Parallelogram!");
            Console.WriteLine($"The length is: \t{Length}");
            Console.WriteLine($"The width is: \t{Width}");
            Console.WriteLine($"The area is: \t{GetArea()}");
            Console.WriteLine($"The Perimeter is: \t{GetPerimeter()}");
        }
        public void Resize(int adjustedL, int adjustedW)
        {
            if (adjustedL < 0)
            {
                Console.WriteLine("The value provided for Length is less then 0!");
                return;
            }
            if (adjustedW < 0)
            {
                Console.WriteLine("The value provided for Width is less then 0!");
                return;
            }
            Length = adjustedL;
            Width = adjustedW;
        }
    }
    public class Book
    {
        public string Title;
        public string lastName;
        public string firstName;
        public string ISBN;
        public string Pub;
        public int Copies;

        public void Sell(int sold)
        {
            Copies = Copies - sold;
        }
        public void Print2()
        {
            Console.WriteLine($"The books title is :{Title}");
            Console.WriteLine($"The Author's name is: {firstName} {lastName}");
            Console.WriteLine($"Its ISBN number is: {ISBN}");
            Console.WriteLine($"The publisher of the book is: {Pub}");
            Console.WriteLine($"This book sold: {Copies} copies.");
        }


    }


    class Program
    {
        static public void ProgChoice()
        {
            Console.WriteLine("Would you like to see Parallelograms or Books? P/B");
            string resp = Console.ReadLine();
            resp.ToLower();
            if (resp == "p")
            {
                Parallelogram ParA = new Parallelogram() { Length = 20, Width = 30 };
                ParA.Print();
                Console.WriteLine();
                ParA.Resize(100, 50);
                ParA.Print();
                Console.WriteLine();

                Parallelogram ParB = new Parallelogram() { Length = 50, Width = 1000 };
                ParB.Print();
                Console.WriteLine();
                ParB.Resize(75, -50);
                ParB.Print();
                Console.WriteLine();


            }
            else
            {
                Book bookA = new Book() { Title = "Intensity", lastName = "Koontz", firstName = "Dean", ISBN = "9780345384362", Pub = "Balantine Books", Copies = 1000000 };
                bookA.Print2();
                Console.WriteLine();
                Console.WriteLine("There was a mistake! We sold 75000 less copies then we thought!  Here is the adjusted information");
                bookA.Sell(75000);
                bookA.Print2();
                Console.WriteLine();

                Book bookB = new Book() { Title = "Insomnia", lastName = "King", firstName = "Stephen", ISBN = "9780345387999", Pub = "Random House", Copies = 10000000 };
                bookB.Print2();
                Console.WriteLine();
                Console.WriteLine("There was a mistake! We sold 1500000 less copies then we thought!  Here is the adjusted information");
                bookB.Sell(1500000);
                bookB.Print2();
                Console.WriteLine();

                Book bookC = new Book() { Title = "Arrow's Fall", lastName = "Lackey", firstName = "Mercedes", ISBN = "9780345381111", Pub = "Tor", Copies = 257139 };
                bookC.Print2();
                Console.WriteLine();
                Console.WriteLine("There was a mistake! We sold 200000 less copies then we thought!  Here is the adjusted information");
                bookC.Sell(200000);
                bookC.Print2();
                Console.WriteLine();
            }
            
        
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the class program.");
            ProgChoice();
        }
    }

//}
