// // Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("введите число от 1 до 7");
 int Number = int.Parse (Console.ReadLine());
 if (Number ==6 || Number ==7)
 {
    System.Console.Write("да");
 }
 else 
 {
    System.Console.Write("нет");
 }