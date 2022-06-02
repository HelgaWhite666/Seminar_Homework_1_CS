// Удалить вторую цифру трёхзначного числа

int number = new Random().Next(100,1000);
Console.Write ("Дано число: ");
Console.WriteLine (number);

int a = number / 100;
Console.Write ("Первая цифра заданного числа: ");
Console.WriteLine (a);

int b = (number % 100) / 10;
Console.Write ("Вторая цифра заданного числа: ");
Console.WriteLine (b);

int c = number % 10;
Console.Write ("Последняя цифра заданного числа: ");
Console.WriteLine (c);

Console.Write ("Число без второй цифры: ");
Console.Write (a);
Console.WriteLine (c);


