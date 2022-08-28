// Задайте двумерный массив размером m×n, заполненный случайными 
// вещественными числами.


Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] mass = new double[m, n];
Random rand = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        mass[i, j] = rand.Next(-10, 10) + rand.NextDouble();
        {
            mass[i, j] = Math.Round(mass[i, j], 2);
        }
        Console.Write(mass[i, j] + " ");
    }
    Console.WriteLine();
}




