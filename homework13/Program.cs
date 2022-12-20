// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.WriteLine("введите число");
 int Number = int.Parse (Console.ReadLine());
 int N = Number.ToString().Length;
 System.Console.WriteLine("цифр в числе " +N);
 if (N < 3 )
{
System.Console.WriteLine("здесь нет третей цифры");
}
 if  (N ==3 )  
 {
    System.Console.Write("третья цифра ="); 
    System.Console.Write(Number % 10) ;
}
if  (N ==4 )  
 {
     System.Console.Write("третья цифра =");
    System.Console.Write((Number % 100)/10) ;
}
if  (N ==5 )  
 {
    System.Console.Write("третья цифра =");
    System.Console.Write((Number % 1000)/100) ;
}
if  (N ==6 )  
 {
     System.Console.Write("третья цифра =");
    System.Console.Write((Number % 10000)/1000) ;
}
if  (N > 6 )
{
    System.Console.WriteLine("введите число меньше");
    }
   
