// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на стартевыполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

Console.Clear();

string[] Array = GetArray();
Console.WriteLine();
PrintArray(Array);
Console.WriteLine();
string[] NewArr = NewArray(Array);
PrintArray(NewArr);

string[] GetArray()
{
    Console.Write("Введите элементы массива через пробел: ");
    string[] arr = Console.ReadLine().Split();
    return arr;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.Write($"{arr[arr.Length - 1]}]");
}

string[] NewArray(string[] arr)
{
    string res = string.Empty;
    foreach (string item in arr)
    {
        if (item.Length < 4) res = res + $"{item} ";
    }
    string[] result = res.Split();
    if (result.Length == 1) return result;
    else return result = result.Take(result.Length - 1).ToArray();
}