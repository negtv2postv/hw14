using System;

namespace HW14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string food = "Mexican Dish";
            Console.WriteLine(food);
            Console.ReadKey();

            int quantity = 1;
            Console.WriteLine(quantity);
            Console.ReadKey();

            float size;
            size = 1.5f;
            Console.WriteLine(size);
            Console.ReadKey();

            double seconds;
            seconds = 2;
            Console.WriteLine(seconds);
            Console.ReadKey();

            bool authentic = true;
            Console.WriteLine(authentic);
            Console.ReadKey();

            string taste = "deliscious";
            Console.WriteLine(taste);
            Console.ReadKey();

            Console.WriteLine("This {0} of {1} serving is {2}", food, size, taste);
            Console.ReadKey();

            Console.Write("What is your fav mexican dish: ");
            string dishName = Console.ReadLine();
            Console.WriteLine(dishName);
            Console.ReadKey();

            Console.WriteLine("Puerto Riccan food" == "Mexican food");
            Console.WriteLine("I love != tacos");
            Console.WriteLine("One taco" ==  "two tacos");
            Console.WriteLine("one taco" != "one tacos");
            Console.ReadKey();
        }
    }
}
