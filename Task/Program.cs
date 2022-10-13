// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []




string[] FillArray(int size)
{
    string[] anyArray = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i + 1} элемент массива: ");
        anyArray[i] = Console.ReadLine()!;
    }
    return anyArray;
}

Console.Write("Введите длину массива: ");
if (!int.TryParse(Console.ReadLine(), out int sizeArray))
{
    Console.WriteLine("Введено не число!");
    return;
}
string[] array = FillArray(sizeArray);
string[] FilterArray(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            count++;
        }
    }
    string[] newArr = new string[count];
    count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            newArr[count] = arr[i];
            count++;
        }
    }
    return newArr;
}
string[] newArray = FilterArray(array);
Console.WriteLine($"Введенный массив: [{String.Join(", ", array)}]");
Console.WriteLine($"Полученный массив: [{String.Join(", ", newArray)}]");