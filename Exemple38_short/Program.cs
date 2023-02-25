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
        array[i] = new Random().Next(100, 500);
}

void ResultArray(int[] array, int index)
{
    int min = array[0];
    int max = array[0];
    for(int i = 0; i < index; i++)
    {
        if(array[i] >  max)  max = array[i];
        if(array[i] < min)   min = array[i];
    } 
    Console.WriteLine(max-min);
}

int index = GetNumber("Введите размер массива  ");
int[] array = new int[index];
GetArray(array, index);
ResultArray(array, index);
