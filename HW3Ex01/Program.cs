// Напишите метод,
// который принимает на вход шестизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
// строки использовать нельзя

Console.Clear();
Console.WriteLine("Задача 19");

Console.WriteLine("Введите шестизначное число: ");
string? SixDigitNumber = Console.ReadLine();


void Palindrome(string SixDigitNumber)
{
    if(SixDigitNumber[0] == SixDigitNumber[5] &
       SixDigitNumber[1] == SixDigitNumber[4] &
       SixDigitNumber[2] == SixDigitNumber[3])
    {
        Console.WriteLine("Число является палиндромом");
    }
    else
    {
        Console.WriteLine("Число НЕ является палиндромом");
    }
}


void CheckingNumber(string SixDigitNumber)
{
    if(SixDigitNumber!.Length == 6)
    {
        Palindrome(SixDigitNumber);
    }
    else
    {
        Console.WriteLine("Вы ввели не шестизначное число!");
    }
}

CheckingNumber(SixDigitNumber);