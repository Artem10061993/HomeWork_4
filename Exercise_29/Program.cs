// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int[] list = {1, 2, 3, 4, 5, 6, 7, 8};
int i = 0;
while(i<list.Length)
{
    if (i==0)
    {Console.Write("[");}
    if (i==7) 
    {
        Console.Write(list[i]+"]");
    }
    else
    {
    Console.Write(list[i]+", ");
    }
    i++;
}
