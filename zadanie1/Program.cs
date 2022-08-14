int Prompt(string message)
{
    System.Console.Write(message); // Вывести сообщение
    string readValue = Console.ReadLine(); // Считавает с консоли строку
    int result = int.Parse(readValue); // Преобрадует строку в целое число
    return result; // Возвращает результат
}

int value1;
value1 = Prompt("введите 3х значное число >");
if (value1 > 999 || value1 < 99)
{
        System.Console.WriteLine("вы ввели не 3х значное число");
    return;
}

int value2 = value1 / 10 % 10;
System.Console.WriteLine($"вторая цифра числа {value1} равна {value2}");