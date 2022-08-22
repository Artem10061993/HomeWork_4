//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
try{
Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
double result = Math.Pow(a,b);
Console.WriteLine("Результат = "+result);
}
catch
{
    Console.WriteLine("Введите целое число");
}