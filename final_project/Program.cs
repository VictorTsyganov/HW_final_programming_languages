// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на стартевыполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

Console.Clear();

string[] Array = NewArray();
Console.WriteLine();
PrintArray(Array);

string[] NewArray()
{
    Console.Write("Введите элементы массива через пробел: ");
    string[] arr = Console.ReadLine().Split();
    return arr;
}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
