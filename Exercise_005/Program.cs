// Показать вторую цифру трёхзначного числа

int a = new Random().Next(100,1000);
Console.Write ("Дано число: ");
Console.WriteLine (a);

Console.Write ("Вторая цифра заданного числа: ");
Console.WriteLine ((a % 100) / 10);