// Задача 1. Напишите программу, которая на вход принимает трехзначное число и на выходе показывает вторую цифру этого числа.

int Digit (int number)
{
    int digit2 = (number / 10) % 10;
    return digit2;
}
Console.WriteLine("Input 3digits number: ");
int user_num3 = Convert.ToInt32(Console.ReadLine());
int result;
if(user_num3 > 99 && user_num3 < 1000)
{
    result = Digit (user_num3);
    Console.WriteLine($"The new number is {result}");
}
else
    Console.WriteLine("ERROR! Your number is not 3digits");


// Задача 2. Напишите программу, которая выводит 3 цифру заданного числа или сообщает, что третьей цифры нет.

/*void Digit (int number)
{
    if (number > 99)
    {
        while (number >= 1000)
        {
           int number1 = number / 10;
           number = number1;
        }
        int result = number % 10;
        Console.WriteLine($"Third  digit is {result}");
    }
    else if (number < 100)
        Console.WriteLine("There is not third digit in this number");
}
Console.WriteLine("Input your number: ");
int user_number = Convert.ToInt32(Console.ReadLine());
Digit (user_number);
*/

// Задача 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели и проверяет, является ли этот день выходным.

/*void Digit (int num)
{
    if (num == 6 || num == 7)
    Console.WriteLine($"Number {num} is day off");

    else if (num < 1 || num > 7)
    Console.WriteLine($"Number {num} is not day of week");

    else
    Console.WriteLine($"Number {num} is work day");
}

Console.WriteLine("Input your number: ");
int user_num = Convert.ToInt32(Console.ReadLine());
Digit (user_num);
*/