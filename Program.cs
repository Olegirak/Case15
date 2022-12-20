// Программа принимает на вход цифру дня недели и проверяет выходной
int N = int.Parse(Console.ReadLine());
if (N<1 || N>7)
{
    Console.WriteLine("Ошибка ввода");
}
else
{
    if (N == 6 || N ==7)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}