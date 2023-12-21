// //Напишите программу которая: 
// 1. на вход принимает 2 целых числа; 
// 2. Проверяет, является ли первое число квадратом второго;
// 3. Вывод результата.

// a = 25; b = 5 => да
// a = 2; b = 10 => нет
// a = 9; b = 3 => да
// a = -3; b = 9 => нет

Console.Write("Введите первое число:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2 * num2)
{
    // Console.Write("Первое число является квадратом второго");
    // Console.Write("a = "+ num1 + ", b = " + num2 + " => да ");
    Console.Write($"a = {num1} , b = {num2}  => да ");
}

else
{
    // Console.Write("Первое число HE является квадратом второго");
    // Console.Write("a = "+ num1 + ", b = " + num2 + " => нет ");
    Console.Write($"a = {num1} , b = {num2}  => нет ");
}