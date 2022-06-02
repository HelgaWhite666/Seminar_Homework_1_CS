// Показать последнюю цифру трёхзначного числа

double a = new Random().Next(100,1000);
Console.Write ("Дано число: ");
Console.WriteLine (a);

Console.Write ("Последняя цифра заданного числа: ");
Console.WriteLine (a % 10);