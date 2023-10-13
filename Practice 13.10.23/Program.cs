
//
//Задание 1
//
Console.WriteLine("Задание 1:");
List<int> numbers = new List<int> { 2, -1, -4, 5, 10, -1111, 56, 03, 11, 2001 };

List<int> plusNum = new List<int>(numbers);
plusNum.RemoveAll(i => i > 0);

List<int> minusNum = new List<int>(numbers);
minusNum.RemoveAll(i => i < 0);

Console.WriteLine("Содержимое List со всеми числами:");
foreach (int i in numbers)
    Console.WriteLine(i);

Console.WriteLine("Содержимое List с отрицательными числами:");
foreach (int i in plusNum)
    Console.WriteLine(i);

Console.WriteLine("Содержимое List с положительными числами:");
foreach (int i in minusNum)
    Console.WriteLine(i);

//
//Задание 2
//

Console.WriteLine("Задание 2:");

List<int> a = new List<int>();
Random rnd = new Random();
int CountOfElements = 10;
for (int i = 0; i < CountOfElements; i++)
{
    a.Add(rnd.Next(-100, 100));
}

Console.WriteLine("Содержимое List до сортировки:");
foreach (int i in a)
    Console.WriteLine(i);

Console.WriteLine("Содержимое List после сортировки от большего к меньшему:");
a.Sort();
a.Reverse();
foreach (int i in a)
    Console.WriteLine(i);