// Задача 52: Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
Console.WriteLine("Введите количество строк:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int columns = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int [rows, columns];
fillArray(matrix);
printArray(matrix);
average(matrix);
void fillArray (int[,] currentArray)
{
    Random rand = new Random();
    for (int i = 0; i < currentArray.GetLength(0); i++)
    {
        for (int j = 0; j < currentArray.GetLength(1); j++)
        {
            currentArray[i, j] = rand.Next(0, 11);
        }
    }
}
void printArray (int[,] currentArray)
{
    Console.WriteLine();
    for (int i = 0; i < currentArray.GetLength(0); i++)
    {
        for (int j = 0; j < currentArray.GetLength(1); j++)
        {
            Console.Write(currentArray[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
void average (int[,] currentArray)
{
    double sum = 0;
    double columnsAverage;
    for (int j = 0; j < currentArray.GetLength(1); j++)
    {
        for (int i = 0; i < currentArray.GetLength(0); i++)
        {
            sum += currentArray[i, j];
        }
        columnsAverage = sum / currentArray.GetLength(0);
        Console.WriteLine($"Среднее арифметическое в столбце {j+1} = {Math.Round(columnsAverage, 1)}");
        sum = 0;
    }
}