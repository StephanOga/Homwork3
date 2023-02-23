/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
int GetChislo(string messege)
{
    Console.Write(messege +" ");
    return int.Parse(Console.ReadLine());
}

int value = GetChislo("Введите пятизначное число => ");
if (value < 10000 || value >99999)
{
    Console.WriteLine("Вы ввели не пятизначное число");
    return;
}
bool Met(int value)
{
int a = value / 10000;
int b = (value % 10000) / 1000;
int c = value % 10 ; 
int d  = (value  % 100) / 10; 
if (a == c && d == b )
{
  Console.WriteLine("Это число полиндром ");
  return true;
}
Console.WriteLine("Это число не полиндром ");
return false;
}
Met(value);
