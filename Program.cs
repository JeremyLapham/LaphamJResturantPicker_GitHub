//Jeremy Lapham
//10-18-22
//Resturant Picker
//This will ask the user what type of resturant they want and then the computer will generate a random number to choose a resturant
//


Console.Clear();
bool keepPlaying = true;
int justForNumber = 0;

while(keepPlaying == true)
{
Console.WriteLine("");
Console.WriteLine("Do you not know where you want to eat at? Well perfect I have the thing just for you");
Console.WriteLine("");
Console.WriteLine("Choose between 'Fast Food' 'Sit Down Resturant' Or 'Buffet Style Resturant'");
string resturantType = Console.ReadLine().ToLower();
bool ifNumber1 = Int32.TryParse(resturantType, out justForNumber);
if(ifNumber1 == true)
{
    Console.WriteLine("");
    Console.WriteLine("Next time pick actual words!");
}
if(resturantType == "fast food")
{
    Console.WriteLine("");
    Console.WriteLine("You picked Fast Food as your type.");
    Console.WriteLine("");
    Console.WriteLine("Now do you want 'Burgers' or 'Hot Dogs'");
    Console.WriteLine("");
    string fastFoodType = Console.ReadLine().ToLower();
    bool fastFoodNumber = Int32.TryParse(fastFoodType, out justForNumber);
    if(fastFoodNumber == true)
    {
        Console.WriteLine("");
        Console.WriteLine("Please next time select an option not a number");
        Console.WriteLine("");
    }
    if(fastFoodType == "burgers")
    {
        Random rndNum = new Random();
        int rndNum2 = rndNum.Next(1,5);
        switch (rndNum2)
        {
            case 1: Console.WriteLine("Go to Wendy's"); break;
            case 2: Console.WriteLine("Go to Burger King"); break;
            case 3: Console.WriteLine("Go to McDonalds"); break;
            case 4:  Console.WriteLine("Go to Jack In A Box");  break;
            case 5: Console.WriteLine("Go to Five Guys"); break;
        }
    }
    else if(fastFoodType == "hot dogs")
    {
        Random rndNum = new Random();
        int rndNum2 = rndNum.Next(1,5);
        switch(rndNum2)
        {
            case 1: Console.WriteLine("Go to Dawg E's Hot Dogs"); break;
            case 2: Console.WriteLine("Go to Ssong's Hotdog"); break;
            case 3: Console.WriteLine("Go to Hob Nob Hot Dogs"); break;
            case 4: Console.WriteLine("Go to Dad's Hot Dogs"); break;
            case 5: Console.WriteLine("Go to Wienerschnitzel"); break;
        }
    }
    else
    {
        Console.WriteLine("");
        Console.WriteLine("Either you had a typo or you just didn't select an option.");
    }
}
else if(resturantType == "sit down resturant")
{
    Console.WriteLine("You picked Sit Down Resturant");
    Console.WriteLine("");
    Console.WriteLine("Do you want 'Fancy Resturant' or 'Normal Resturant'");
    Console.WriteLine("");
    string sitDownType = Console.ReadLine().ToLower();
    bool sitDownNumber = Int32.TryParse(sitDownType, out justForNumber);
    if(sitDownNumber == true)
    {
        Console.WriteLine("");
        Console.WriteLine("Next time enter actual words and not numbers");
        Console.WriteLine("");
    }
    if(sitDownType == "fancy resturant")
    {
        Random rndNum = new Random();
        int rndNum2 = rndNum.Next(1,5);
        switch (rndNum2)
        {
        case 1: Console.WriteLine("Go to Mastro's Steakhouse"); break;
        case 2: Console.WriteLine("Go to Ruth's Chris Steak House"); break;
        case 3: Console.WriteLine("Go to Le Papillon"); break;
        case 4: Console.WriteLine("Go to Providence"); break;
        case 5: Console.WriteLine("Go to Canlis"); break; 
        }
    }
    else if(sitDownType == "normal resturant")
    {
        Random rndNum = new Random();
        int rndNum2 = rndNum.Next(1,5);
        switch (rndNum2)
        {
        case 1: Console.WriteLine("Go to Denny's"); break;
        case 2: Console.WriteLine("Go to Olive Garden"); break;
        case 3: Console.WriteLine("Go to Apple Bees"); break;
        case 4: Console.WriteLine("Go to Chili's"); break;
        case 5: Console.WriteLine("Go to BJ's"); break; 
        }
    }
    else
    {
        Console.WriteLine("");
        Console.WriteLine("Either you had a typo or you just didn't select an option.");
    }

}
else if(resturantType == "buffet style resturant")
{
    Console.WriteLine("You picked a Buffet Style Resturant");
    Console.WriteLine("");
    Console.WriteLine("Now do you want to eat at an 'Asain Style' buffet or 'Regular Style' buffet");
    Console.WriteLine("");
    string buffetType = Console.ReadLine().ToLower();
    bool buffetNumber = Int32.TryParse(buffetType, out justForNumber);
    if(buffetNumber == true)
    {
        Console.WriteLine("");
        Console.WriteLine("Next time enter actual words and not numbers");
        Console.WriteLine("");
    }
    if(buffetType == "asain style")
    {
        Random rndNum = new Random();
        int rndNum2 = rndNum.Next(1,5);
        switch (rndNum2)
        {
        case 1: Console.WriteLine("Go to Sherman's 2 Chinese Buffet"); break;
        case 2: Console.WriteLine("Go to Sushi House Buffet Chinese & Japanese Grill"); break;
        case 3: Console.WriteLine("Go to Wild Chinese Buffet"); break;
        case 4: Console.WriteLine("Go to Four Seasons Buffet"); break;
        case 5: Console.WriteLine("Go to Korean BBQ"); break; 
        }
    }
    else if(buffetType == "regular style")
    {
        Random rndNum = new Random();
        int rndNum2 = rndNum.Next(1,5);
        switch (rndNum2)
        {
        case 1: Console.WriteLine("Go to Hometown Buffet"); break;
        case 2: Console.WriteLine("Go to Golden Corral Buffet & Grill"); break;
        case 3: Console.WriteLine("Go to Milpitas Buffet"); break;
        case 4: Console.WriteLine("Go to Kinder's"); break;
        case 5: Console.WriteLine("Go to Hometown BBQ & Seafood"); break; 
        }
    }
    else
    {
        Console.WriteLine("");
        Console.WriteLine("Either you had a typo or you just didn't select an option.");
    }

}
else
{
    Console.WriteLine("");
    Console.WriteLine("Either you had a typo or you just didn't select an option.");
}
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("Type 'Yes' to play again. Type 'End' to stop playing");
string stopGame = Console.ReadLine().ToLower();
if(stopGame == "end")
{
    keepPlaying=false;
}
}