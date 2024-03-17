Console.Write("Введите кол-во элементов массива: ");
int number = Convert.ToInt32(Console.ReadLine());
string[] array = new string[number];

Console.WriteLine($"Исходный массив: [{string.Join(" , ", CreateArray())}]");
Console.WriteLine($"Новый массив: [{string.Join(" , ", NewArray(array))}]");

string[] CreateArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i} элемент массива:\t");
        array[i] = Console.ReadLine();
    }
    return array;
}

int CheckArray(string[] array)
{
    int countArray = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            countArray++;
        }
    }
    return countArray;
}

string[] NewArray(string[] array)
{
    string[] newArray = new string[CheckArray(array)];
    int size = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[size] = array[i];
            size++;
        }
    }
    return newArray;
}

