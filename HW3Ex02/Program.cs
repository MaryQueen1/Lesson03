// Напишите метод,
// который принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.WriteLine("Задача 21.");

Console.WriteLine("Введите координаты первой точки:");
Console.Write("x1 = ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("y1 = ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("z1 = ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки:");
Console.Write("x2 = ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("y2 = ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("z2 = ");
double z2 = Convert.ToDouble(Console.ReadLine());

double Formula(double x1, double y1, double z1,
               double x2, double y2, double z2)
               {
                double x3 = x2 - x1;
                double y3 = y2 - y1;
                double z3 = z2 - z1;
                double x4 = x3 * x3;
                double y4 = y3 * y3;
                double z4 = z3 * z3;
                double C1 = x4 + y4 +z4;
                double C = Convert.ToDouble(C1);
                C = Math.Sqrt(C1);
                Console.WriteLine($"Расстояние от первой до второй точки = {C}");
                return C;
               }

Formula(x1, y1, z1, x2, y2, z2);