// Функция, на вход получает параметр, на выходе введженнео с консоли значение
int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  // Считавает с консоли строку
    int result = int.Parse(readValue);      // Преобрадует строку в целое число
    return result;                          // Возвращает результат
}

int day = Prompt("Введите день недели (0 - 7) > ");
if (day > 7)
{  System.Console.Write($"вы ввели неверный день недели");}
if (day <= 5)
{
    if (day == 1)
    {
        System.Console.Write($"Понедельник");
    }
    if (day == 2)
    {
        System.Console.Write($"вторник");
    }
    if (day == 3)
    {
        System.Console.Write($"среда");
    }
    if (day == 4)
    {
        System.Console.Write($"четверг");
    }
    if (day == 5)
    {
        System.Console.Write($"пятница");
    }
    System.Console.WriteLine($" - будний день");
    return;
}
if (day == 6 || day == 7)
{
    if (day == 6)
    {
        System.Console.Write($"суббота");
    }
    if (day == 7)
    {
        System.Console.Write($"воскресенье");
    }
    System.Console.WriteLine($" - выходной день");
    return;
}