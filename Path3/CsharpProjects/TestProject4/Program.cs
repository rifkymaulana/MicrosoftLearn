for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i == 7) break;
}

for (int i = 10; i >= 0; i--)
{
    Console.WriteLine(i);
}

for (int i = 0; i < 10; i += 3)
{
    Console.WriteLine(i);
}

string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}

foreach (var name in names)
{
    // Can't do this:
    // if (name == "David") name = "Sammy";
}

for (int i = 0; i < names.Length; i++)
    if (names[i] == "David") names[i] = "Sammy";

foreach (var name in names) Console.WriteLine(name);

for (int i = 0; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0) System.Console.WriteLine("FizzBuzz");
    else if (i % 3 == 0) System.Console.WriteLine("Fizz");
    else if (i % 5 == 0) System.Console.WriteLine("Buzz");
    else System.Console.WriteLine(i);
}


