// ===== ДВУМЕРНЫЕ МАССИВЫ =====

// string[,]table = new string[2,3]; 
// тип данных["," - указание к тому, что у нас две размерности(строки и столбцы)] наименование = new string [строки, столбцы]

// int[,] matrix = new int[5,8]; 5 строк, 8 столбцов

// string[,] table = new string[2,5];
// // String.Empty - инициализация для строк  
// // table[0,0]  table[0,1]  table[0,2]  table[0,3]  table[0,4]
// // table[1,0]  table[1,1]  table[1,2]  table[1,3]  table[1,4]
// table[1,2]="word";

// for(int rows = 0; rows<2; rows ++)
// {
//     for(int colums =0; colums<5; colums++)
//     {
//         Console.WriteLine($"{table[rows,colums]}---");  запись массива все значения в 1 столбце
//     }
// }


// void PrintArray(int[,] matr) // СОЗДАТЬ МАТРИЦУ
// {
//     for (int i = 0; i< matr.GetLength(0); i++) // matrix.GetLength(0) - длина строк
//     {
//         for (int j = 0; j<matr.GetLength(1); j++) // matrix.GetLength(1) - длина столбцов
//         {
//             Console.Write($"{matr[i,j]} ");
//         }
//         Console.WriteLine();  //для красивого вывода матрицы(после прохождения цикла i будет новая строка)
//     }
// }

// void FillArray(int[,] matr) // ЗАПОЛНИТЬ МАТРИЦУ
// {
//     for (int i = 0; i< matr.GetLength(0); i++) // matrix.GetLength(0) - длина строк
//     {
//         for (int j = 0; j<matr.GetLength(1); j++) // matrix.GetLength(1) - длина столбцов
//         {
//             matr[i,j] = new Random().Next(1,10);
//         }
//     }
// }

// int[,] matrix = new int [3,4];
// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);

// ==== РЕКУРСИЯ ==== Это функция, которая вызывает саму себя

// Факториал: 5! = 5*4*3*2*1
//                 5*4!
//                   4*3!
//                     3*2!
// double Factorial (int n) // double - виещает больший размер аргументов, в отличии от int
// {
//     // 1! = 1
//     // 0! = 1
//     if (n == 1) return 1;
//     else return n*Factorial(n - 1);
// }
// for (int i =1; i<40; i++)
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}"); // 5!=1*2*3*4*5 = 120
// }

// f(1) = 1
// f(2) = 1
// f(n) = f(n-1)+f(n-2)

double Fibonacci(int n)
{
    if (n ==1 || n==2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2); // return вернуть значение  фибоначи
}

for (int i=1; i<10; i++) Console.WriteLine($"f({i}) = {Fibonacci(i)}");