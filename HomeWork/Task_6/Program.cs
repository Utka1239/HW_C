/* Задача 6: 
Напишите программу, которая на вход принимает 
число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

Console.Write("Enter your number: ");
string numberStr = Console.ReadLine();
int number = Convert.ToInt32(numberStr);
if(number % 2 == 0){
    Console.Write("Введенное число является четным");
}
else{
    Console.Write("Введенное число является нечетным");
}