// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
Random rand = new Random();
int number = rand.Next(100, 1000);
Console.WriteLine($"Сгенерировалось случайное число {number}");
int digit1 = number / 10;
int digit2 = digit1 % 10;
Console.WriteLine($"Вторая цифра трехзначного числа {digit2} ");