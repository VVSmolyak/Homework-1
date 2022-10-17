//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

//1. Ввести 1 число.
Console.WriteLine ("введите первое число");
int numberA = int.Parse (Console.ReadLine()!);
//2. Ввести 2 число.
Console.WriteLine ("введите второе число");
int numberB = int.Parse (Console.ReadLine()!);
//3. If 1 > 2 then 1 = max.
if (numberA > numberB) {
    Console.WriteLine ("Максимальное число: "+ numberA);
    Console.WriteLine ("Минимальное число: "+ numberB);
} else {
    Console.WriteLine ("Максимальное число: "+ numberB);
    Console.WriteLine ("Минимальное число: "+ numberA);
}
//4. Else 2 = max.