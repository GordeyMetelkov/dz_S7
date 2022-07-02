//Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
Random rand = new Random();
int rows = rand.Next(2,8);
int columns = rand.Next(2,8);
int [,] matrix = new int[rows, columns];
fillArray(matrix);
printArray(matrix);
serching(matrix);
void fillArray (int[,] currentArray)
{
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
void serching (int[,] currentArray)
{
    Console.WriteLine("Введите номер строки:");
    int rowNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите номер столбца:");
    int columnNumber = Convert.ToInt32(Console.ReadLine());
    bool otvet = false;
    int number = 0;
    for (int i = 0; i < currentArray.GetLength(0); i++)
        {
            for (int j = 0; j < currentArray.GetLength(1); j++)
            {
                if (i+1 == rowNumber && j+1 == columnNumber)
                {
                    otvet = true; 
                    number = currentArray[i, j];
                    break;
                }
            }
        }
    if (otvet == false) Console.Write($"Позиции [{rowNumber}, {columnNumber}] не существует");
    else Console.Write($"Позиции [{rowNumber}, {columnNumber}] соответствует число {number}");
    Console.WriteLine();
}