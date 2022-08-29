// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Prompt(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void InputAndCountNumbers(int number)                  // функция проверки условия
{
    if (number > 0)
    {
        int[] array = FillArray(number);
        PrintArray(array);
        Console.WriteLine($"Количество положительных чисел ровано {PositiveNumber(array)}");
    }
    else
    {
        Console.WriteLine("Количество не может быть отрицательным или равным нулю");
    }
}

int[] FillArray(int number)                            // Функция ввода массива
{
    int[] array = new int[number];
    for (int i = 0; i < number; i++)
    {
        Console.Write("Введите число: ");
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}

int PositiveNumber(int[] array)                    // Функция подсчета положительных чисел
{
    int сount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            сount++;
        }
    }
    return сount;
}

void PrintArray(int[] array)                       // Функция печати массива
{
    for (int j = 0; j < array.Length; j++)          
    {
        Console.Write($"{array[j]} ");  
    }
}

int number = Prompt("Введите М чисел: ");        // Определяем количество чисел
InputAndCountNumbers(number);                   // начинаем проверку 