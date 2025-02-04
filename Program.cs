using System.ComponentModel.Design;
using System.Runtime.ConstrainedExecution;

Console.WriteLine("Введите ваше имя");
string name = (Console.ReadLine());
Console.WriteLine("Введите вашу фамилию");
string lname = (Console.ReadLine());
Console.WriteLine("Введите ваш месяц рождения (числовым значением. Пример: 1)");
int month = Convert.ToInt32(Console.ReadLine());
if (month > 12)
{
    Console.WriteLine("Ошибка, вы ввели недопустимый месяц");
    return;
}
else if (month < 1)
{
    Console.WriteLine("Ошибка, вы ввели недопустимый месяц");
    return;
}
else
{
    Console.WriteLine($"Ваш месяц рождения: {month}");
}
Console.WriteLine("Введите ваш день рождение (числовым значение. Пример: 1)");
int day = Convert.ToInt32(Console.ReadLine());
if (day > 31)
{
    Console.WriteLine("Ошибка, вы ввели недопустимый день");
    return;
}
else if (day < 1)
{
    Console.WriteLine("Ошибка, вы ввели недопустимый день");
    return;
}

if (month == 1)
{
        if (day <= 20)
        {
            Console.WriteLine($"Ваше имя: {name}, ваша фамилия: {lname}, ваш знак зодиака Козерог");
        }
}

if (month == 1)
{
     if (day >= 21)
    {
        if (day <= 31)
        {
            Console.WriteLine($"Ваше имя: {name}, ваша фамилия: {lname}, ваш знак зодиака Водолей");
        }
    }
}

if (month == 2)
{
    if (day <= 21)
    {
        Console.WriteLine($"Ваше имя: {name}, ваша фамилия: {lname}, ваш знак зодиака Водолей");
    }
}

if (month == 2)
{
     if (day >= 21)
    {
        if (day <= 28)
        {
            Console.WriteLine($"Ваше имя: {name}, ваша фамилия: {lname}, ваш знак зодиака Рыбы");
        }
    }
}

if (month == 3)
{
    if (day <= 21)
    {
        Console.WriteLine($"Ваше имя: {name}, ваша фамилия: {lname}, ваш знак зодиака Рыбы");
    }
}

if (month == 3)
{
     if (day >= 21)
    {
        if (day <= 31)
        {
            Console.WriteLine($"Ваше имя: {name}, ваша фамилия: {lname}, ваш знак зодиака Овен");
        }
    }
}

if (month == 4)
{
    if (day <= 21)
    {
        Console.WriteLine($"Ваше имя: {name}, ваша фамилия: {lname}, ваш знак зодиака Овен");
    }
}

if (month == 4)
{
     if (day >= 21)
    {
        if (day <= 30)
        {
            Console.WriteLine($"Ваше имя: {name}, ваша фамилия: {lname}, ваш знак зодиака Телец");
        }
    }
}    

if (month == 5)
{
    if (day <= 21)
    {
        Console.WriteLine($"Ваше имя: {name}, ваша фамилия: {lname}, ваш знак зодиака Телец");
    }
}

if (month == 5)
{
    if (day >= 21)
    {
        if (day <= 31)
        {
            Console.WriteLine($"Ваше имя: {name}, ваша фамилия: {lname}, ваш знак зодиака Близнецы");
        }
    }
}    

if (month == 6)
{
    if (day <= 22)
    {
        Console.WriteLine($"Ваше имя: {name}, ваша фамилия: {lname}, ваш знак зодиака Близнецы");
    }
}

if (month == 6)
{
    if (day >= 22)
    {
        if (day <= 30)
        {
            Console.WriteLine($"Ваше имя: {name}, ваша фамилия: {lname}, ваш знак зодиака Рак");
        }
    }
}

if (month == 7)
{
    if (day <= 22)
    {
        Console.WriteLine($"Ваше имя: {name}, ваша фамилия: {lname}, ваш знак зодиака Рак");
    }
}

if (month == 7)
{
    if (day >= 23)
    {
        if (day <= 31)
        {
            Console.WriteLine($"Ваше имя: {name}, ваша фамилия: {lname}, ваш знак зодиака Лев");
        }
    }
}

if (month == 8)
{
    if (day <= 23)
    {
            Console.WriteLine($"Ваше имя: {name}, ваша фамилия: {lname}, ваш знак зодиака Лев");
    }
}

if (month == 8)
{
    if (day >= 24)
    {
        if (day <= 31)
        {
            Console.WriteLine($"Ваше имя: {name}, ваша фамилия: {lname}, ваш знак зодиака Дева");
        }
    }
}

if (month == 9)
{
    if (day <= 23)
    {
        Console.WriteLine($"Ваше имя: {name}, ваша фамилия: {lname}, ваш знак зодиака Дева");
    }
}

if (month == 9)
{
    if (day >= 24)
    {
        if (day <= 31)
        {
            Console.WriteLine($"Ваше имя: {name}, ваша фамилия: {lname}, ваш знак зодиака Весы");
        }
    }
}

if (month == 10)
{
    if (day <= 23)
    {
        Console.WriteLine($"Ваше имя: {name}, ваша фамилия: {lname}, ваш знак зодиака Весы");
    }
}

if (month == 10)
{
    if (day >= 24)
    {
        if (day <= 31)
        {
            Console.WriteLine($"Ваше имя: {name}, ваша фамилия: {lname}, ваш знак зодиака Скорпион");
        }
    }    
}

if (month == 11)
{
    if (day <= 23)
    {
        Console.WriteLine($"Ваше имя: {name}, ваша фамилия: {lname}, ваш знак зодиака Скорпион");
    }
}

if (month == 11)
{
    if (day >= 24)
    {
        if (day <= 31)
        {
            Console.WriteLine($"Ваше имя: {name}, ваша фамилия: {lname}, ваш знак зодиака Стрелец");
        }
    }
}

if (month == 12)
{
    if (day >= 21)
    {
        Console.WriteLine($"Ваше имя: {name}, ваша фамилия: {lname}, ваш знак зодиака Стрелец");
    }
}

if (month == 12)
{
    if (day >= 22)
    {
        if (day <= 31)
        {
            Console.WriteLine($"Ваше имя: {name}, ваша фамилия: {lname}, ваш знак зодиака Козерог");
        }
    }
}

Console.ReadKey();