// See https://aka.ms/new-console-template for more information

double[,] arr = new double[2,5];

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 5; j++)
    {
        arr[i, j] = double.Parse(Console.ReadLine());
    }
}

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write($" {arr[i,j]} ");
    }
    Console.WriteLine();
}

int l1 = arr.Length;
int l2 = arr.GetLength(0);
int l3 = arr.GetLength(1);

Console.WriteLine($" Array Elements {l1 }");
Console.WriteLine($" Array row length {l2 }");
Console.WriteLine($" Array colum length {l3 }");




