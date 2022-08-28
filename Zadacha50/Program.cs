// Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] mass = new int[m, n];
Random rand = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        mass[i, j] = new Random().Next(1, 10);

        Console.Write(mass[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("Введите координаты");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
if (x > m && y > n)
{
    Console.WriteLine("Такого элемента нет");
}
else
{
    object num = mass.GetValue(x, y);
    Console.WriteLine("Значание элемента: " + num);
}
