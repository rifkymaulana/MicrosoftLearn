int first = 2;
string second = "4";
string result = first + second; // Error: Cannot implicitly convert type 'string' to 'int'
System.Console.WriteLine(result);

System.Console.WriteLine();
int myInt = 3;
Console.WriteLine($"int: {myInt}");

decimal myDecimal = myInt;
Console.WriteLine($"decimal: {myDecimal}");


System.Console.WriteLine();
decimal myDecimal1 = 3.14m;
Console.WriteLine($"decimal: {myDecimal1}");

int myInt1 = (int)myDecimal1;
Console.WriteLine($"int: {myInt1}");

System.Console.WriteLine();
decimal myDecimal2 = 1.23456789m;
float myFloat2 = (float)myDecimal2;

Console.WriteLine($"Decimal: {myDecimal2}");
Console.WriteLine($"Float  : {myFloat2}");

System.Console.WriteLine();
int first2 = 5;
int second2 = 7;
string message2 = first2.ToString() + second2.ToString();
Console.WriteLine(message2);

System.Console.WriteLine();
string first3 = "5";
string second3 = "7";
int sum3 = int.Parse(first3) + int.Parse(second3);
Console.WriteLine(sum3);

System.Console.WriteLine();
string value1 = "5";
string value2 = "7";
int result4 = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result4);

System.Console.WriteLine();
int value = (int)1.5m; // casting truncates
Console.WriteLine(value);

int value3 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value3);

int value4 = Convert.ToInt32(1.2m); // converting rounds down
Console.WriteLine(value4);

Console.WriteLine();
string value5 = "bad";
int result5 = 0;
if (int.TryParse(value5, out result5))
{
    Console.WriteLine($"Measurement: {result5}");
}
else
{
    Console.WriteLine("Unable to report the measurement.");
}
if (result5 > 0)
    Console.WriteLine($"Measurement (w/ offset): {50 + result5}");

Console.WriteLine();
string[] values = { "12.3", "45", "ABC", "11", "DEF" };
string message = "";
decimal total = 0m;
foreach(var value6 in values)
{
    if (decimal.TryParse(value6, out decimal number))
    {
        total += number;
    }
    else
    {
        message += $"{value6}";
    }
}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");
