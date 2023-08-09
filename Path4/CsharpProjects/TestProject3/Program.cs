string[] pallets = { "B14", "A11", "B12", "A13" };

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}


Console.WriteLine("");
string[] pallets1 = { "B14", "A11", "B12", "A13" };

Console.WriteLine($"Before: {pallets1[0].ToLower()}");
Array.Clear(pallets1, 0, 2);
if (pallets[0] != null)
    Console.WriteLine($"After: {pallets[0].ToLower()}");

Console.WriteLine($"Clearing 2 ... Count: {pallets1.Length}");
foreach (var pallet in pallets1)
{
    Console.WriteLine($"-- {pallet}");
}

if (pallets1[0] == null)
{
    Console.WriteLine("pallets[0] is null");
}

if (pallets1[1] == "")
{
    Console.WriteLine("pallets[1] is null");
}

Console.WriteLine("");
string[] pallets2 = { "B14", "A11", "B12", "A13" };

Array.Resize(ref pallets2, 6);
Console.WriteLine($"Resizing 6 ... Count: {pallets2.Length}");

pallets2[4] = "C01";
pallets2[5] = "C02";

foreach (var pallet in pallets2)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets2, 3);
Console.WriteLine($"Resizing 3 ... Count: {pallets2.Length}");

foreach (var pallet in pallets2)
{
    Console.WriteLine($"-- {pallet}");
}

string value = "abc123";
char[] valueArray = value.ToCharArray();

Console.WriteLine("Character Array...");
foreach (var item in valueArray)
{
    Console.WriteLine($"-- {item}");
}

Array.Reverse(valueArray);
string reversedValue = new string(valueArray);
Console.WriteLine($"Reversed String: {reversedValue}");
string joinedValue = string.Join(",", valueArray);
Console.WriteLine($"Joined String: {joinedValue}");

string[] items = joinedValue.Split(',');
foreach (var item in items)
{
    Console.WriteLine($"-- {item}");
}


string pangram = "The quick brown fox jumps over the lazy dog";
string[] reverseProgram = pangram.Split(' ');
string[] reverse = new string[reverseProgram.Length];
foreach (var item in reverseProgram)
{
    char[] charArray = item.ToCharArray();
    Array.Reverse(charArray);
    reverse[Array.IndexOf(reverseProgram, item)] = new string(charArray);
}

foreach (var item in reverse)
{
    Console.WriteLine($"-- {item}");
}

string resultPangram = string.Join(" ", reverse);
Console.WriteLine($"Reversed String: {resultPangram}");

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] orderArray = orderStream.Split(',');
Array.Sort(orderArray);
foreach (var item in orderArray)
{
    if (item.Length != 4)
    {
        Console.WriteLine($"-- Order #{item}\t- Error");
    }
    else
    {
        Console.WriteLine($"-- Order #{item}");
    }
}

