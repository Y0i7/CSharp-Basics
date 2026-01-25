/*
    Aplicación para almacenar información de las mascotas que se encuantran bajo cuidado
    Despliega un menún de opciones el cual funciona mediante bucles, para ver el listado
    e información de cada mascota registrada, agreagar una nueva, etc.

*/

const int MaxPets = 8;
const int MaxCharacteristics = 6;

// the ourAnimals array will store the following: 
var animalSpecies = "";
var animalID = "";
var animalAge = "";
var animalPhysicalDescription = "";
var animalPersonalityDescription = "";
var animalNickname = "";

string? readResult;
var menuSelection = "";

// array used to store runtime data, there is no persisted data
var ourAnimals = new string[MaxPets, MaxCharacteristics];

var characteristicLabels = new string[]
    {
        "ID #:",
        "Species:",
        "Age:",
        "Nickname:",
        "Physical description:",
        "Personality:"
        };


// create some initial ourAnimals array entries
for (var i = 0; i < MaxPets; i++)
{
    switch (i)
    {
        case 0:

            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";

            break;
        case 1:

            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "loki";

            break;
        case 2:

            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "Puss";

            break;
        case 3:

            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "?";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";

            break;
        default:

            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";

            break;
    }

    ourAnimals[i, 0] = animalID;
    ourAnimals[i, 1] = animalSpecies;
    ourAnimals[i, 2] = animalAge;
    ourAnimals[i, 3] = animalNickname;
    ourAnimals[i, 4] = animalPhysicalDescription;
    ourAnimals[i, 5] = animalPersonalityDescription;
}

// display the top-level menu options
do
{
    Console.Clear();
    Console.Write($@"

    Welcome to the Contoso PetFriends app. Your main menu options are:

     1. List all of our current pet information
     2. Add a new animal friend to the ourAnimals array
     3. Ensure animal ages and physical descriptions are complete
     4. Ensure animal nicknames and personality descriptions are complete
     5. Edit an animal’s age
     6. Edit an animal’s personality description
     7. Display all cats with a specified characteristic
     8. Display all dogs with a specified characteristic
     
    Enter your selection number (or type Exit to exit the program)

    ");

    readResult = Console.ReadLine();
    if (readResult != null)
        menuSelection = readResult.ToLower();

    switch (menuSelection)
    {
        case "1":   //List all of our current pet information

            Console.Clear();
            Console.WriteLine("Lista de Mascotas");

            for (var i = 0; i < MaxPets; i++)
            {

                if (ourAnimals[i, 0] == "")
                    continue;

                Console.WriteLine($"Mascota Numero:{i + 1}\n");
                ourAnimals[i, 0] = ourAnimals[i, 0].ToUpper();

                for (var j = 0; j < MaxCharacteristics; j++)
                {
                    Console.WriteLine($"{characteristicLabels[j].ToUpper()} {ourAnimals[i, j]}");
                }

                Console.WriteLine("\n=========================\n");
            }

            Console.Write("Presione Enter Para continuar");
            Console.ReadKey();
            break;

        case "2"://Add a new animal friend to the ourAnimals array

            Console.Clear();

            var anotherPet = "y";
            var petCount = 0;

            for (var i = 0; i < MaxPets; i++)
                if (ourAnimals[i, 0] != "")
                    petCount++;

            while ((anotherPet == "y") && (petCount < MaxPets))
            {
                Console.Clear();

                var validEntry = false;

                animalSpecies = "";
                animalAge = "";
                animalPhysicalDescription = "";
                animalPersonalityDescription = "";
                animalNickname = "";

                do
                {
                    Console.WriteLine("\n\rEnter 'dog' or 'cat' to begin a new entry");

                    readResult = Console.ReadLine();
                    if (readResult != null)
                        animalSpecies = readResult.ToLower();

                } while ((animalSpecies != "dog") && (animalSpecies != "cat"));

                animalID = animalSpecies.Substring(0, 1) + (petCount + 1).ToString();

                do
                {
                    Console.WriteLine("Enter the pet's age or enter ? if unknown");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalAge = readResult;
                        if (animalAge != "?")
                            validEntry = int.TryParse(animalAge, out var _);
                        else
                            validEntry = true;
                    }
                } while (validEntry == false);

                do
                {
                    Console.WriteLine("Enter a physical description of the pet (size, color, gender, weight, housebroken)");
                    readResult = Console.ReadLine();

                    if (readResult != null)
                    {
                        animalPhysicalDescription = readResult.ToLower();

                        if (animalPhysicalDescription == "")
                            animalPhysicalDescription = "tbd";
                    }

                } while (animalPhysicalDescription == "");

                do
                {
                    Console.WriteLine("Enter a description of the pet's personality (likes or dislikes, tricks, energy level)");
                    readResult = Console.ReadLine();

                    if (readResult != null)
                    {
                        animalPersonalityDescription = readResult.ToLower();

                        if (animalPersonalityDescription == "")
                            animalPersonalityDescription = "tbd";

                    }
                } while (animalPersonalityDescription == "");

                do
                {
                    Console.WriteLine("Enter a nickname for the pet");
                    readResult = Console.ReadLine();

                    if (readResult != null)
                    {
                        animalNickname = readResult.ToLower();

                        if (animalNickname == "")
                            animalNickname = "tbd";
                    }
                } while (animalNickname == "");

                ourAnimals[petCount, 0] = animalID;
                ourAnimals[petCount, 1] = animalSpecies;
                ourAnimals[petCount, 2] = animalAge;
                ourAnimals[petCount, 3] = animalNickname;
                ourAnimals[petCount, 4] = animalPhysicalDescription;
                ourAnimals[petCount, 5] = animalPersonalityDescription;

                petCount++;
                if (petCount < MaxPets)
                {
                    Console.Clear();
                    Console.WriteLine($"We currently have {petCount} pets that need homes. We can manage {(MaxPets - petCount)} more.\n\nDo you want to enter info for another pet (y/n)");

                    do
                    {
                        readResult = Console.ReadLine();
                        if (readResult != null)
                            anotherPet = readResult.ToLower();

                    } while ((anotherPet != "y") && (anotherPet != "n"));
                }
            }
            if (petCount >= MaxPets)
            {
                Console.WriteLine("We have reached our limit on the number of pets that we can manage.\n\nPress the Enter key to continue.");
            }
            else
            {
                Console.WriteLine("Press the Enter key to continue.");
            }

            readResult = Console.ReadLine();
            break;

        case "3":   //Ensure animal ages and physical descriptions are complete

            for (var i = 0; i < MaxPets; i++)
            {
                if (ourAnimals[i, 0] == null || ourAnimals[i, 0] == "")
                    continue;

                Console.Clear();
                var validEntry = false;

                var physicalDescriptionLabesls = new string[]
                {
                  "petSize",
                  "petColor",
                  "petBreed",
                  "petGender",
                  "petWeight",
                  "petHousebroken"
                };

                animalID = ourAnimals[i, 0];
                animalAge = ourAnimals[i, 2];
                animalPhysicalDescription = ourAnimals[i, 4];
                animalNickname = ourAnimals[i, 5] != "" && ourAnimals != null ? ourAnimals[i, 3] : "UnNamed Animal";


                Console.WriteLine($"{animalNickname} con Id: {animalID}");

                if (animalAge == null || animalAge == "?" || animalAge == "")
                {
                    do
                    {
                        Console.Write($"Requiere una edad =>");
                        readResult = Console.ReadLine();

                        if (readResult != null)
                        {
                            validEntry = int.TryParse(readResult, out var _);
                            animalAge = readResult;
                        }
                    } while (validEntry == false || animalAge == null);

                    ourAnimals[i, 2] = animalAge ?? "?";
                }

                if (animalPhysicalDescription == null || animalPhysicalDescription == "" || animalPhysicalDescription == "tbd")
                {
                    do
                    {
                        foreach (var label in physicalDescriptionLabesls)
                        {
                            Console.Write($"\nEntry a {label} for {animalNickname} =>");
                            readResult = Console.ReadLine();

                            if (readResult != null && readResult != "")
                                animalPhysicalDescription += $"{label}: {readResult}, ";
                            else
                            {
                                animalPhysicalDescription += $"{label} not Specified, ";
                            }
                        }


                    } while (animalPhysicalDescription == "" && animalPhysicalDescription == null);

                    ourAnimals[i, 4] = animalPhysicalDescription ?? "tbd";
                }

            }

            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        
        case "4"://Ensure animal nicknames and personality descriptions are complete

            for (var i = 0; i < MaxPets; i++)
            {
                if (ourAnimals[i, 0] == "" || ourAnimals[i, 0] == null)
                    continue;

                Console.Clear();
                var petAddedNickName = "";

                var petAddedPersonality = "";
                var petAddedPersonalityDescriptionLabels = new string[]
                {
                    "Likes",
                    "Dislikes",
                    "Triks",
                    "Energy Level"
                };

                if (ourAnimals[i, 3] == null || ourAnimals[i, 3] == "" || ourAnimals[i, 3] == "tbd")
                {
                    do
                    {
                        Console.Write($"\nEntry a name for pet {ourAnimals[i, 0]} =>");
                        readResult = Console.ReadLine();

                        if (readResult != null)
                        {
                            petAddedNickName = readResult.ToLower();
                        }

                    } while (petAddedNickName == "" && petAddedNickName == "tbd");

                    ourAnimals[i, 3] = petAddedNickName;
                }

                if (ourAnimals[i, 5] == null || ourAnimals[i, 5] == "" || ourAnimals[i, 5] == "tbd")
                {
                    do
                    {
                        foreach (var label in petAddedPersonalityDescriptionLabels)
                        {
                            Console.Write($"\nEntry a {label} for {ourAnimals[i, 3]} =>");
                            readResult = Console.ReadLine();

                            if (readResult != null && readResult != "")
                            {
                                petAddedPersonality += $"{label}: {readResult}, ";
                            }
                            else
                            {
                                petAddedPersonality += $"{label}: not Specified, ";
                            }
                        }

                    } while (petAddedPersonality == "");
                    ourAnimals[i, 5] = petAddedPersonality;

                }
            }

            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        case "5":
            //Edit an animal’s age
            Console.WriteLine("this app feature is coming soon - please check back to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        case "6":
            //Edit an animal’s personality description
            Console.WriteLine("this app feature is coming soon - please check back to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        case "7":
            //Display all cats with a specified characteristic
            Console.WriteLine("this app feature is coming soon - please check back to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        case "8":
            //Display all dogs with a specified characteristic
            Console.WriteLine("this app feature is coming soon - please check back to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        case "exit":
            Console.WriteLine("Thanks for using our application!!");
            Console.WriteLine("Press the Enter key to continue.");
            break;
        default:
            //Default Option
            Console.WriteLine("this app feature is coming soon - please check back to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
    }

} while (menuSelection != "exit");
