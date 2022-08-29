// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int Prompt(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void Main(double k1, double b1, double k2, double b2)           // функция проверки условия
{
    if (b1 == b2 && k1 == k2)
    {
        Console.WriteLine("Прямые совпадают");
    }
    else if (k1 == k2)
    {
        Console.WriteLine("Прямые параллельны");
    }
    else
    {
        var tuple = SystemSolution(k1, b1, k2, b2);
        Console.WriteLine($"Координаты точки пересечения ({(tuple.Item1):f2}; {(tuple.Item2):f2})");
    }
}

(double, double) SystemSolution(double k1, double b1, double k2, double b2)  // Функция нахождения точек
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    var result = (x, y);
    return result;
}

int b1 = Prompt("Определите коэффициент b1 ");                               // Вводим коэффициенты
int k1 = Prompt("Определите коэффициент k1 ");
int b2 = Prompt("Определите коэффициент b2 ");
int k2 = Prompt("Определите коэффициент k2 ");
Main(k1, b1, k2, b2);                                                        // Начинаем проверку
