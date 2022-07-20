// Задача №19: НаВходеПятизначноеЧисло,наВыходе - является ли число палиндромом.
Console.WriteLine("Задача №19");
Console.Write("Введи пятизначное число : ");
string? number = Console.ReadLine();
int [] array = new int[5];
if (number[0] == number[4] && number[1] == number[3]){
    Console.WriteLine("Это число палиндром");}
else{
    Console.WriteLine("Это число не палиндром");}