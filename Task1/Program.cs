/*Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

Console.Write("Веведите число A: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Веведите число B: ");
int num2 = int.Parse(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine("Число А = "+num1+" больше числа В = "+num2);
}
else 
{
    Console.WriteLine("Число A = "+num1+" меньше числа B = "+num2);
}