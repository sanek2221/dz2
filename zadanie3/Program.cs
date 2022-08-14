// Функция, на вход получает параметр, на выходе введженнео с консоли значение
int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  // Считавает с консоли строку
    int result = int.Parse(readValue);      // Преобрадует строку в целое число
    return result;                          // Возвращает результат
}

//Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.

int num = Prompt("Введите число > ");
int num2 = num;
int i = 1;
if (num > 999)
{
    while (num > 999 & i > 0)
    {
        num = num / 10;
        i++;
    }
    int value2 = num % 10;
    System.Console.WriteLine($"третья цифра числа {num2} равна {value2}");
}
else
{ 
    System.Console.WriteLine($"Вы ввели меньше трех цифр"); 
}