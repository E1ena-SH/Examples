using System.Linq;

string text = "(1,2) (2,3) (4,5) (9,7)"
              .Replace("(", "") // заменили скобку
              .Replace(")", "") // заменили скобку
              ;
Console.WriteLine(text);

var data = text.Split(" ") //возьми текст, разбей (разделитель пробел)
                .Select(item => item.Split(',')) //возьми новую подстроку, раздели ее на несколько элементов с учетом символа ","
                .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1]))) // сделайте выборку из текущего массива, такого что первый элемент - х, второй - у
                .Where(e=> e.x % 2 == 0) // делаем проверку условия: дайте нам такие пары, где первая координата четная
                .Select(point => (point.x*10, point.y)) // point - точка // дайте нам тот набор, который мы получили на первом этапе и умножьте первую координату
                .ToArray(); // преобразуем в явный массив

for (int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i]);
    // for (int k = 0; k < data[i].Length; k++) Console.WriteLine(data[i][k]); // создаем подмассив в массиве 
    Console.WriteLine();
}