string folderPath = @"C:\Data";
string filename = "shoppingList.txt";
string filepath = Path.Combine(folderPath, filename);
List<string> myShoppingList = new List<string>();

if (File.Exists(filepath))
{
    myShoppingList = GetItemsFromUser();
    File.WriteAllLines(filepath, myShoppingList);
}
else
{
    File.Create(filepath).Close();
    Console.WriteLine($"File {filename} has been created.");
    myShoppingList = GetItemsFromUser();
    File.WriteAllLines(filepath, myShoppingList);
}



static List<string> GetItemsFromUser()
{
    List<string> userList = new List<string>();

    while (true)
    {
        Console.WriteLine("Add an item (add)/ Exit (exit):");
        string userChoice = Console.ReadLine();

        if (userChoice == "add")
        {
            Console.WriteLine("Enter an item:");
            string userItem = Console.ReadLine();
            userList.Add(userItem);
        }
        else
        {
            Console.WriteLine("Bye!");
            break;
        }
    }
    return userList;
}



static void ShowItemsFromList(List<string> someList)
{
    Console.Clear();

    int listLength = someList.Count;
    Console.WriteLine($"You have added {listLength} items to your shopping list.");

    int i = 1;
foreach (string item in someList)
{
    Console.WriteLine($"{i}. {item}");
    i++;
} 
}
