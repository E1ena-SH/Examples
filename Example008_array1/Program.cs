// Задача 8: найти max из 9-ти чисел (Стихийный подход)

// int a1 = 5;
// int a2 = 123;
// int a3 = 54;
// int a4 = 34;
// int a5 = 65;
// int a6 = 654;
// int a7 = 543;
// int a8 = 877879;
// int a9 = 2;

// int max = a1;
// if(a2 > max) max = a2;
// if(a3 > max) max = a3;
// if(a4 > max) max = a4;
// if(a5 > max) max = a5;
// if(a6 > max) max = a6;
// if(a7 > max) max = a7;
// if(a8 > max) max = a8;
// if(a9 > max) max = a9;

// Console.WriteLine(max);


// Задача 8: найти max из 9-ти чисел (решение методом)

int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int a1 = 5;
int a2 = 123;
int a3 = 54;
int a4 = 34;
int a5 = 66795;
int a6 = 654;
int a7 = 543;
int a8 = 99858;
int a9 = 2;

// int max1 = Max(a1, a2, a3);
// int max2 = Max(a4, a5, a6);
// int max3 = Max(a7, a8, a9);
// int max = Max(max1, max2, max3);

int max = Max(Max(a1, a2, a3), Max(a4, a5, a6), Max(a7, a8, a9));

Console.WriteLine(max);
