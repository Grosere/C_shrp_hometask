/*Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоналачальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Пример:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
*/

// Создание Вывода в консоль

string[] Prompt(string msg)
{
    Console.Write(msg);
    return Console.ReadLine().Split("; ");                  //Ввод разделителя ";" 
}

string[] GetArrayOfThreeSymbols(string[] array)             //Инициализация функции GetArrayOfThreeSymbols
{
    int count = 0;                                          //Ввод переменной count для проведения расчетов в последовательности ввода строк в массив
    string[] preresult = new string[count];                 //Ввод параметра preresult, с присвоением ей значения новой строки
    string[] result = preresult;                            //Ввод параметра result, с присвоением ей значения preruslt
    for (int i = 0; i < array.Length; i++)                  //Проведем ввод массива строк
    {
        if (array[i].Length <= 3)                           //Выполнения условий задачи "длина которых меньше либо равна 3 символа"
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
