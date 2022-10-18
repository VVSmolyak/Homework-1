//Напишите программу, которая принимает на вход (консоль) три числа (целых) и выдаёт максимальное из этих чисел (консоль).

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

//1. Ввод числа a
Console.WriteLine ("Введите первое число:");
int numberA = int.Parse (Console.ReadLine()!);
//2. Ввод числа b
Console.WriteLine ("Введите второе число:");
int numberB = int.Parse (Console.ReadLine()!);
//3. Ввод числа c
Console.WriteLine ("Введите третье число:");
int numberC = int.Parse (Console.ReadLine()!);
//4. Сравнение a и b, if a > b then a = max, else b = max
int max = numberA;
if (numberB > max) max = numberB;
if (numberC > max) max = numberC;

Console.WriteLine ("Максимальное число " + max);
//5. Ввод max
//6. Сравнение max и с, if max > c then max = max, elce c = max. 