// Напишите программу принимает на ввод цифру обозначающую день недели и проверяет, является ли этот день выходным
Console.Clear();
Console.WriteLine("               ЗАДАЧА 15. НА ВВОД ЦИФРУ ДНЯ НЕДЕЛИ И ПРОВЕРЯЕТ ВЫХОДНОЙ ЛИ ЭТО)");
Console.WriteLine("Введите wbahe дня недели :");
int NumDay = Convert.ToInt32(Console.ReadLine());
if (NumDay > 0 && NumDay <= 7)
{
    if (NumDay <= 5)
    {
        Console.WriteLine("Введенный день недели является РАБОЧИМ днем");
    }
    else
    {
        Console.WriteLine("Введенный день недели является ВЫХОДНЫМ днем");
    }
}
else
{
    Console.WriteLine("Введенные данные неверны. Введите число от 1 до 7");
}


// Напишите программу которая выводит третью цифру заданного числа или сообщает что ее не сусществует
// Console.Clear();
Console.WriteLine("               ЗАДАЧА 13. НА ВВОД 3х ЗНАЧНОЕ ЧИСЛО И НА ВЫХОДЕ ВЫВЕСТИ ТРЕТЬЮ ЦИФРУ ЭТОГО ЧИСЛА ИЛИ СООБЩИТЬ ЧТО ЕЁ НЕ СУЩ");
Console.WriteLine("Введите трехзначное число :");
int numbXXX = Convert.ToInt32(Console.ReadLine());
if (numbXXX >= 100 && numbXXX < 999)
{
    int numbxxN = numbXXX%10;
    Console.WriteLine($"Третья цифра числа равна: {numbxxN}");
}
else if (numbXXX < 100)
{
    Console.WriteLine("Третьей цифры числа не существует тк число двузначное");
}
else
{
    int i = numbXXX;
    while (i > 999)
    {
    i = i / 10;
    }
    int numbxxN = i%10;
    /* for (int numbDel10 = numbXXX; numbDel10 < 999;  )
    int numbxxN = numbDel10; */
Console.WriteLine($"Третья цифра числа равна {numbxxN}");
}

// Напишите программу которая принимает на ввод трехзначное число и на выходе показывает вторую цифру этого числа
Console.WriteLine("               ЗАДАЧА 10. НА ВВОД 3х ЗНАЧНОЕ ЧИСЛО И НА ВЫХОДЕ ВЫВЕСТИ ВТОРУЮ ЦИФРУ ЭТОГО ЧИСЛА");
Console.WriteLine("Введите трехзначное число :");
int numXXX = Convert.ToInt32(Console.ReadLine());
if (numXXX < 100 && numXXX > 999)
{
    Console.WriteLine("Введено число неудовлетворяющих условию");
}
else
{
int numNxx = numXXX/100;
int numxxN = numXXX%10;
int numxNx = (numXXX-numNxx*100-numxxN)/10;
Console.WriteLine($"Вторая цифра числа равна {numxNx}");
}
