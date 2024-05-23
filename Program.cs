string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] items = orderStream.Split(",");
Array.Sort(items);
for (int i = 0; i < items.Length; i++) {
    if (items[i].Length == 4)
        Console.WriteLine(items[i]);
    else
        Console.WriteLine($"{items[i]}\t- Error");
}