// Задача 10: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

//  Console.WriteLine("Введите число");
//  int num1 = Convert.ToInt32(Console.ReadLine());

//  if(num1>=100 && num1<1000)
// {
//     int Num = (num1%100 - num1%10)/10;
//     Console.WriteLine($"Вторая цифра числа {num1} является {Num}");
// }
// else
//   Console.WriteLine("Это число не трехзначное");

// Задача 13: Напишите программу, которая выводит третью 
// цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.WriteLine("Введите число");
// int num1 = Convert.ToInt32(Console.ReadLine());

// int number = ReadInt("Введите число: ");
// int count = number.ToString().Length;
// Console.Write(MakeArray(number, count));

// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int MakeArray(int a, int b)
// {
// int result = 0;
//     if (b < 3)
//     {
//         Console.Write("Третьей цифры нет");
//     }
//     else
//     {
//         int c = 1;
//         for (int i = b; i > 3; i--)
//         {
//             c = c * 10;
//         }

//         result = (a / c) % 10;
//     }
// return result;
// }


// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

//   Console.WriteLine("Введите число");
//   int num1 = Convert.ToInt32(Console.ReadLine());

//   if (num1 >=6 && num1<8)
//   Console.WriteLine("Да");
//   if (num1>=1&&num1<6)
//   Console.WriteLine("Нет");