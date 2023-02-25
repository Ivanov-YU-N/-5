/*Задача 36: Задайте одномерный массив, заполненный случайными числами.
 Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

int GetNumber(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int number = Convert.ToInt32(value);
    return number;
}

void GettArray(int[] array, int index)
{
    for(int i = 0; i < index; i++)
    {
        array[i] = new Random().Next(1, 5);
    }
}

void PrintArray(int[] array, int index)
{
    for(int i = 0; i < index; i++)
    {
        Console.Write(array[i] + " ");
    }
}

void ResultArray(int[] array, int index)
{
    int sum = 0;
    for(int i = 1; i < index; i+=2)
    {
        sum = sum + array[i];
    } 
    Console.WriteLine(sum);
}

int index = GetNumber("Введите размер массива  ");
int[] array = new int[index];
GettArray(array, index);
PrintArray(array, index);
Console.WriteLine();
ResultArray(array, index);
