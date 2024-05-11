// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// ["Hello", "2", "world", ":-)"] → ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] → ["-2"]
// ["Russia", "Denmark", "Kazan"] → []

string[] array = {"Hello", "2", "world", ":-)"};

int countLengthNewArray = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        countLengthNewArray++;
    }
}

string[] CreateArrayElementLengthLessOrEqualThree(string[] array, int countLengthNewArray)
{
    string[] newArray = new string[countLengthNewArray];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"\"{array[i]}\", ");
        }
        else
        {
            Console.Write($"\"{array[i]}\"");
        }
    }
    Console.Write("]");
}

string[] newArray = CreateArrayElementLengthLessOrEqualThree(array, countLengthNewArray);
PrintArray(array);
Console.WriteLine();
PrintArray(newArray);

