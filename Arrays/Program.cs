// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int[] a = new int[5];
for (int i = 0; i < a.Length; i++)
{
    a[i]  = int.Parse(Console.ReadLine());

}

int min = a[0];

foreach (int i in a)
{
    if (min > i)
    {
        min = i;
    }
}
Console.WriteLine($"Min value is {min}");