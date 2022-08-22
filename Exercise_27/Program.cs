// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите целое число");
try
{
    int x = Convert.ToInt32(Console.ReadLine());
    int i = 0;
    x = Math.Abs(x);
    int z = x;
    int sum_number = 0;
    while(x>0)
        {
            
            x = x/10;
            i=i+1;
        
        }
        //Console.WriteLine(i);

    int[] Array = new int[i];
    i = i-1;
    while(i>=0)
        {
            Array [i] = z%10;
            z = z/10;
            //Console.WriteLine(Array [i]);
            sum_number = sum_number + Array[i];
            i=i-1;
            
        }
    Console.WriteLine("Сумма чисел в числе = "+sum_number);
}
catch
{
    Console.WriteLine("Введите число удовлетворяющее условию");
}