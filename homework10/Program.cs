// // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("введите трехзначное число");
 int Number = int.Parse (Console.ReadLine());
 if (Number > 99 && Number < 1000)
 {
   System.Console.Write((Number % 100) / 10);
 }
 else 
 {
    System.Console.Write("это не трехзначное число ");
 }