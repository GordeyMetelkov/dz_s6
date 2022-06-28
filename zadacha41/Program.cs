//  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("Введите количество вводимых чисел:");
int N = Convert.ToInt32(Console.ReadLine());
int PosNumbers (int curN)
{
    int countPos = 0;
    for (int i = 0; i<curN; i++)
    {
        Console.WriteLine("Введите число:");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 0) countPos++;   
    }
    return countPos;
}
Console.WriteLine("Количество положительных чисел равно "+ PosNumbers(N));