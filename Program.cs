// Задача: Написать программу, которая из имеющегося массива 
// строк формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести 
// с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


void Print(string[] array)
{
    int size = array.Length;
    Console.Write("[");

    for (int i = 0; i < size; i++)
    {
        Console.Write("“" + array[i] + "”");

        if (i != (size - 1))
        {
            Console.Write(" , ");
        }

    }

    Console.Write("]");
}

int GetAmount(string[] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        
        if (arr[i].Length <= 3)
        {
            count = count + 1;
        }
    }

    return count;
}

string[] SortArr(string[] arr, int lenght, string[] sortArr)
{
    int j = 0;
    string elem;
    for (int i = 0; i < arr.Length; i++)
    {        
        elem = arr[i];
        if (elem.Length <= 3)
        {
            sortArr[j] = arr[i];
            j = j + 1;
        }
    }

    return sortArr;
}
//обьявление исходного массива данных типа string
Console.WriteLine("Исходный массив: ");
string[] arr = new string[] { "Hello", "2", "world", ":-)"  };
//вывод на печать исходного массива
Print(arr);
Console.WriteLine();
Console.WriteLine();

//вызов метода определения количества элементов для нового массива
int lenght = GetAmount(arr);

//обьявление нового массива элементов 
string[] sortArr = new string[lenght];

//вызов метода сортировки исходного массива с записью в новый массив
SortArr(arr, lenght, sortArr);

//вывод на печать отсортированного массива
Console.WriteLine("Полученный массив: ");
Print(sortArr);











