// Вариация на тему "найти максимальное из трех чисел". 
// Очень было интересно, как еще можно сделать + сообщить, если все числа равны

Console.Write ("Введите число 1: ");
int a = int.Parse (Console.ReadLine());

Console.Write ("Введите число 2: ");
int b = int.Parse (Console.ReadLine());

Console.Write ("Введите число 3: ");
int c = int.Parse (Console.ReadLine());

if (a > b && a > c) {
    Console.Write ("Наибольшее число = ");
    Console.WriteLine (a);
} else if (b > a && b > c) {
    Console.Write ("Наибольшее число = ");
    Console.WriteLine (b);
} else if (c > a && c > b) {
    Console.Write ("Наибольшее число = ");
    Console.WriteLine (c);
 }else {
    Console.WriteLine ("Числа равны!");
 }