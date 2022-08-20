// Напишите метод, который принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.WriteLine("Задача 23");

Console.Write("Введите любое число от 1: ");
int N = Convert.ToInt32(Console.ReadLine());

void Cube(int number)
{
    for(int V = 1; V <= number; V++)
    {
        int K = V * V * V;
        Console.Write($"{K} ");
    }
}

Cube(N);