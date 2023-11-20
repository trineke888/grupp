// void PrintMatrix(int[,] matr) // [кол-во строк, кол-во столбцов]
// {
//     for (int i = 0; i < matr.GetLength(0); i++) // по стр, m = matrix.GetLength(0)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)// по стлб, n = matrix.GetLength(1)
//         {
//             Console.Write($"{matr[i, j]}\t"); 
//         }
//         Console.WriteLine();
//     }
// }


// // Задача 53: Задайте двумерный массив. Напишите программу,
// // которая поменяет местами первую и последнюю строку
// // массива.


// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] array2D = GetMatrix(rows, columns, 0, 10);

// PrintMatrix(array2D); // ДО замены

// Console.WriteLine("`Перевернутая` матрица");

// ChangeRows(array2D); // произошла замена строк
// PrintMatrix(array2D); // Модифицированная матрица
// int[,] GetMatrix(int m, int n, int min, int max)
// {
//     int[,] matrix = new int[m, n];  // m стр, n стлб
//     // [кол-во строк, кол-во столбцов]
//     for (int i = 0; i < m; i++) // по стр, m = matrix.GetLength(0)
//     {
//         // j, i, m, k
//         for (int j = 0; j < n; j++)// по стлб, n = matrix.GetLength(1)
//         {
//             matrix[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matr) // [кол-во строк, кол-во столбцов]
// {
//     for (int i = 0; i < matr.GetLength(0); i++) // по стр, m = matrix.GetLength(0)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)// по стлб, n = matrix.GetLength(1)
//         {
//             Console.Write($"{matr[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
// }

// void ChangeRows(int[,] matrix)
// {
//     int indexLastRow = matrix.GetLength(0) - 1;
//     for (int i = 0; i < matrix.GetLength(1); i++)
//     {
//         // 1 2 3
//         // 4 5 6
//         int temp = matrix[0, i]; // temp = matrix[0, 0], temp  = 1
//         matrix[0, i] = matrix[indexLastRow, i];
//         // 4 2 3
//         // 4 5 6
//         matrix[indexLastRow, i] = temp;
//         // 4    2 3  4 2 3
//         // temp 5 6 ,1 5 6
//     }
// }
// Введите количество строк: 4
// Введите количество столбцов: 4
// 3       1       6       1
// 3       1       1       7
// 0       3       4       1
// 10      7       7       3
// `Перевернутая` матрица
// 10      7       7       3
// 3       1       1       7
// 0       3       4       1
// 3       1       6       1


// // Задача 55: Задайте двумерный массив. Напишите программу,
// // которая заменяет строки на столбцы. В случае, если это
// // невозможно, программа должна вывести сообщение для
// // пользователя

// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] array2D = GetMatrix(rows, columns, 0, 10);

// if (rows != columns)
// {
//     Console.WriteLine("Такую матрицу перевернуть НЕЛЬЗЯ");
//     return; // None
// }

// PrintMatrix(array2D); // ДО замены
// Console.WriteLine("`Перевернутая` матрица");
//  // произошла замена строк
// PrintMatrix(ChangeMatrix(array2D)); // Модифицированная матрица
// int[,] GetMatrix(int m, int n, int min, int max)
// {
//     int[,] matrix = new int[m, n];  // m стр, n стлб
//     // [кол-во строк, кол-во столбцов]
//     for (int i = 0; i < m; i++) // по стр, m = matrix.GetLength(0)
//     {
//         // j, i, m, k
//         for (int j = 0; j < n; j++)// по стлб, n = matrix.GetLength(1)
//         {
//             matrix[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matr) // [кол-во строк, кол-во столбцов]
// {
//     for (int i = 0; i < matr.GetLength(0); i++) // по стр, m = matrix.GetLength(0)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)// по стлб, n = matrix.GetLength(1)
//         {
//             Console.Write($"{matr[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] ChangeMatrix(int[,] matr)
// {
//     int[,] result = new int[matr.GetLength(0), matr.GetLength(1)];
//     for (int i = 0; i < matr.GetLength(0); i++) // по стр, m = matrix.GetLength(0)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)// по стлб, n = matrix.GetLength(1)
//         {
//             result[j, i] = matr[i, j];
//             //j = 1(стл), i = 2(стр)
//             // result[1, 2] = matr[2,1]
//         }
//     }
//     return result;
// }

// Введите количество строк: 5
// Введите количество столбцов: 5
// 4       5       9       4       10
// 6       6       3       4       4
// 1       2       6       8       0
// 8       4       5       3       10
// 9       9       5       7       5
// `Перевернутая` матрица
// 4       6       1       8       9
// 5       6       2       4       9
// 9       3       6       5       5
// 4       4       8       3       7
// 10      4       0       10      5


// // Задача 59: Задайтедвумерный массив из целых чисел.
// // Напишите программу, которая удалит строку и столбец, на
// // пересечении которых расположен наименьший элемент
// // массива.
// int rows = 3;
// int columns = 3;
// int[,] matrix = new int[rows, columns];
// // Матрица изначально заполнена НУЛЯМИ
// int min = int.MaxValue;
// // [1000,2000,5000] , min = 5000 (перезапишем, min = 1000)
// // [5000,5000,5000] , min = 5000 (мы его не трогаем)
// int indexRow = 0;
// int indexColumn = 0;

// for (int i = 0; i < rows; i++) // по стр, m = matrix.GetLength(0)
// {
//     for (int j = 0; j < columns; j++)// по стлб, n = matrix.GetLength(1)
//     {
//         matrix[i, j] = new Random().Next(11); // [0;10]
//         Console.Write($"{matrix[i, j]}\t");
//         if (min > matrix[i, j])
//         {
//             min = matrix[i, j];
//             indexRow = i;
//             indexColumn = j;
//         }
//     }
//     Console.WriteLine();
// }
// Console.WriteLine($"min = {min}, [{indexRow}, {indexColumn}]");


// for (int i = 0; i < rows; i++)
// {
//     if (indexRow != i) // indexRow = 2
//     // i = 0,1,3,4,5 ...
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             if (indexColumn != j) //indexColumn = 3
//             // j = 0,1,2,4,5
//             {
//                 Console.Write($"{matrix[i, j]}\t");
//             }
//         }
//         Console.WriteLine();
//     }
// }

// 4       6       0
// 4       8       6
// 0       6       4
// min = 0, [0, 2]
// 4       8
// 0       6