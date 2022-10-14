// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Ведите число:");
int number = Convert.ToInt32(Console.ReadLine());
int size = number.ToString().Length;
//Console.Write(MakeArray(number, size));


if (size == 5)
{
    
    int a = (number % 100000 - number %10000)/10000;
    int c = number % 10;

    int d = (number % 10000 - number %1000)/1000;
    int r = (number % 100 - number %10)/10;
    
    if(a == c || d == r)
    {
        Console.WriteLine("Число является палиндромом");
    }
    else Console.WriteLine("Число является не палиндромом");
}
else Console.WriteLine("Число не пятизначное");
