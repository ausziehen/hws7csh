/* Task 47.  Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
double[,] CreateRandom2dArray(int rows, int columns)
{   double[,] array = new double[rows,columns];
    for(int i = 0; i < rows;i++)
    {   for (int j = 0; j < columns;j++)
        array[i,j] = Math.Round((new Random().NextDouble()), 1);
    }
        return array;
}
void Show2dArray(double[,] array)
{   for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
}
Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
double[,] newArray = CreateRandom2dArray(rows, columns);
Show2dArray(newArray);
*/



/* // Task 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,]  Create2dArray(int rows, int columns, int minValue, int maxValue)
{
   int[,] array = new int[rows, columns];
   for (int i = 0; i < rows; i++)
   {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue +1);
        }
   }        
        return array;
}     
void Show2dArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write (array[i,j] + " ");
        }
        Console.WriteLine ();
    }
}
void ShowIndex(int[,] array)
{
    Console.WriteLine("Введите индекс числа строки: ");
    int indexrows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите индекс числа столбца: ");
    int indexcolumns = Convert.ToInt32(Console.ReadLine());
    if ( indexrows > array.GetLength(0) ||  indexcolumns > array.GetLength(1))
    {
        Console.WriteLine("Такого элемента в массиве нет.");
        return;
    }

    Console.WriteLine(array[indexrows, indexcolumns]);
}
Console.WriteLine ("Input a number of rows: ");
int rows = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input a number of columns: ");
int columns = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input a number of minValue: ");
int minValue = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input a number of maxValue: ");
int maxValue = Convert.ToInt32 (Console.ReadLine());
int[,] newArray = Create2dArray(rows, columns, minValue, maxValue);
Show2dArray(newArray);
ShowIndex(newArray);
*/

/*// Task 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

int[,]  CreateNewnewArray(int rows, int columns, int minValue, int maxValue)
{
   int[,] array = new int[rows, columns];
   for (int i = 0; i < rows; i++)
   {
    for (int j = 0; j < columns; j++)
    {
    array[i,j] = new Random().Next(minValue, maxValue +1);
    }
   }        
    return array;
}     
void Show2dArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write (array[i,j] + " ");
        }
        Console.WriteLine ();
    }
}
double[] ArithmeticMeanColumns(int[,] array, int columns, int rows)
{
        double[] cols = new double[columns];
    for (int j = 0; j < columns; j++)
    {
        double sum = 0;
        for (int i = 0; i < rows; i++)
        {
            sum += array[i, j];
        }
        double colmn = sum / rows;
        cols[j] = colmn;

        Console.WriteLine(" Сумма столбца " + (j + 1) + " = " + sum);
        Console.WriteLine(" Среднее арифметическое столбца " + (j + 1) + " = " + colmn);
    }
    return cols;
}
Console.WriteLine ("Input a number of rows: ");
int rows = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input a number of columns: ");
int columns = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input a number of minValue: ");
int minValue = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input a number of maxValue: ");
int maxValue = Convert.ToInt32 (Console.ReadLine());
int[,] newArray = CreateNewnewArray  (rows, columns, minValue, maxValue);
Show2dArray(newArray);
ArithmeticMeanColumns(newArray, columns, rows);
*/