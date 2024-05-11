# Эта программа создана для того, чтобы решить следующую задачу.

**Задача:** Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

**Примеры:**
["Hello", "2", "world", ":-)"] → ["2", ":-)"]
["1234", "1567", "-2", "computer science"] → ["-2"]
["Russia", "Denmark", "Kazan"] → []

## Решение:

1. Первым шагом задаем изначальный массив строк:  
    ```
    string[] array = {"Hello", "2", "world", ":-)"};
    ```
2. Далее для создания нового массива необходимо определить сколько фрагментов памяти он займет, т.е. определяем его длину. Для хранения этой информации вводим целочисленную переменную *countLengthNewArray*, которая изначально будет равна нулю:
    ```
    int countLengthNewArray = 0;
    ```
3. Т.к. новый массив необходимо создать из изначального по заданным параметрам, то проходим по всем элементам изначального массива в поисках элементов, удовлетворяющих условию *"строки, 
длина которых меньше, либо равна 3 символам"*. Для этого используем цикл  **for** и условие **if**. 
Когда находим подходящий элемент, то увеличиваем длину нового массива на единицу и так каждый раз пока не пройдем по всем элементам изначального массива:
    ```
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            countLengthNewArray++;
        }
    }
    ```
4. Теперь создаем новый массив из элементов изначального. Для этого создадим функцию *CreateArrayElementLengthLessOrEqualThree*.Длина нового массива будет равна итоговому значению переменной *countLengthNewArray*. Для обращения к элементам нового массива вводим новую переменную *j*. Для заполнения нового массива элементами изначального массива, удовлетворяющими условию *"строки, 
длина которых меньше, либо равна 3 символам"*, необходимо присвоить элементам J значение элементов i. Для этого снова придется пройтись по всем элементам изначального массива:
    ```
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
    ```
    5. Чтобы увидеть результат, необходимо вывести его на экран, используем для этого функцию *"PrintArray"*:
    ```
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
    ```
    6. Т.к. в решении присутствуют функции, к ним необходимо обратиться, чтобы они заработали. Вызываем функции следующим образом:
    ```
    string[] newArray = CreateArrayElementLengthLessOrEqualThree(array, countLengthNewArray);
    PrintArray(array);
    Console.WriteLine();
    PrintArray(newArray);
    ```
        
    Т.к. массива у нас теперь два, то к функции *PrintArray* обращаемся дважды - для изначального и нового массива.
    