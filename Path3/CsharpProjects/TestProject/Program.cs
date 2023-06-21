System.Console.WriteLine("a" == "a");
System.Console.WriteLine("a" == "A");
System.Console.WriteLine(1 == 2);

string MyValue = "a";
System.Console.WriteLine(MyValue == "a");

string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

Console.WriteLine("a" != "a");
Console.WriteLine("a" != "A");
Console.WriteLine(1 != 2);

string myValue = "a";
Console.WriteLine(myValue != "a");

Console.WriteLine(1 > 2);
Console.WriteLine(1 < 2);
Console.WriteLine(1 >= 1);
Console.WriteLine(1 <= 1);

string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));

// These two lines of code will create the same output

Console.WriteLine(pangram.Contains("fox") == false);
Console.WriteLine(!pangram.Contains("fox"));

int saleAmount = 1001;
int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {discount}");

int value = new Random().Next(2);
string result = value == 0 ? "heads" : "tails";
Console.WriteLine(result);

string permission = "Admin|Manager";
int level = 55;

bool isAdmin = permission.Contains("Admin") && level > 55;
bool isAdmin2 = permission.Contains("Admin") & level <= 55;
bool isManager = permission.Contains("Manager") && level >= 20;
bool isManager2 = permission.Contains("Manager") & level < 20;

if (isAdmin)
{
    Console.WriteLine("Welcome, Super Admin user.");
}
else if (isAdmin2)
{
    System.Console.WriteLine("Welcome, Admin user.");
}
else if (isManager)
{
    System.Console.WriteLine("Contact an Admin for access.");
}
else if (isManager2)
{
    System.Console.WriteLine("You do not have sufficient privileges.");
}
else
{
    System.Console.WriteLine("You do not have sufficient privileges.");
}
