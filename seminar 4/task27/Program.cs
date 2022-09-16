// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int n;
int S = 0;
Console.WriteLine("Введите число ");
n = Convert.ToInt32(Console.ReadLine());
while(n > 0)
{
    S+= n % 10;
    n/= 10;
}
Console.WriteLine(" Сумма цифр числа = " +S);