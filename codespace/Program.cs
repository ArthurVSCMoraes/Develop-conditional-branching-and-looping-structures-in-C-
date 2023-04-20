// the ourAnimals array will store the following: 
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";

// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 6];


// create some initial ourAnimals array entries
// string[,] ourAnimals =new string [1, 2] {
//     {
//         animalID,
//         animalNickname,
//         animalAge,
//         animalNickname,
//         animalPhysicalDescription,
//         animalSpecies
//     }
// };


for (int i = 0; i < maxPets; i++)
{
    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
}

// display the top-level menu options
readResult = Console.ReadLine();
if (readResult != null)
{
    menuSelection = readResult.ToLower();
}

// do ( readResult.ToLower() != "exit");
do
{
Console.Clear();

Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
Console.WriteLine(" 1. List all of our current pet information");
Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
Console.WriteLine(" 5. Edit an animal’s age");
Console.WriteLine(" 6. Edit an animal’s personality description");
Console.WriteLine(" 7. Display all cats with a specified characteristic");
Console.WriteLine(" 8. Display all dogs with a specified characteristic");
Console.WriteLine();
Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

}
while (menuSelection.ToLower() != "exit");

readResult = Console.ReadLine();
if (readResult != null)
{
    menuSelection = readResult.ToLower();
}

// string exitIsTrue = "exit";
switch (menuSelection)
{
    case "1":
    {
        Console.WriteLine("this app feature is coming soon - please check back to see progress.");
        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();
    };
    break;
    case "2": 
    {
        Console.WriteLine("this app feature is coming soon - please check back to see progress.");
        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();
    };
    break;
    case "3":
    {
        Console.WriteLine("this app feature is coming soon - please check back to see progress.");
        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();
    };
    break;
    case "4":
    {
        Console.WriteLine("this app feature is coming soon - please check back to see progress.");
        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();
    };
    break;
    case "5":
    {
        Console.WriteLine("this app feature is coming soon - please check back to see progress.");
        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();
    };
    break;
    case "6":
    {
        Console.WriteLine("this app feature is coming soon - please check back to see progress.");
        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();
    };
    break;
    case "7":
    {
        Console.WriteLine("this app feature is coming soon - please check back to see progress.");
        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();
    };
    break;
    case "8":
    {
        Console.WriteLine("this app feature is coming soon - please check back to see progress.");
        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();
    };
    break;
    default:
    {
        Console.WriteLine("Please select a option or type EXIT");
        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();
    };
    break;
}

Console.WriteLine($"You selected menu option {menuSelection}.");
Console.WriteLine("Press the Enter key to continue");

// pause code execution
readResult = Console.ReadLine();
     

