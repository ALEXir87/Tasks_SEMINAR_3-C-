// Задача№21:НаBходеКоординатыДвухТочек,наВыходеРасстояниеМеждуНими в 3D пространстве
Console.WriteLine("Задача№21:");
Console.WriteLine("Введи x1:");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи y1:");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи z1:");
double z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи x2:");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи y2:");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи z2:");
double z2 = Convert.ToInt32(Console.ReadLine());
double rezult = Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2) + Math.Pow((z2-z1),2));
Console.WriteLine($"distance = {rezult}");