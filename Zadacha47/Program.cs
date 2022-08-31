// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[rows,columns];


for (int i = 0; i < rows; i++) 
    {
    for (int j = 0; j < columns; j++) 
        {
        matrix[i,j] = new Random().Next(-10,11); // пусть у меня будут идеальные целые вещественные числа ))
        Console.Write(matrix[i,j] + "\t");
        }
        Console.WriteLine();
    }

