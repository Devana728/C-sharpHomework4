// Напишите программу, которая принимает на вход число и выдаёт 
//сумму цифр в числе.452 -> 11
//82 -> 10
//9012 -> 12
int Prompt(string message)
{
    System.Console.Write(message);//вывести сообщение
    string readValue = Console.ReadLine();   //считывает с консоли строку
    int result = int.Parse(readValue);// преобразует строку в целое число
    return result;//возвращает результат
}
int Sum(int value)
{
    int result = 0;
    
    while(value>0)
    {
           
        result = result + value%10;
        value = value/10;
    }
    return result;
}

int value = Prompt("введите любое число ");
int result = Sum(value);
System.Console.WriteLine($"сумма всех чисел числа {value} равна {result}");