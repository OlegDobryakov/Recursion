
int[] array =  {5, 9, 72, 8};
int a;
Console.WriteLine("Введите число для проверки: ");
a = int.Parse(Console.ReadLine()!);
int b = 0;
for (int i = 0; i < array.Length; i++)
{  
   if (a == array[i])
   { b = 9;
    Console.WriteLine("Да");
   }

}
if (b == 0)
{
    Console.WriteLine("Нет");
}


int[] array1 =  {5, 9, 72, 8};
int a1;
Console.WriteLine("Введите число для проверки: ");
a1 = int.Parse(Console.ReadLine()!);
bool result = false;
for (int i = 0; i < array.Length; i++)
{  
   if (a1 == array1[i])
   { 
    result = true;
   }

}
if (result == true)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
} 