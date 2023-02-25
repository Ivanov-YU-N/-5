/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

int GetNumber(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int number = Convert.ToInt32(value);
    return number;
}

void GetArray(int[] array, int index)
{
    for(int i = 0; i < index; i++)
    {
        array[i] = new Random().Next(100, 500);
    }
}

void PrintArray(int[] array, int index)
{
    for(int i = 0; i < index; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int ResultArrayMax(int[] array, int index)
{
    int sum = array[0];
    for(int i = 0; i < index; i++)
    {
        if(array[i] >  sum)
        {
            sum = array[i];
        }
    } 
    Console.WriteLine(sum);
    return sum;
}
int ResultArrayMin(int[] array, int index)
{
    int sum = array[0];
    for(int i = 1; i < index; i++)
    {
        if(array[i] < sum)
        {
            sum = array[i];
        }
    } 
    Console.WriteLine(sum);
    return sum;
}

int index = GetNumber("Введите размер массива  ");
int[] array = new int[index];
GetArray(array, index);
PrintArray(array, index);
Console.WriteLine();
int min = ResultArrayMin(array, index);
int max = ResultArrayMax(array, index);
Console.WriteLine(max - min);
