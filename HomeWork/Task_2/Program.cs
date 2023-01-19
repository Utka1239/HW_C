/* Задача 2:
Напишите программу, которая на 
вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
Console.Write("Введите первое число: ");
string numberStr = Console.ReadLine();
int number1 = Convert.ToInt32(numberStr);

Console.Write("Введите второе число: ");
string numberStr1 = Console.ReadLine();
int number2 = Convert.ToInt32(numberStr1);


if (number1 > number2){
    Console.Write(number1  + " большее, а " + number2   + " меньшее" );
}
else{
    Console.Write(number2  + " большее, а " + number1  + " меньшее" );
}