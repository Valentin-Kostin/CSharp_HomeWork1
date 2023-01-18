/* Напишите программу, которая на вход 
принимает число и выдаёт, является ли число чётным 
(делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет */

Console.Write("Веведите число: ");
int numN1 = int.Parse(Console.ReadLine());
int numN2 = numN1%2;
if (numN2 == 0) 
{
    Console.WriteLine("Число "+numN1+" четное.");
}
else
{
    Console.WriteLine("Число "+numN1+" нечетное.");
}