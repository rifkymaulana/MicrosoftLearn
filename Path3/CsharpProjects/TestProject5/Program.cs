// Random random = new Random();
// int current = 0;

// do
// {
//     current = random.Next(1, 11);

//     if (current >= 8) continue;

//     Console.WriteLine(current);
// } while (current != 7);

// while (current >= 3)
// {
//     Console.WriteLine(current);
//     current = random.Next(1, 11);
// }
// Console.WriteLine($"Last number: {current}");

// int heroHealth = 10;
// int monsterHealth = 10;
// int heroAttack = 0;
// int monsterAttack = 0;

// Random random = new Random();
// do
// {
//     heroAttack = random.Next(1,11);
//     monsterHealth = monsterHealth - heroAttack;
//     System.Console.WriteLine($"Monster was damaged and lost {heroAttack} health and now has {monsterHealth} health.");
//     if (monsterHealth <= 0)
//     {
//         System.Console.WriteLine("Hero wins!");
//         break;
//     }

//     monsterAttack = random.Next(1,11);
//     heroHealth = heroHealth - monsterAttack;
//     System.Console.WriteLine($"Hero was damaged and lost {monsterAttack} health and now has {heroHealth} health.");

//     if (heroHealth <= 0)
//     {
//         System.Console.WriteLine("Monster wins!");
//         break;
//     }

// } while(true);

System.Console.WriteLine("Enter an integer value between 5 and 10");
int number = 0;
do
{
    try
    {
        number = Convert.ToInt32(System.Console.ReadLine());
        if (number >= 5 && number <= 10) break;
        else {
            Console.WriteLine($"You entered {number}. Please enter a number between 5 and 10.");
            continue;
        }
    }
    catch
    {
        System.Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }

} while(true);
System.Console.WriteLine($"Your input value {number} has been accepted.");

System.Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
bool state = true;
do
{
    string input = Console.ReadLine();
    input = input.Trim().ToLower();
    switch(input)
    {
        case "administator":
        case "manager":
        case "user":
            System.Console.WriteLine($"Your input value {input} has been accepted.");
            state = false;
            break;
        default:
            System.Console.WriteLine($"The role name that you entered, \"{input}\" is not valid. Enter your role name (Administrator, Manager, or User)");
            continue;
    }
} while(state);




string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    // extract sentences from each string and display them one at a time
    while (periodLocation != -1)
    {

        // first sentence is the string value to the left of the period location
        mySentence = myString.Remove(periodLocation);

        // the remainder of myString is the string value to the right of the location
        myString = myString.Substring(periodLocation + 1);

        // remove any leading white-space from myString
        myString = myString.TrimStart();

        // update the comma location and increment the counter
        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }

    // the remaining portion of speciesToListSelection is the final species name 
    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}