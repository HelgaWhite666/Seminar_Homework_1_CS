// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int number = new Random().Next(10,100);
Console.Write ("Дано число: ");
Console.WriteLine (number);

int a = number / 10;
Console.Write ("Первая цифра заданного числа: ");
Console.WriteLine (a);

int b = number % 10;
Console.Write ("Вторая цифра заданного числа: ");
Console.WriteLine (b);

if (a > b) {
    
    Console.Write ("Наибольшая цифра заданного числа: ");
    Console.WriteLine (a);

} else if (b > a) { 
    
    Console.Write ("Наибольшая цифра заданного числа: ");
    Console.WriteLine (b);

} else {

    Console.WriteLine ("Цифры заданного числа равны!");

}
