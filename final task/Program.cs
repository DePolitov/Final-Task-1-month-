/* Задача: Написать программу, которая из имеющегося массива строк формирует
новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный 
массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
 При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []                              */
Console.Clear();
string[] array = new string[new Random().Next(2, 10)];
ArrayCreate(array);
ArrayPrintOut(array);
string[] NewArray = new string[CountLessTree(array)];  // Новый мвссив строк с менее или равно 3 элементам
int j = 0;                                             //Счетчик элемента нового массива
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        NewArray[j] = array[i];
        j++;
    }

}
Console.Write(" -> ");
ArrayPrintOut(NewArray);

void ArrayPrintOut(string[] arr2)          // Функция вывода массива строк
{
    Console.Write("[");
    for (int i = 0; i < arr2.Length; i++)
    {
        Console.Write($"'{arr2[i]}' ");
    }
    Console.Write("]");
}

int CountLessTree(string[] arr2)          // Функция определения количества элеметов менее 3 символов
{
    int count = 0;
    for (int i = 0; i < arr2.Length; i++)
        if (arr2[i].Length <= 3) count++;
    return count;
}

void ArrayCreate(string[] arr2)         //Функция создания массива
{
    for (int i = 0; i < arr2.Length; i++)
    {
        Console.Write($"Введите {i + 1} строку массива -  ");
        arr2[i] = Console.ReadLine();
    }
}



