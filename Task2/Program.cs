/*Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее*/


Console.Write("Введите первое число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

if(numberOne > numberTwo)
{
Console.WriteLine(numberOne + " " + "больше чем" + " " + numberTwo );
}
else
{
Console.WriteLine(numberTwo + " " + "больше чем" + " " + numberOne);
}