Console.WriteLine("Введите трёхзначное число:");
int number = int.Parse(Console.ReadLine()!);
int number1 = 0;
int number2 = 0;
int number3 = 0;
int[] array = new int[3];
if (number > 1000 | number < 100)
{
    Console.WriteLine("Ошибка! Попробуйте снова.");
}
else
{
    number3 = number % 10;
    number1 = number / 100;
    number2 = number / 10 % 10;


int max;
max =  number1;
if (number2 > max)
{
    max = number2;
}
if (number3 > max)
{
    max = number3;
}
array[0] = max;
int min = number1;
if (number2 < min)
{
    min = number2;
}
if (number3 < min)
{
    min = number3;
}
array[1] = min;
int a = number1;
if (a == min | a == max)
{
    a = number2;
}
if (a == min | a == max)
{
    a = number3;
}
array[2] = a;



Console.Write(array[0] + " ");
Console.Write(array[1] + " ");
Console.Write(array[2] + " ");
}