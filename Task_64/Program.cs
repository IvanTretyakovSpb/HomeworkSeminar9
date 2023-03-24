/* Задача 64: Задайте значение N. 
Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */
/////////////////////////////////////////////////////////////////////////////////////////////////
Console.Clear();
int N = GetNumberFromUser("Введите целое положительно число: ", "Ошибка ввода!");
Console.WriteLine($"N = {N} -> {GetNumbersFromNTo1(N, 1)}");
//////////////////////////////////////////////////////////////////////////////////
// Описание методов
// Запрашивает у пользователя целое положительное число
int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect && userNumber > 0)
        {
            return userNumber;
        }
        Console.WriteLine(errorMessage);
    }
}
//
string GetNumbersFromNTo1(int N, int finish)
{
    if (N == finish)
    {
        return finish.ToString();
    }
    else
    {
        return N + ", " + GetNumbersFromNTo1(--N, finish);
    }

}