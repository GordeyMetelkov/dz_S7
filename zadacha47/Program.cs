// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами,
// округлёнными до одного знака.
Console.WriteLine("Введите количество строк:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int columns = Convert.ToInt32(Console.ReadLine());
double [,] matrix = new double [rows, columns];
fillArray(matrix);
printArray (matrix);
void fillArray (double [,] CurrentArray)
{
    Random rand = new Random();
    for (int i = 0; i < CurrentArray.GetLength(0); i++)
    {
        for (int j = 0; j < CurrentArray.GetLength(1); j++)
        {
            CurrentArray[i, j] = Math.Round(rand.NextDouble(), 1) + rand.Next(-10,11);
        }
    }
}
void printArray (double[,] CurrentArray)
{
    Console.WriteLine();
    for (int i = 0; i < CurrentArray.GetLength(0); i++)
    {
        for (int j = 0; j < CurrentArray.GetLength(1); j++)
        {
            Console.Write(CurrentArray[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}