// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.


double[,] matrix = new double[5,5];

for (int i = 0; i < matrix.GetLength(0); i++) 
    {
    for (int j = 0; j < matrix.GetLength(1); j++) 
        {
        matrix[i,j] = new Random().Next(-10,11); 
        Console.Write(matrix[i,j] + "\t");
        }
    Console.WriteLine();
    }

Console.WriteLine("Введите элемент строки: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите элемент столбца: ");
int columns = Convert.ToInt32(Console.ReadLine());

if  
    (rows < 0 || rows > 5  || columns < 0 || columns > 5)
    Console.Write("Такого элемента нет");
   
else 
    Console.WriteLine("Значение Вашего элемента " + matrix[rows,columns]);

