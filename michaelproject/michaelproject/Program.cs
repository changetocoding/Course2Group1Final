// See https://aka.ms/new-console-template for more information

namespace michaelproject
{
    class program
    {
        static void Main(string[] args)
        {
            string num1;
            string num2;
            string op;
            Console.WriteLine("Enter the first number");
            num1 = Console.ReadLine();
            Console.WriteLine("Enter the second number");
            num2 = Console.ReadLine();
            Console.WriteLine("choose your operator");
            Console.WriteLine("The operators are +, -, *, /, mod");
            op = Console.ReadLine();
            if (op == "+")
            {
                Console.WriteLine("The result is");
                Console.WriteLine(int.Parse(num1) + int.Parse(num2));
            }
            else if (op == "-")
            {
                Console.WriteLine("The result is");
                Console.WriteLine(int.Parse(num1) - int.Parse(num2));
            }
            else if (op == "*")
            {
                Console.WriteLine("The result is");
                Console.WriteLine(int.Parse(num1) * int.Parse(num2));
            }
            else if (op == "/")
            {
                Console.WriteLine("The result is");
                Console.WriteLine(int.Parse(num1) / int.Parse(num2));
            }
            else
            {
                Console.WriteLine("Enter a valid operator");

            }
            Animal animal1 = new Animal();
            animal1._name = "Name: Cow";
            animal1._eye = 2;
            animal1._true = true;

            Animal animal2 = new Animal("Name: Sheep", 2, true);


            Animal animal3 = new Animal("Name: Goat", 2, true);

            Console.WriteLine(animal1._name);
            Console.WriteLine(animal1._eye);
            Console.WriteLine(animal1._true);

            Console.WriteLine(animal2._name);
            Console.WriteLine(animal2._eye);
            Console.WriteLine(animal2._true);

            Console.WriteLine(animal3._name);
            Console.WriteLine(animal3._eye);
            Console.WriteLine(animal3._true);

        }
    }

  
}
