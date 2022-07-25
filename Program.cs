/*
*   Задача: 
    Написать программу, которая из имеющегося массива строк формирует массив из строк, 
    длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
    либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться 
    коллекциями, лучше обойтись исключительно массивами.

*   Примеры:
    ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
    ["1234", "1567", "-2", "computer science"] -> ["-2"]
    ["Russia", "Denmark", "Kazan"] -> []
*/


// Длина строк для поиска элементов.
const int charLimit = 3;

/*********************** MAIN BODY ************************/

// исходный массив зададим программно, для тестирования несколько вариантов
//string[] startArray = {"Boom", "-2", ":-)", "final"};
//string[] startArray = {"flexible", "start", "closes"};
string[] startArray = { "Hello", "word!", "It", "is", "array" };

string[] newArray = getNewArray(startArray, charLimit);


Console.Clear();
Console.WriteLine("start array:");
printArray(startArray);

Console.WriteLine("\nnew array:");
printArray(newArray);



/************************ METHODS ************************/

// Вывод масива на экран. Если массив пуст - выводит соответствующее сообщение.
//      array - массив для печати
// 
void printArray(string[] array)
{
    if (array.Length == 0)
    {
        Console.WriteLine("Array is empty");
    }
    else
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]}\t");
        }
        Console.WriteLine();
    }
}


// Расчет количества элементов исходного массива, длина которых меньше или равна определенной.
//      array - массив для расчета количества элементов
//      charLimit - длина элементов для поиска 
// 
int getSizeNewArray(string[] array, int charLimit)
{
    int result = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= charLimit)
        {
            result++;
        }
    }

    return result;
}

// Возвращает масив, сформированный из передаваемого в метод массива для поиска строк 
// равной или менее определенной длины. Если в исходном массиве нет значений 
// уловлетворяющих условию задачи - возвращает пустой массив. 
//      startArray - начальный массив строк для формирования нового массива
//      charLimit - ограничение длины строк
// 
string[] getNewArray(string[] startArray, int charLimit)
{
    string[] newArray = { };

    int sizeNewArray = getSizeNewArray(startArray, charLimit);

    if (sizeNewArray > 0)
    {
        newArray = new string[sizeNewArray];

        int i, k;
        for (i = k = 0; i < startArray.Length && k < newArray.Length; i++)
        {
            if (startArray[i].Length <= charLimit)
            {
                newArray[k] = startArray[i];
                k++;
            }
        }
    }

    return newArray;
}


