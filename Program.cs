// //Написать программу, которая из имеющегося массива строк формирует новый 
// массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] FilterArray(string[] array)
{
    int count = 0;
    foreach (string str in array)
    {
        if (str.Length <= 3)
        {
            count++;
        }
    }
    string[] filtered = new string[count];
    int i = 0;
    foreach (string str in array)
    {
        if (str.Length <= 3)
        {
            filtered[i] = str;
            i++;
        }
    }
    return filtered;
}
void PrintArray(string[] array)
{
    if (array.Length == 0)
    {
        Console.WriteLine("");
        return;
    }
    else
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }

    }
}

string[] array = { "Hello", "2", "world", ":-)" };
string[] array2 = { "1234", "1567", "-2", "computer science" };
string[] array3 = { "Russia", "Denmark", "Kazan" };

string[] filtered = FilterArray(array);
string[] filtered2 = FilterArray(array2);
string[] filtered3 = FilterArray(array3);

PrintArray(filtered);
Console.WriteLine("");
PrintArray(filtered2);
Console.WriteLine("");
PrintArray(filtered3);