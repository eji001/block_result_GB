// Задача: Написать программу, которая из имеющегося массива строк
//формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры,
//либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями,
//лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


//массив с заданным размером строки
string[] AnArrayWithAGivenRovSize(string[] InitialArray, int StringLength)
{
    int FinalArrayLength = 0;
    for (int i = 0; i < InitialArray.Length; i++)
    {
        if (InitialArray[i].Length <= StringLength)
        {
            FinalArrayLength += 1;
        }
    }

    string[] FinalArray = new string[FinalArrayLength];
    int kFinalArray = 0;

    for (int i = 0; i < InitialArray.Length; i++)
    {
        if (InitialArray[i].Length <= StringLength)
        {
            FinalArray[kFinalArray] = InitialArray[i];
            kFinalArray++;
        }
    }

    return FinalArray;
}

// печать массива
void PrintArray(string[] myarr)
{
    if (myarr.Length > 0)
    {
        Console.Write($"[“");
        for (int i = 0; i < myarr.Length; i++)
        {
            Console.Write($"{myarr[i]}");
            if (i < myarr.Length - 1)
                Console.Write($"”, “");
        }
        Console.Write("”]");
    }
    else
        Console.Write("[]");
}

//вывод
void FinalPrint(string[] arr, int StringLength)
{
    string[] arrNew = AnArrayWithAGivenRovSize(arr, StringLength);

    PrintArray(arr);
    Console.Write(" → ");
    PrintArray(arrNew);
    Console.WriteLine("");
}



///
string[] arr1 = { "Hello", "2", "world", ":-)" };
string[] arr2 = { "1234", "1567", "-2", "computer science" };
string[] arr3 = { "Russia", "Denmark", "Kazan" };

int StringLength = 3;

FinalPrint(arr1, StringLength);
FinalPrint(arr2, StringLength);
FinalPrint(arr3, StringLength);
