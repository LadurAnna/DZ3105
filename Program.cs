// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


// Задача ________19________
// Напишите программу, которая принимает
//  на вход пятизначное число и проверяет, 
//  является ли оно палиндромом
//  14212 -> Нет
//  23432 -> да 
//  12821 -> да 
// Console.WriteLine("Введите число");// выводит на экран строку
// string st = Console.ReadLine(); // считываем с экрана строку и кладем в переменную например st 
// Console.WriteLine(st[0]); //показывает число из массива по 0 индексу
// Console.WriteLine(st.Length); //выводит длину строки (количество цифр вчисле)
// Console.WriteLine(st[st.Length-1]); //показывает число из массива последний элемент массива (скобки значит это массив)
// int n = st.Length/2;
// string result = "да";
// for (int i = 0; i < n; i++)
// {
//     if (st[i] != st[st.Length-1-i])
//     {
//         result = "нет";
//         break;
//     }
// }
// Console.WriteLine(result);

// __________Задача 21_________________
// Напишите программу, которая принимает
// на вход координаты двух точек и находит
// расстояние между ними в 3D пространстве.
 
//  А(3,6,8); B (2,1,-7), -> 15.84
//  А(7,-5,0); В (1,-1,9) -> 11.53

// Console.WriteLine("Введите число x1");
// int x1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число y1");
// int y1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число z1");
// int z1 = Convert.ToInt32(Console.ReadLine());


// Console.WriteLine("Введите число x2");
// int x2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число y2");
// int y2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число z2");
// int z2 = Convert.ToInt32(Console.ReadLine());

// double d =Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)+Math.Pow((z2-z1),2)); 
// Console.WriteLine($"Расстояние между двумя точками равно:{d}");


// __________________Задача 23________________
// Напишите программу, которая принимает на вход
// число (N) и выдает таблицу кубов чисел 
// от 1 до N 
// 3 -> 1,4,9
// 5 -> 1,8,27,64,125

// Console.WriteLine("Введите число");

// int num = Convert.ToInt32(Console.ReadLine());

// int count=1;

// while(num>=count)
// {
//     Console.WriteLine(Math.Pow(count,3));
//     count=count+1;
// }


