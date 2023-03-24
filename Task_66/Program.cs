/* Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */
/////////////////////////////////////////////////////////////////////////////////////////////////
Console.Clear();
int M = GetNumberFromUser("Введите значение M: ", "Ошибка ввода!");
int N = GetNumberFromUser("Введите значение N: ", "Ошибка ввода!");
Console.WriteLine(M > N ? "Ошибка ввода! M должно быть больше N" : $"M = {M}; N = {N} -> {GetSumNumbersFromMToN(M, N)}");
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
int GetSumNumbersFromMToN(int M, int N)
{
    if (M == N)
    {
        return N;
    }
    else
    {
        return M + GetSumNumbersFromMToN(++M, N);
    }
}