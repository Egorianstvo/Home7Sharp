#nullable disable
Console.Clear();

HomeWork();

void HomeWork()      //Started
{
    while (true)
    {
        System.Console.Write("Введите номер задачи(47, 50, 52, 62 или 0 для выхода): ");

        int tusk = int.Parse(Console.ReadLine());

        switch (tusk)
        {
            case 47:
                Console.Clear();
                System.Console.WriteLine("Tusk 47 Задайте двумерный массив размером m*n, заполненный случайными вещественными числами");

                int numRows = User("Enter Rows: ");
                int numColums = User("Enter Colums: ");

                int Min = User("Enter min: ");
                int Max = User("Enter max: ");

                var matrix = GetMatrix(numRows, numColums, Min, Max);
                Print(matrix);
                break;

            case 50:
                 Console.Clear();
                System.Console.WriteLine("Tusk 50 показывает есть ли  введенный элемент или нет");

                var matrixInt = GetIntMatrix(8, 8, 10, 100);
                PrintInt(matrixInt);
                IndexCordinate(matrixInt);
                break;

            case 52:
                Console.Clear();
                System.Console.WriteLine();
                System.Console.WriteLine("Tusk 52 Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");

                var matrixInt2 = GetIntMatrix(5, 5, 10, 100);

                PrintInt(matrixInt2);
                Averege(matrixInt2);
                break;

            case 62:
                Console.Clear();
                System.Console.WriteLine("Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.");
                int[,] matrixSpir = new int[4, 4];
                Spiral(matrixSpir);
                PrintInt(matrixSpir);
                break;

            case 0:
                return;
                break;

            default:
                Console.Clear();
                System.Console.WriteLine("Неверное значение");
                break;


        }
    }
}


int User(string NumberName)                        //Просим Пользователя ввести число
{
    System.Console.WriteLine($"{NumberName}");
    int Number = int.Parse(Console.ReadLine());
    return Number;
}


double[,] GetMatrix(int Rows, int Colums, int min, int max)     //Двумерный массив с случаными дробными
{
    double[,] matrix = new double[Rows, Colums];
    for (int i = 0; i < Rows; i++)
    {
        for (int j = 0; j < Colums; j++)
        {
            matrix[i, j] = Math.Round(new Random().Next(min, max + 1) + new Random().NextDouble(), 1);
        }
    }
    return matrix;
}



void Print(double[,] matrix)               // Выводим нашу матрицу дабл
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}



int[,] GetIntMatrix(int Rows, int Colums, int min, int max)        //рандомная интовая матрица
{
    int[,] matrix = new int[Rows, Colums];
    for (int i = 0; i < Rows; i++)
    {
        for (int j = 0; j < Colums; j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintInt(int[,] matrixInt)               // Выводим нашу матрицу инт
{
    for (int i = 0; i < matrixInt.GetLength(0); i++)
    {
        for (int j = 0; j < matrixInt.GetLength(1); j++)
        {
            System.Console.Write(matrixInt[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

void IndexCordinate(int[,] matrix)
{
    int UserNumber1 = User("Enter i rows Number: ");
    int UserNumber2 = User("Enter j colums Number: ");
    if (UserNumber1 < matrix.GetLength(0) && UserNumber2 < matrix.GetLength(1))
    {
        System.Console.WriteLine($"Number {matrix[UserNumber1, UserNumber2]}");
    }
    else System.Console.WriteLine("Error i and j");

    System.Console.WriteLine(" ");
}



void Averege(int[,] matrixInt2)
{
    for (int j = 0; j < matrixInt2.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrixInt2.GetLength(0); i++)

        {
            sum += matrixInt2[i, j];
        }
        Console.WriteLine();
        Console.Write($"Averege ");
        Console.Write($"{Math.Round(sum / matrixInt2.GetLength(0), 1)}" + " ");
    }
    Console.WriteLine();
}


void Spiral(int [,] matrix )      //спиралька
{

    int size = matrix.GetLength(0);
    int MaxSize = size - 1;

	int k = 1;
	int i = 0;
	int j = 0;
	
	while(k <= size*size)
	{
		matrix[i, j] = k;
        k++;
        if (i <= j + 1 && i + j < MaxSize)
            j++;
        else if (i < j && i + j >= MaxSize)
            i++;
        else if (i >= j && i + j > MaxSize)
            j--;
        else
            i--;
    }
   System.Console.WriteLine(matrix);
}
		