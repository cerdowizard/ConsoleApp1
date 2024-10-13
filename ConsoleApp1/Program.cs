// var myList = new List<string>();
// Console.WriteLine("Welcome to bank user using list");
// Console.WriteLine("Enter the operation you want to perform");
// while (true)
// {
//     PrintMenuList();
//
//     var userInput = Console.ReadLine();
//     
//     if(userInput == "1")
//     {
//         AddToList();
//     }
//     else if(userInput == "2")
//     {
//         GetAllList();
//     }
//     else if(userInput == "3")
//     {
//         break;
//     }
//     else if (userInput == "4")
//     {
//         Console.WriteLine("Enter the item you want to delete");
//         var delete_item = Console.ReadLine();
//         DeleteItemFromList(delete_item);
//     }
//     else
//     {
//         Console.WriteLine("Invalid input");
//     }
//     Console.WriteLine("Enter the operation you want to perform");
//     userInput = Console.ReadLine();
// }
// void PrintMenuList()
// {
//     Console.WriteLine(">> Enter 1 to add to your list");
//     Console.WriteLine(">> Enter 2 to get all your list");
//     Console.WriteLine(">> Enter 3 to exit");
//     Console.WriteLine(">> Enter 4 to delete item");
// }
//
// void AddToList()
// {
//     Console.WriteLine("Enter the item you want to add");
//     string item = Console.ReadLine();
//     myList.Add(item);
//     Console.WriteLine("Item added successfully");
// }
//
// void GetItemFromList()
// {
//     Console.WriteLine("Enter the item you want to get");
//     string item = Console.ReadLine();
//     if(myList.Contains(item))
//     {
//         Console.WriteLine("Item found");
//     }
//     else
//     {
//         Console.WriteLine("Item not found");
//     }
// }
//
// void DeleteItemFromList(string item)
// {
//     if(myList.Contains(item))
//     {
//         myList.Remove(item);
//         Console.WriteLine("Item deleted successfully");
//     }
//     else
//     {
//         Console.WriteLine("Item not found");
//     }
// }
// void GetAllList()
// {
//     Console.WriteLine("Your list is");
//     foreach (string item in myList)
//     {
//         Console.WriteLine(item);
//     }
// }

Console.WriteLine("Welcome to Fezz Buzz Game");
Console.WriteLine("Enter your start number");
int startNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your end number");
int endNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your fizz number");
int fizzNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your Buzz number:");
int buzzNumber = Convert.ToInt32(Console.ReadLine());
for (int i = startNumber; i <= endNumber; i++)
{
    if (i % fizzNumber == 0 && i % buzzNumber == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (i % fizzNumber == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (i % buzzNumber == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(i);
    }
}