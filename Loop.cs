/*
string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
// fraudulentOrderIDs[3] = "D000";
*/

/*
string[] fraudulentOrderIDs = ["A123", "B456", "C789"];

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");
*/

/*
int[] inventory = {200, 450, 700, 175, 250};
int sum = 0;
int bin = 0;

foreach(int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}

Console.WriteLine($"We have {sum} items in inventory.");
*/

/*
string[] orderIDs = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];

foreach(string id in orderIDs)
{
    if(id.StartsWith("B"))
    {
        Console.WriteLine(id);
    }
}
*/

/*
string firstName = "Bob";
int widgetsPurchased = 7;
Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets.");
*/

/*
    The following code creates five random OrderIDs
    to test the fraud detection process. OrderIDs 
    consist of a letter from A to E, and a three 
    digit number. Ex. A123.
*/

/*
Random random = new Random();
string[] orderIDs = new string[5];

for (int i = 0; i < orderIDs.Length; i++)
{
    int prefixValue = random.Next(65, 70);

    string prefix = Convert.ToChar(prefixValue).ToString();
  
    string suffix = random.Next(1,1000).ToString("000");
    
    orderIDs[i] = prefix + suffix;
}

foreach (var orderID in orderIDs) 
{
    Console.WriteLine(orderID);
}
*/

/*
    To create an char arrray, reverse it,
    and count the number of times a particular
    character appears
*/
/*
string str = "The quick brown fox jumps over the lazy dog.";

char[] message = str.ToCharArray();
Array.Reverse(message);

int letterCount = 0;

foreach (char letter in message) 
{ 
    if (letter == 'o') 
    { 
        letterCount++; 
    } 
}

string new_message = new String(message);

Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {letterCount} times.");
*/