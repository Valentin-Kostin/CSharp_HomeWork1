/*Напишите программу, которая принимает
на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

Console.Write("Веведите число A: ");
string litA = "A";
int num1 = int.Parse(Console.ReadLine());
Console.Write("Веведите число B: ");
string litB = "B";
int num2 = int.Parse(Console.ReadLine());
Console.Write("Веведите число C: ");
string litC = "C";
int num3 = int.Parse(Console.ReadLine());

int max = num1;
string litmax = litA;

if (num2 > max) 
{
    max = num2;
    litmax = litB;
};
if (num3 > max) 
{
    max = num3;
    litmax = litC;
};

Console.WriteLine("Максимальное число "+litmax+" = "+max);