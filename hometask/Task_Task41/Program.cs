// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.


string[] array = WorkWithUser("Введите числа через запятую: ");
int[] collection = DigitOfString(array);
Console.WriteLine(CountPositive(collection));


string[] WorkWithUser(string message)
{
    Console.Write(message);
    string str = Console.ReadLine();
    string[] symb = str.Split(", ");
    return symb;
}
int[] DigitOfString(string[] symbs)// Преобразует строковый массив в целочисленный
{
    int[] digits = new int[symbs.Length];
    for (int i = 0; i < digits.Length; i++)
    {
        digits[i] = int.Parse(symbs[i]);
    }
    return digits;
}
int CountPositive(int[] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) res++;
    }
    return res;
}

void PrintArray(int[] array)//Выводит массив на печать
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1] + "]");
}