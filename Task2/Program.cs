/*Напишите программу, которая принимает
на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

Console.Write("Веведите число A: ");            // Вводим первое число и присвоим ему имя A 
    string litA = "A";                           
    int num1 = int.Parse(Console.ReadLine());    
Console.Write("Веведите число B: ");            // Вводим второе число и присвоим ему имя B
    string litB = "B";                            
    int num2 = int.Parse(Console.ReadLine());   
Console.Write("Веведите число C: ");            // Вводим второе число и присвоим ему имя С
    string litC = "C";                           
    int num3 = int.Parse(Console.ReadLine());   

int max = num1;          // Вводим переменную для максимального числа
string litmax = litA;    // Вводим переменную для его имени 

if (num2 > max)         //
{                       //
    max = num2;         //
    litmax = litB;      //
};                      // Определяем какое число максимальное
if (num3 > max)         // и присваиваем ему имя
{                       //
    max = num3;         //
    litmax = litC;      //
};                      //

Console.WriteLine("Максимальное число "+litmax+" = "+max); // Выводим максимальное чило и его имя