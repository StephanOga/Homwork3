/*
Задачи 2
дан массив: наполнени числами от 1 до N
Задача: сколько раз какое число встречается

1 3 1 2 1 2 4 5 1 2 5 4

1 - 4р
2 - 3р
3 - 1р
4 - 2р
5 - 2р
*/
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 500);
        index++;
    }
}

void Print(int[] col)
{
    int length = col.Length;
    int index = 0;
    while (index < length)
    {
        System.Console.WriteLine(col[index]);
        index++;
    }
}

int[] array = new int[500];
FillArray(array);



Array.Sort(array);

int count = 1;
int previous = array[0];

Console.WriteLine("Число\tКоличество");

for (int i = 1; i < array.Length; i++)
{
    if (array[i] == previous)
    {
        count++;
    }
    else
    {
        Console.WriteLine(previous + "\t" + count);
        count = 1;
        previous = array[i];
    }
}


Console.WriteLine(previous + "\t" + count);

