// Напишите цикл, который принимает на вход два числа (A и B)
//и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
int Prompt(string message)
{
    System.Console.Write(message); //вывести сообщение
    string readValue = Console.ReadLine(); //считывает с консоли строку
    int result = int.Parse(readValue); // преобразует строку в целое число
    return result; //возвращает результат
}



int Exponentiation(int A, int B)
{
    int answer = 1;

    if (B != 0 && B > 0)
    {
        for (int i = 0; i < B; i++)
        {
            answer = answer * A;
        }
    }

    return answer;
}
int A = Prompt("Введите число А : ");
int B = Prompt("Введите число В : ");
if (B<0)
{
    System.Console.WriteLine($"некорректный ввод");
}
else
{ 
    int answer = Exponentiation(A, B);
    System.Console.WriteLine($"число {A} в степени {B} равняется {answer}");

}