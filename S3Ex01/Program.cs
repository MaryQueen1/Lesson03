// Одна сложная
// Написать программу сложения матриц
//                    перемножения матриц

// 1xn
// (1, 2, 13, 51) + (3, 12 , 21, 51)

// (1, 2, 13, 51) x (3)
//                  (12)
//                  (21)
//                  (51)

// int[] matrix1 = {23, 123, 76, 98};

// int[] matrix2 = {34, 65, 7, 1298};

int[] CreateMatrix()
{
Console.WriteLine("Введите матрицу: ");
string? matrix = Console.ReadLine();
matrix = matrix.Replace(",", "");
matrix = matrix.Replace(".", "");

string[] mat = matrix.Split(" ");
int[] matr = new int[mat.Length];
    for(int i = 0; i < mat.Length; i++)
    {
        matr[i] = Convert.ToInt32(mat[i]);
    }
    return matr;
}

int[] matrix1 = CreateMatrix();
int[] matrix2 = CreateMatrix();

int[] Mat(int[] m1, int[] m2)
{
    int[] m3 = new int[m1.Length];
    for(int i = 0; i < m1.Length; i++)
    {
        m3[i] = m1[i] + m2[i];
        Console.Write($"{m3[i]} ");
    }
    return m3;
}

Mat(matrix1, matrix2);