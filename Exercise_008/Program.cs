// Выяснить, кратно ли число заданному, если нет, вывести остаток

int number = new Random().Next(10,1000);
Console.Write ("Дано число: ");
Console.WriteLine (number);

Console.Write ("Введите любое число от 2 до 100: ");
int a = int.Parse (Console.ReadLine());

if (number % a == 0) {

    Console.Write ("Число ");
    Console.Write (number);
    Console.Write (" кратно числу ");
    Console.WriteLine (a);

} else {

    Console.Write ("Остаток от деления числа ");
    Console.Write (number);
    Console.Write (" на ");
    Console.Write (a);
    Console.Write (": ");
    Console.WriteLine (number % a);

}
