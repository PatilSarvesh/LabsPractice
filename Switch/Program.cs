// See https://aka.ms/new-console-template for more information

Console.WriteLine("ENter Operator");
Char oprt = char.Parse(Console.ReadLine());

Console.WriteLine("ENter first Number");
double a = double.Parse(Console.ReadLine());

Console.WriteLine("ENter Second Number");
double b = double.Parse(Console.ReadLine());

double val;

switch (oprt)
{
    case '+':
        val = a + b;
        Console.WriteLine($"{a} {oprt} {b} = {val}");
        break;
    case '-':
        val = a - b;
        Console.WriteLine($"{a} {oprt} {b} = {val}");
        break;
    case '/':
        val = a / b;
        Console.WriteLine($"{a} {oprt} {b} = {val}");
        break;
    case '*':
        val = a * b;
        Console.WriteLine($"{a} {oprt} {b} = {val}");
        break;
    default:
        Console.WriteLine("Invalid Input");
        break;
}



