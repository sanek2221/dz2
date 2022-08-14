int value1 = new Random().Next(100, 999);
System.Console.WriteLine(value1);
int value2 = value1 / 100 % 10;
int value3 = value1 % 10;
System.Console.WriteLine($"{value2} {value3}");