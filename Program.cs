// LISTA
//Console.WriteLine("Lista:");
// Skapa en tom lista med strängar
//List<string> fruits = new()
//{
//    "Äpple",
//    "Päron",
//    "Kiwi",
//    "Vattenmelon"
//};

// Lägg till några frukter till listan med .Add()
//fruits.Add("Äpple");
//fruits.Add("Päron");
//fruits.Add("Kiwi");
//fruits.Add("Vattenmelon");

// Loopa över listan och printa varje frukt
//foreach (string fruit in fruits)
//{
//    Console.WriteLine(fruit);
//}

// Printa andra elementet specifikt!
//Console.WriteLine(fruits[1]);

//Console.WriteLine();

// ARRAY

//Console.WriteLine("Array:");

//string[] animals = new string[5] { "Katt", "Hund", "Elefant", "Myra", "Myrslok" };

//animals[0] = "Katt";
//animals[1] = "Hund";
//animals[2] = "Elefant";
//animals[3] = "Myra";
//animals[4] = "Myrslok";

//foreach (string animal in animals)
//{
//    Console.WriteLine(animal);
//}



//Övning 1

//List<string> games = new()
//{
//    "Assassins creed",
//    "God of War",
//    "Spider-Man",
//    "Baldurs Gate 3",
//    "Slay the Spire",
//    "Counter-strike",
//    "Path of exile",
//    "Overwatch",
//    "Need for Speed",
//    "Trackmania"


//};

//foreach (string game in games)
//{
//    Console.WriteLine(game);
//}

//Övning 2

//List<string> starWars = new()
//{
//    "Luke Skywalker",
//    "Yoda",
//    "Chewbacca"
//};

//Console.WriteLine(starWars[1]);

// Övning 3

//List<string> starWars = new()
//{
//    "Luke Skywalker",
//    "Yoda",
//    "Chewbacca"
//};

//starWars.Remove(starWars[0]);

//foreach (string stars in starWars)
//{
//    Console.WriteLine(stars);
//}

// Övning 4

//List<string> starWars = new()
//{
//    "Luke Skywalker",
//    "Yoda",
//    "Chewbacca"
//};

//starWars.RemoveAt(2);

//foreach (string stars in starWars)
//{
//    Console.WriteLine(stars);
//}

// Övning 5

//List<string> starWars = new()
//{
//    "Luke Skywalker",
//    "Yoda",
//    "Chewbacca"
//};

//foreach (string stars in starWars)
//{
//    Console.WriteLine(stars);
//}


// Övning 6

//Console.WriteLine("Array:");

//string[] videoGames = new string[10]
//{
//    "God of War",
//    "Assassins Creed",
//    "Slay the Spire",
//    "Trackmania",
//    "Counter-Strike",
//    "Skyrim",
//    "Baldurs Gate 3",
//    "The Sims 4",
//    "Omega Strikers",
//    "Rocket League"
//};

//foreach (string videoGame in videoGames)
//{
//    Console.WriteLine(videoGame);
//}


//Övning 7

//int[] myNum = { 12, 34, 56, 67, 97 };

//Console.WriteLine(myNum[3]);


// Övning 8

//int[] myNum = { 3, 6, 9, 10, 15, 18, 21, 24, 27, 30 };

//foreach (int i in myNum)
//{
//    if (i < 10)
//    {
//        Console.WriteLine(i);
//        Console.WriteLine("^ This value is below 10");
//    }
//    else if (i > 10)
//    {
//        Console.WriteLine(i);
//        Console.WriteLine("^ This value is above 10");
//    }
//    else if (i == 10)
//    {
//        Console.WriteLine(i);
//        Console.WriteLine("^ This value is exactly 10");
//    }

//}

// Övning 9

//bool[] myBools = new bool[10];

//myBools[0] = false;
//myBools[1] = false;
//myBools[2] = false;
//myBools[3] = false;
//myBools[4] = false;
//myBools[5] = true;
//myBools[6] = true;
//myBools[7] = true;
//myBools[8] = true;
//myBools[9] = true;

//foreach (bool bools in myBools)
//{
//    if (bools == true)
//    {
//        Console.WriteLine(bools);
//        Console.WriteLine("^ This value is true");
//    }
//    else if (bools == false)
//    {
//        Console.WriteLine(bools);
//        Console.WriteLine("^ This value is false");
//    }

//}


// Övning 10

//int[] myNum = new int[10];

//Console.WriteLine("Skriv tio heltal!");


//for (int i = 0; i < myNum.Length; i++)
//{
//    Console.Write($"Nummer {i + 1}:");

//    myNum[i] = Convert.ToInt32(Console.ReadLine());

//}

// Övning 11


int[] myNum = new int[10];

//Console.WriteLine("Skriv tio heltal!");

//for (int i = 0; i < myNum.Length; i++)
//{
//    Console.Write($"Nummer {i + 1}:");

//    myNum[i] = Convert.ToInt32(Console.ReadLine());

//    if (myNum[i] == 0)
//    {
//        i--;
//        Console.WriteLine("Du kan inte skriva in 0, försök igen!");
//    }

//}

//int i = 0;

//while (i < myNum.Length)
//{
//    Console.Write($"Nummer {i + 1}:");

//    myNum[i] = Convert.ToInt32(Console.ReadLine());

//    if (myNum[i] == 0)
//    {
//        Console.WriteLine("Du kan inte skriva in 0, försök igen!");
//    }
//    else
//    {
//        i++;
//    }


//}












