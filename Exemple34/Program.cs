/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

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
        array[i] = new Random().Next(100, 999);
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
    int count = 0;
    for(int i = 0; i < index; i++)
    {
        if(array[i] %2 == 0)
            {
                count += 1;
            }
    } 
    Console.WriteLine(count);
}

int index = GetNumber("Введите размер массива  ");
int [] array = new int[index];
GettArray(array, index);
PrintArray(array, index);
Console.WriteLine();
ResultArray(array, index);
Console.WriteLine();
