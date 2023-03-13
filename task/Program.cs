/* Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна
 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
 При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.  */

 string[] arr = new string[] {"2","hello", "world", ":-)", "123", "hi"};

 string[] resultArr = new string[arr.Length];

 string[] GetArray (string[] arr, string[] resultArr)
 {
    int j = 0; 
    for (int i = 0; i < arr.Length; i++)
    {
        
        if (arr[i].Length <= 3)
        {
            resultArr[j] = arr[i];
            j++;
        }

    }
    return resultArr;
 }

 void PrintArray(string[] resultArray)
{
    for (int i = 0; i < resultArray.Length; i++)
    {
        Console.Write($"{resultArray[i]} ");
    }
    Console.WriteLine("");
}

string[] resultArray = GetArray(arr, resultArr);
PrintArray(resultArray);

