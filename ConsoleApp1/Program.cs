// See https://aka.ms/new-console-template for more information
Random random = new Random();
Console.WriteLine("Start");
task17();

//////////
int[] initArr(int size, int randomMin = 0, int randomMax = 10)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
        arr[i] = random.Next(randomMin, randomMax);
    foreach (var item in arr)
        Console.Write(item + " ");
    Console.WriteLine();
    return arr;
}

void paintArr<T>(IEnumerable<T> arr)
{
    foreach (var item in arr)
        Console.Write(item + " ");
}
 void task1() //ищем четные числа
{
    int[] arr = initArr(10);

    foreach (var item in arr.Where(x => x % 2 == 0))
        Console.WriteLine(item + " ");
}
void task2() // ищем числа от 1 до 11
{
    int[] arr = initArr(20, -10, 20);

    foreach (var item in arr.Where(x => x >= 1 && x <= 11))
        Console.Write(item + " ");

}
void task3() // возводим в квадрат
{
    int[] arr = initArr(10);
    paintArr<double>(arr.Select(x => Math.Pow(x, 2)));
}
void task4() // подсчет встречаемости числа в массиве
{
    int[] arr = initArr(20, 0, 10);
    foreach (var item in arr.GroupBy(x => x).Select(x => new { num = x.Key, count = x.Count() }))
        Console.WriteLine($"num: {item.num} count:{item.count}");
}
void task5(string word) // частота символов в строке 
{
    foreach (var letter in 
        word.Where(x => !x.Equals(' ')).Select(x=> x.ToString().ToLower())
        .GroupBy(x => x).Select(x => new { letter = x.Key, count = x.Count() }))
        Console.WriteLine($"letter: {letter.letter} count:{letter.count}");
}
void task6() // умножение числа на его частоту
{
    int[] arr = initArr(20);
    foreach (var item in
        arr.GroupBy(x => x).Select(x => new { num = x.Key, count = x.Count(), fran = x.Key * x.Count() })
        )
        Console.WriteLine($"{item.num} * {item.count} = {item.fran}");

}
void task7(char start, char end)  // поиск по началу и по концу
{
    string[] cities = new string[] { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };
    foreach (var item in cities.Where(x => x.ToLower().StartsWith(start) && x.ToLower().EndsWith(end)))
        Console.WriteLine(item);
}
void task8() // сортировка
{
    int[] arr = initArr(20,0,30);
    paintArr<int>(arr.OrderBy(x => x));

}
void task9() // сортировка + отображение топ 5
{
    int[] arr = initArr(20, 0, 30);
    paintArr<int>(arr.OrderBy(x => x).Take(5));

}
void task10(string str) // поиск слов только в верхнем регистре
{
    foreach (var item in
        str.Split(" ").Where(x => x.Equals(x.ToUpper())))
        Console.WriteLine(item);
}
void task11()
{
    string[] arr = new string[3] { "cat", "dog", "bird" };
    Console.WriteLine(string.Join(",", arr));
}
void task12(int n) // остортировать и получить n-й элемент
{
    int[] arr = initArr(10, 20, 100);
    paintArr<int>(arr.OrderByDescending(x => x));
    Console.WriteLine();
    paintArr<int>(arr.OrderByDescending( x => x).Skip(n-1).Take(1));
}
void task13() // подсчет форматов файлов
{
    string[] arr = new string[] {"aaa.frx", "bbb.TXT", "xyz.dbf","abc.pdf", "aaaa.PDF","xyz.frt", "abc.xml", "ccc.txt", "zzz.txt" };
    foreach (var item in 
        arr.GroupBy(x => x.Split('.').Last().ToLower())
        .Select(x => new {name = x.Key, count = x.Count()})
        )
        Console.WriteLine($"{item.name} {item.count}");
}
void task14(string str, string del) // подсчет форматов файлов
{
    foreach (var item in
        str.Remove(
            str.IndexOf
            (str.First(x => x.ToString().ToLower().Equals(del.ToLower()))
                ), 1
            ))
        Console.WriteLine(item);
}
void task15(int start, int count) //удаление диапазона
{
    int[] arr = initArr(10);
    List<int> list = arr.ToList();
    list.RemoveRange(start, count);
    paintArr<int>(list.ToArray());
}
void task16() // двойная сортировка
{
    string[] arr = new string[]
    {
        "ROME","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI", "PARIS"
    };
    foreach (var item in arr.OrderBy(x => x.Length).ThenBy(x => x))
        Console.WriteLine(item);


}
void task17() // группировка по первому символу
{
    string[] arr = new string[]
    {
        "ROME","ROSTOV","ZELENOGORSK","LIAMA","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI", "PARIS"
    };
    foreach (var item in arr.GroupBy(x => x[0]))
    { 
        Console.WriteLine(item.Key);
        foreach (var element in item)
            Console.WriteLine(element);
    }
        


}
record class Person(string Name, string Company);