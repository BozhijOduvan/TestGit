// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Введите желаемое количество треугольников: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    for (int j = 0; j < i; j++)
    {
        string branch = new String('*', j);
        Console.WriteLine(branch.PadLeft(n + 3) + "*" + branch);
    }
}
