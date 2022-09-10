// вид 1        Метод, который НИЧЕГО НЕ ВОЗВРАЩАеТ И НИЧЕГО НЕ ПРИНИМАеТ
// void Method1() // нет никаких аргументов
// {
//     Console.WriteLine("Автор ..."); // тело аргумента
// }

// Method1(); //вариант как вызывают такие методы (скобки обязательны)




// ВИД 2        Метод, который ничего не возвращает. но принимает аргументы
// void Method2(string msg) // указывается какое-то количество аргументов
// {
//     Console.WriteLine(msg); // тело аргумента
// }
// Method2(msg: "Текст сообщения"); // Консоль будет отображать именно это сообщение

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// // Method21("Текст", 4); либо смотри ниже:
// Method21(msg: "Текст", count: 4);




// ВИД 3 Метод, который возвращает, но аргументы не принимает
// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int Year= Method3();
// Console.WriteLine(Year);



// Вид 4 Метод, который что-то принимают и что-то возвращают
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i< count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

// string res = Method4(10, "text");
// Console.WriteLine(res);

// ==== ЦИКЛ "FOR"
                // ВЫВОД таблицы умножения

// for(int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i*j}"); // совместное выведение результата
//     }
//     Console.WriteLine();
// }
  

// ==== РАБОТА С ТЕКСТОМ
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".

// String text = "Я думаю, — сказал князь, улыбаясь, — что, "
//             + "ежели бы вас послали вместо нашего милого Винценгероде, "
//             + "вы бы взяли приступом согласие прусского короля."
//             + "Вы так красноречивы. Вы дадите мне чаю?";
// // string s = "qwerty"
// //             012345
// // s[3] = r

// string Replace (string text, char oldValue, char newValue)
// //              входной текст, конкретный символ, конкретный символ на который заменим
// {
//     string result = String.Empty; // Инициализация пустой строки
//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
// }

// String newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine(); // Начинаем второе преобразование текста
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine(); // Начинаем третье преобразование текста
// newText = Replace(newText, 'С', 'с');
// Console.WriteLine(newText);

// Найти позицию минимальноого элемента в неотсортированной части массива, 
// произвести обмен этого значения со значкением первой неотсортированной позиции. 
// Повторять пока есть неотсортированные позиции

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
         Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for(int i = 0; i < array.Length-1; i++)
    {
        int minPosition = i;
        for(int j = i+1; j < array.Length; j++)
        {
            if(array[i] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);