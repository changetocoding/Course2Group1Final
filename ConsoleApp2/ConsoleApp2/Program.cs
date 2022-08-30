// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*string num1;
string num2;
string op;
Console.WriteLine("enter first numbers");
num1 = Console.ReadLine();
Console.WriteLine("the operators are +,-,*,/,^");
op = Console.ReadLine();
Console.WriteLine("enter second numbers");
num2 = Console.ReadLine();

if (op =="+")
{
    Console.WriteLine("the results");
    Console.WriteLine(int.Parse(num1) + int.Parse(num2));
}
else if(op=="-")
{
    Console.WriteLine("the results");
    Console.WriteLine(int.Parse(num1) - int.Parse(num2));
}
else if(op=="*")
{
    Console.WriteLine("the results");
    Console.WriteLine(int.Parse(num1) * int.Parse(num2));
}
else if(op=="/")
{
    Console.WriteLine("the results");
    Console.WriteLine((decimal)int.Parse(num1) / int.Parse(num2));
}
else if(op=="^")
{
    Console.WriteLine("the results");
    int total= int.Parse(num1) + int.Parse(num2);
    Console.WriteLine(Math.Sqrt(total));

    Console.WriteLine(Math.Sqrt(int.Parse(num1) + int.Parse(num2)));
}
else
{
    Console.WriteLine("enter a valid operator");
}

for (int i= 2; i <=500;i =i+1)
{
    Console.WriteLine(i);
while (true)
{
    Console.WriteLine("enter the first number");
    string num1 = Console.ReadLine();
    Console.WriteLine("enter second number");
    string num2 = Console.ReadLine();
    int total = int.Parse(num1) + int.Parse(num2);
    string op = Console.ReadLine();
    Console.WriteLine("the operators are +,-,*,/,^");
}*/
/*for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("fizzbuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("buzz");
    }
    else
    {
        Console.WriteLine(i);
    }
}*/

/*static void Myname()
{
    Console.WriteLine("miracle");
    Console.WriteLine("mary");
}
Myname();*/
static void Addnumbers(int num3, int num5,int num7)
{
    Console.WriteLine(num3+num5+num7);
}
Addnumbers(3, 5 , 7);
/*static int addnumbers(int x)
{
    return 3 + x;
}
{Console.WriteLine(addnumbers(5));
}*/
/*static int mod(int num1,int num2)
{
    return num1 % num2;
}
Console.WriteLine(mod(5, 3));*/

/*Dictionary<int, string> hobby = new Dictionary<int, string>();
hobby.Add(0, "drumming");
hobby.Add(1, "dancing");
hobby.Add(2, "cooking");
hobby.Add(3, "coding");*/
/*foreach(var item in dict)
{
    Console.WriteLine(item.Value + item.Key);
}*/
/*for (int i = 0; i < hobby.Count; i++) 
{
    Console.WriteLine(hobby.ElementAt(i).Value);
}*/
Console.WriteLine("what would you like to SAVE,VIEW,UPDATE,DELETE");
string name;
string number;
string op = Console.ReadLine();

if (op == "SAVE")
{
    Console.WriteLine("enter contact name");
    name= Console.ReadLine();
    Console.WriteLine("enter contact number");
    number= Console.ReadLine();
    Console.WriteLine(""+ name+"saved successfully");
    
}