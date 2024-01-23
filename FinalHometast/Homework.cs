/*
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоналачальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Пример:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
*/

using System;

string[] Prompt(string msg)                                 // Добавление функции записи элементов массива с разделением через ";"
{
    Console.Write(msg);
    return Console.ReadLine().Split("; ");                   
}

string[] GetArrayOfThreeSymbols(string[] array)             //Инициализация функции GetArrayOfThreeSymbols который проверяет символьность "не более 3 символов"
{
    int count = 0;                                          
    string[] preresult = new string[count];                 
    string[] result = preresult;                            
    for (int i = 0; i < array.Length; i++)                  
    {
        if (array[i].Length <= 3)                           
        {
            count++;                                        
            preresult = new string[count];                  
            for (int j = 0; j < preresult.Length - 1; j++)   
            {
                preresult[j] = result[j];
            }
            preresult[count - 1] = array[i];
            result = preresult;
        }
    }
    return result;
}

void PrintArray(string[] array)                             //Вывод полученного массива
{
    string mass = "[";
    if (array.Length > 0)
    {
        mass += "\"" + array[0] + "\"";
        for (int i = 1; i < array.Length; i++)
        {
            mass += ", \"" + array[i] + "\"";
        }
    }
    mass += "]";
    Console.Write(mass);
}

                                                        // Выполнения тела программы
string[] arrayOfStrings = Prompt("Введите элементы массива строк, отделяя каждый элемент массива точкой с запятой и пробелом (; ): ");
string[] arrayOfThreeSymbols = GetArrayOfThreeSymbols(arrayOfStrings);
Console.Write("Сформированный массив из элементов введенного массива ");
PrintArray(arrayOfStrings);
Console.Write(", длина которых меньше или равна 3 символам, равен ");
PrintArray(arrayOfThreeSymbols);
