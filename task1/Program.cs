/* Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да */


using System.Data;
using System.Threading.Tasks.Dataflow;

int GetNumber(string message)
{
    int result = 0;
    while(true)
    {
        Console.WriteLine(message);
    if (int.TryParse(Console.ReadLine(), out result))
    {
        break;
    }
    else
    {
        Console.WriteLine("Вы ввели не число. Повторите ввод");
    }
    }
return result;
}

string CheckPalindromeNumber(int number)
{
    if (number >10000 && number < 100000 || number > -100000 && number < -10000)
    {
        if (number / 10000 == number % 10 && number/1000%10 == number%100/10)
        {
            return "Введенное число является палиндромом";
        }
        else
        {
            return "Введенное число не является палиндромом";
        }
    }
    else
    {
       return "Вы ввели не пятизначное число"; 
    }

}


int number = GetNumber("Введите пятизначное число: ");
string PalindromeNumber = CheckPalindromeNumber(number);
Console.WriteLine(PalindromeNumber);