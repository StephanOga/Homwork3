/*
Реализовать перемешивание массива
Создать массив
Распечатать массив
Заполнение 3.1 случайно 3.2 руками *. Читать число из консоли
перемешивание
*/
void FillArray(int[]collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void Print(int[] col)
{
   int length = col.Length;
    int index = 0;
    while(index < length)
    {
       System.Console.Write(col[index]); 
        index++;
    } 
}

void Mixing(int[] array)
{
    int size = array.Length;
    for(int index = 0; index < size; index++)
    {
        int help = 0;
        int rand = new Random().Next(1,3);

        help = array[index];
        array[index] = array[size - rand];
        array[size - rand] = help;         
    }
}

int[]arr = new int [10];
FillArray(arr);
Print(arr);
Console.WriteLine();
Mixing(arr);
Print(arr);



