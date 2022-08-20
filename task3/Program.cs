// Напишите программу, которая задаёт массив из 8 элементов
//случайными числами и выводит их на экран. Также ищет второй
// максимум (число меньше максимального элемента, но больше всех
//остальных) Оформите заполнение массива и вывод в виде функции
// 1,2,5,7,19,1,2,8 -> 1,2,5,7,19,1,2,8 -> 8
int Prompt(string message)
{
    System.Console.Write(message); //вывести сообщение
    string readValue = Console.ReadLine(); //считывает с консоли строку
    int result = int.Parse(readValue); // преобразует строку в целое число
    return result; //возвращает результат
}
int[] GeneraitArray(int Length)
{
    int[] array = new int[Length];
    int i = 0;
    while (i < array.Length)
    {
        array[i] = new Random().Next(0, 100);
        i++;
    }
    return array;
}

// вывод массивав строку
void printArray(int[] array)
{
    int count = 0;
    while (count < array.Length)
    {
        System.Console.Write($"{array[count]}\t");
        count++;
    }
    System.Console.WriteLine();
}
int[] array = GeneraitArray(8);
printArray(array);

int SeachSecontMax(int[] array)
{
    int max1 = array[0];
    int max2 = array[1];
    for (int i = 0; i < array.Length; i++)
        if (array[i] > max1)
        {
            max2 = max1;
            max1 = array[i];
        }
        else
        {
            if (array[i] > max1 && array[i] < max2)
            {
                max2 = array[i];
            }
        }
    return max2;
}
System.Console.WriteLine($"Второй максимум равен {SeachSecontMax(array)}");
