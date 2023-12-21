// Напишите программу, которая 
// 1. Принимает на вход трёхзначное целое число 
// 2. На выходе показывает сумму первой и последней цифры этого числа.
// 456 => 10
// 782 => 9
// 918 => 17

Console.WriteLine("Введите трехзначное число");
int numb = Convert.ToInt32(Console.ReadLine());
if (numb < 0)
numb = numb * -1;
if (numb >= 100 && numb <= 999)
{
    int num1 = numb / 100;
    int num3 = numb % 10;
    int number = num1 + num3;
    Console.WriteLine(number);
}
else
{
    Console.WriteLine("Неверное число");
}