// See https://aka.ms/new-console-template for more information


namespace michaelwork
{
    class Program
    {
       static void Main(string[] args)
        {
            Console.WriteLine("                                               CALCULATOR APP");

            string num1;
            string num2;
            string op;

            Console.WriteLine("Enter the first number");
            num1 = Console.ReadLine();
            Console.WriteLine("Enter the second number");
            num2 = Console.ReadLine();
            Console.WriteLine("Choose and operator");
            Console.WriteLine("The operators are +, -, *, /");
            op = Console.ReadLine();
            if (op == "+")
            {
                Console.WriteLine("                                               The result is");
                Console.WriteLine(int.Parse(num1) + int.Parse(num2));
            }
            else if (op == "-")
            {
                Console.WriteLine("                                               The result is");
                Console.WriteLine(int.Parse(num1) - int.Parse(num2));
            }
            else if (op == "*")
            {
                Console.WriteLine("                                               The result is");
                Console.WriteLine(int.Parse(num1) * int.Parse(num2));
            }
            else if (op == "/")
            {
                Console.WriteLine("                                               The result is");
                Console.WriteLine(int.Parse(num1) / int.Parse(num2));
                
            }
            
            else
            {
                Console.WriteLine("                                               Enter a valid operator");
            }

  





            Animal animal1 = new Animal();
            animal1._name = "Camel";
            animal1._eyeproperties = 5;
            animal1._regurgitation = true;


            Animal animal2 = new Animal("Cattle", 5, true);

            Animal animal3 = new Animal("Donkey", 5, true);

            Animal animal4 = new Animal("Mantis Shrimp",10, false);;

            Animal animal5 = new Animal("Buffalo", 5, true);


            Console.WriteLine($"Name: {animal1._name},               Number of eyes: {animal1._eyeproperties},                  Regurgitating animal: {animal1._regurgitation} ");
            Console.WriteLine($"Name: {animal2._name},            Number of eyes: {animal2._eyeproperties},               Regurgitating animal: {animal2._regurgitation}");
            Console.WriteLine($"Name: {animal3._name},              Number of eyes: {animal3._eyeproperties},                 Regurgitating animal: {animal3._regurgitation}");
            Console.WriteLine($"Name: {animal4._name},       Number of eyes: {animal4._eyeproperties},          Regurgitating animal: {animal4._regurgitation}");
            Console.WriteLine($"Name: {animal5._name},             Number of eyes: {animal5._eyeproperties},                Regurgitating animal: {animal5._regurgitation}");

        }
    }
}
