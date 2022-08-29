// Сгенерировать двумерный массив со случайными числами, вывести его на экран, 
// оформить в виде функций (пригодится в дальнейшем)

int Prompt(string message)
{
    System.Console.WriteLine(message);
    string input = Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

int[,] FillArray(int numLine, int numColumns)                       // Функция создания и заполнения двухмерного массива
{
    int[,] matrix = new int[numLine, numColumns];
    for (int i = 0; i < matrix.GetLength(0); i++)                   // строка
    {
        for (int j = 0; j < matrix.GetLength(1); j++)               // столбец
        {
            matrix[i, j] = i + j;
        }

    }
    return matrix;
}

void PrintArray(int[,] matrix)                       // Функция печати массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)                   // строка
    {
        for (int j = 0; j < matrix.GetLength(1); j++)               // столбец
        {
            Console.Write($"{matrix[i, j]}/t");
        }
        Console.WriteLine();
    }

}

int[,] array = FillArray(3, 4);
PrintArray(array);