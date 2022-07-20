// Задача№23:НаBходеЧисло N,наВыходеТаблицаКубовЧисел от 1 до N.
Console.WriteLine("Задача№23:");
Console.WriteLine("Введи число N:");
double N = Convert.ToInt32(Console.ReadLine());
int count = 1;
if ( N < 1)
{
    Console.WriteLine("Неверно введено число");
}
else
{
    while(count <= N)
    {
    Console.WriteLine(Math.Pow(count,3));
    count++;
    }
}