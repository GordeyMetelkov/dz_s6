// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine($"Первая прямая задана уравнением 'y = k1 * x + b1'");
Console.WriteLine($"Вторая прямая задана уравнением 'y = k2 * x + b2'");
Console.WriteLine("Введите значение k1:");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b1:");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k2:");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b2:");
int b2 = Convert.ToInt32(Console.ReadLine());
tochki (k1, b1, k2, b2);
void tochki (int curk1, int curb1, int curk2, int curb2)
{
    if (curk1 == curk2) Console.WriteLine("Введите разные значения curk1 и curk2:");
    else 
    {
        double curx = (curb2-curb1) / (curk1-curk2);
        double cury = curk1*curx + curb1;
        Console.WriteLine($"Точка пересечения двух прямых имеет координаты [{curx}; {cury}]");
    }
}