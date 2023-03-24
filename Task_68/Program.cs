/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */
/////////////////////////////////////////////////////////////////////////////////////////////////
Console.Clear();
ulong m = GetNumberFromUser("Введите неотрицательное целое значение m: ", "Ошибка ввода!");
ulong n = GetNumberFromUser("Введите неотрицательное целое значение n: ", "Ошибка ввода!");
Console.WriteLine($"m = {m}, n = {n} -> A(m, n) = {GetAkkermanFanction(m, n)}");
//////////////////////////////////////////////////////////////////////////////////
// Описание методов
// Запрашивает у пользователя целое неотрицательное число
ulong GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = ulong.TryParse(Console.ReadLine(), out ulong userNumber);
        if (isCorrect && userNumber >= 0)
        {
            return userNumber;
        }
        Console.WriteLine(errorMessage);
    }
}
// рекурсионный метод для вычисления функции Аккермана
ulong GetAkkermanFanction(ulong m, ulong n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return GetAkkermanFanction(m - 1, 1);
    }
    else
    {
        return GetAkkermanFanction(m - 1, GetAkkermanFanction(m, n - 1));
    }
}