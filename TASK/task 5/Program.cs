/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125

double Degree(int number, int c)
{
    double numberDegree = 1;

    for (int i = 0; i < c; i++)
    {
        numberDegree *= number;
    }
    return numberDegree;
}
string TabCub(int n)
{
    double cub = 1;
    string result = "";
    for (double count = 1; count <= n; count++)
    {
        cub = Degree(count, 3);
        result = result + cub + ",";
    }
    return result;
}


Console.WriteLine("вВЕДИТЕ ЛЮБОЕ ПОЛОЖИТЕЛЬНОЕ ЧИСЛО ");
int N = int.Parse(Console.Readline());
string Cub = TabCub(N);
Console.WriteLine(Cub);

*/
double Degree(int number, int c)
{
    double numberDegree = 1;

    for (int i = 0; i < c; i++)
    {
        numberDegree *= number;
    }
    return numberDegree;
}
string TabCub(int n)
{
    string result = "";
    for (int count = 1; count <= n; count++)
    {
        double cub = Degree(count, 3);
        result = result + cub + ",";
    }
    return result;
}
Console.WriteLine("Введите любое положительное число:");
int N = int.Parse(Console.ReadLine());
string Cub = TabCub(N);
Console.WriteLine(Cub);

