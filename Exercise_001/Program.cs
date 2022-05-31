// По заданному номеру дня недели вывести его название

Console.Write ("Введите число от 1 до 7 включительно:");
int dayNumber = int.Parse (Console.ReadLine());

if (dayNumber == 1) Console.WriteLine ("Первый день недели - понедельник.");
else if (dayNumber == 2) Console.WriteLine ("Второй день недели - вторник.");
else if (dayNumber == 3) Console.WriteLine ("Третий день недели - среда.");
else if (dayNumber == 4) Console.WriteLine ("Четвертый день недели - четверг.");
else if (dayNumber == 5) Console.WriteLine ("Пятый день недели - пятница.");
else if (dayNumber == 6) Console.WriteLine ("Шестой день недели - суббота.");
else if (dayNumber == 7) Console.WriteLine ("Седьмой день недели - воскресенье.");
else Console.WriteLine ("Заданное число не соответствует какому-либо дню недели!");