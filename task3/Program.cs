/* Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

int GetNumber (string message)
{
    int result = 0;
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out result) && result != 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Вы ввели не число или введенное число равно 0. Повторите ввод");
        }
    }
    return result;
}

void GetSquare (int N)
{
    if (N>0)
   {
        for (int i = 1; i <= N; i++)
        {
            Console.Write($"{i*i*i}, ");
        }
    }
    else 
    {
       for (int i = 1; i >= N; i--)
        {
            Console.Write($"{i*i*i}, ");
        } 
    }
}

int N = GetNumber("Введите число: ");
GetSquare(N);
