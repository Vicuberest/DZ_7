// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.


Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows,columns];

for (int i = 0; i < rows; i++) 
    {
     for (int j = 0; j < columns; j++) 
        {
           matrix[i,j] = new Random().Next(-10,11); 
           Console.Write(matrix[i,j] + "\t");
        }
            Console.WriteLine();
    }

double [] avgArray = new double[columns];

for (int j = 0; j < columns; j++)
{
   double sumColumns = 0;
   for (int i = 0; i < rows; i++)
   {
    sumColumns += matrix[i,j];
   }
    Console.Write($"{Math.Round((sumColumns/rows),2)} \t");
}
