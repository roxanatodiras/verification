// //Написать программу, которая из имеющегося массива строк формирует новый 
// массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] FilterArray (string[] array)
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
        foreach (string str in array) 
    {
        int i = 0;
        if (str.Length <= 3)
        {
            filtered[i] = str;
            i++;    
        }
        
    }
    return filtered;
}

string[] array = { "Hello", "2", "world", ":-)" };
string[] array2 = {"1234", "1567", "-2", "computer science" };
string[] array3 = { "Russia", "Denmark", "Kazan" };

