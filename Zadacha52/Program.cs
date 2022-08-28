//  Задайте двумерный массив из целых чисел. 
//  Найдите среднее арифметическое элементов в каждом столбце.


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
double result = 0;
for (int i = 0; i < m; i++)
{
    
  for (int j = 0; j < m; j++)
  {
    result += mass[j, i];
  }
  result = Math.Round(result / m, 1);
  Console.Write(result + "; ");
}


