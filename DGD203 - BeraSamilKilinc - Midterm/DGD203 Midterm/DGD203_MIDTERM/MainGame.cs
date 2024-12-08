using System.Security.Cryptography.X509Certificates;
using PathWayer;
using Randomizer;


namespace MainGame
{
    class Program
    {
        public static string playerName;
        
        public static int levelSystem;
        public static int whilelooper;
        public static int whilelooper2;

        public static int teleportationF = 0;
        public static int numberOfTold = 0;

        static int PlayerAchiveVillager = 1;

        public static int playerN = PathList.pCurrentLocN;
        public static int playerS = PathList.pCurrentLocS;
        public static int playerW = PathList.pCurrentLocW;
        public static int playerE = PathList.pCurrentLocE;
        
        static void Main(string[] args)
        {
            
            startText();

            // // // int playerN = PathList.pCurrentLocN;
            // // // int playerS = PathList.pCurrentLocS;
            // // // int playerW = PathList.pCurrentLocW;
            // // // int playerE = PathList.pCurrentLocE;

            // // Console.WriteLine($"{playerN}, {playerS}, {playerW}, {playerE}");

            // // //startText();
            // // // playerLocMap();
            // // playerWalkSystem();

            // villagerTalking();
        } 

        static void startText()
        {
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Shhh, Are you ready to start of your Journey?");
            Console.WriteLine("For Accept To Start Your Journey, Please Write 'Yes'");
            Console.WriteLine("For Refuse To Start Your Journey, Please Write 'No'");
            Console.WriteLine("--------------------------------------------------------");
            Console.Write("Write : ");
            string readyJourney = Console.ReadLine();
            //string readyJourney = Console.ReadLine();

            if (readyJourney.ToLower() == "yes" || readyJourney.ToLower() == "y")
            {
                Console.WriteLine("Thats What We Want!!!");
                getPlayerName();
            }
            else if (readyJourney.ToLower() == "no" || readyJourney.ToLower() == "n")
            {
                Console.WriteLine("Its Okey, You Can Come Back When You Are Feel Ready!");
                Console.WriteLine("Game Restarting, Please Wait");
                startText();
            }
            else
            {
                Console.WriteLine("Sorry, Someone Thought You Will Write Only (For Accepting : Yes or basicly Y / For Refuse : No or basicly N)");
                Console.WriteLine("Game Restarting, Please Wait");
                startText();
            }
        }
        
        static void getPlayerName()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Okey then, lets start with the first step.");
            Console.WriteLine("You need t...");
            Console.WriteLine("'Thinking From Inside, Seems Confused...'");
            Console.WriteLine("Oh, You Forget To Share Your Name With Me!");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("What would you like me to call you? Could you please tell me the name you prefer me to call you?");
            Console.Write("Please Enter Your Name : ");
            playerName = Console.ReadLine().ToLower();
            playerName = char.ToUpper(playerName[0]) + playerName.Substring(1);
            Console.WriteLine("Nice, do i remember you somewhere " +playerName+ " ?");
            Console.WriteLine("--------------------------------------------");
            rememberNameTalking();
        }
        
        static void playerLocMap()
        {
            Console.WriteLine("&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");
            Console.WriteLine("       --- Player Current Location ---         ");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"                     ({playerN})                       ");
            Console.WriteLine("                    North                      ");
            Console.WriteLine($"          ({playerW}) West  -----  East ({playerE})             ");
            Console.WriteLine("                    South                      ");
            Console.WriteLine($"                     ({playerS})                          ");
            Console.WriteLine("---------------------------------------------");
            levelSystemHelper();
            Console.WriteLine("&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");
        }

        static void playerWalkSystem()
        {
            whilelooper = 1;
            string playerInput = "";
                while (whilelooper == 1) 
                {
                

                playerLocMap();
                
                Console.WriteLine("------------- Current Ways -------------");
                Console.WriteLine("------  North  West  East  South  ------");
                Console.WriteLine("----------------------------------------");
                Console.Write("Now Please Chose One Of Way To Move : ");
                playerInput = Console.ReadLine().ToLower();

                if (playerInput == "north" && playerN < PathList.mapSizeLimiter)
                {
                    playerN ++;
                    playerS --;
                    Console.WriteLine("north");
                    Console.WriteLine($"{playerN}, {playerW}, {playerS}, {playerE}");
                    
                }
                else if (playerInput == "west" && playerW < PathList.mapSizeLimiter)
                {
                    playerW ++;
                    playerE --;
                    Console.WriteLine("west");
                    Console.WriteLine($"{playerN}, {playerW}, {playerS}, {playerE}");
                    
                }
                else if (playerInput == "east" && playerE < PathList.mapSizeLimiter)
                {
                    playerE ++;
                    playerW --;
                    Console.WriteLine("east");
                    Console.WriteLine($"{playerN}, {playerW}, {playerS}, {playerE}");
                    
                }
                else if (playerInput == "south"  && playerS < PathList.mapSizeLimiter)
                {
                    playerS ++;
                    playerN --;
                    Console.WriteLine("south");
                    Console.WriteLine($"{playerN}, {playerW}, {playerS}, {playerE}");
                    
                }
                else
                {
                    Console.WriteLine ("-----------Getting Input Has -----------");
                    Console.WriteLine("-------------  Been Failed --------------");
                    Console.WriteLine("Not : Be Sure Only Typing : 'North' 'West' 'East' 'South'");
                    Console.WriteLine("Not : Map Size Is Only 4 Unit, Be Sure Walk Inside Of Map");
                }
                Console.WriteLine($"{playerW}, {playerN}");
                if (playerW == 3 && playerN == 4)
                {
                    Console.WriteLine("Achived");
                    levelSystem =2;
                    whilelooper --;
                    villagerTalking();                    
                }

                
                }
                
        }

        static void playerWalkSystem2()
        {
            whilelooper2 = 1;
            string playerInput = "";
                while (whilelooper2 == 1) 
                {
                

                playerLocMap();
                
                Console.WriteLine("------------- Current Ways -------------");
                Console.WriteLine("------  North  West  East  South  ------");
                Console.WriteLine("----------------------------------------");
                Console.Write("Now Please Chose One Of Way To Move : ");
                playerInput = Console.ReadLine().ToLower();

                if (playerInput == "north" && playerN < PathList.mapSizeLimiter)
                {
                    playerN ++;
                    playerS --;
                    Console.WriteLine("north");
                    Console.WriteLine($"N: {playerN}, W: {playerW}, S: {playerS}, E: {playerE}");
                    
                }
                else if (playerInput == "west" && playerW < PathList.mapSizeLimiter)
                {
                    playerW ++;
                    playerE --;
                    Console.WriteLine("west");
                    Console.WriteLine($"N: {playerN}, W: {playerW}, S: {playerS}, E: {playerE}");
                    
                }
                else if (playerInput == "east" && playerE < PathList.mapSizeLimiter)
                {
                    playerE ++;
                    playerW --;
                    Console.WriteLine("east");
                    Console.WriteLine($"N: {playerN}, W: {playerW}, S: {playerS}, E: {playerE}");
                    
                }
                else if (playerInput == "south"  && playerS < PathList.mapSizeLimiter)
                {
                    playerS ++;
                    playerN --;
                    Console.WriteLine("south");
                    Console.WriteLine($"N: {playerN}, W: {playerW}, S: {playerS}, E: {playerE}");
                    
                }
                else
                {
                    Console.WriteLine ("-----------Getting Input Has -----------");
                    Console.WriteLine("-------------  Been Failed --------------");
                    Console.WriteLine("Not : Be Sure Only Typing : 'North' 'West' 'East' 'South'");
                    Console.WriteLine("Not : Map Size Is Only 4 Unit, Be Sure Walk Inside Of Map");
                }

                if (playerE == 4 && playerS == 4)
                {
                    Console.WriteLine("Achived");
                    levelSystem =4;
                    whilelooper2 --;
                    achivedChest();                
                }

                
                }
                
        }

        static void villagerTalking()
        {
            string playerAccept = " ";
            Console.WriteLine("Hey, Finally! You Come.");
            Console.WriteLine("...");
            Console.WriteLine("I have been waiting you for a long time...");
            Console.WriteLine("Someone stoled my watch.");
            while (playerAccept != "yes" && playerAccept !="y")
            {
                Console.Write("Can you get my watch back? I would be very happy if you could.\nFor Accept : Yes/Y\nFor Refuse : No/N \nWrite Your Choice : ");
                playerAccept = Console.ReadLine().ToLower();

                if (playerAccept == "no" || playerAccept == "n")
                {
                    Randomizer.Randomized.villagerTextRandomizer();
                }

                else if (playerAccept != "no" || playerAccept != "n")
                {
                    Randomizer.Randomized.failTypeRandomizer();
                }
            }

            Console.WriteLine("Yes. Thank you so much.");
            Console.WriteLine("Before you go, i need to tell you, where he live.");
            Console.WriteLine(" ");
            Console.WriteLine("Some one told me, he is living in the corner of world.");
            Console.Write("What? Why are you laughing?\nType 'A' For Choose : Sorry it's just for the moment, please continue.\nType 'B' For Choose : Do you really believe the world is flat?\nPlease Answer : ");
            string playerLaughing = Console.ReadLine().ToLower();
            if (playerLaughing == "a")
            {
                Console.WriteLine("Then please let me continue. I hope you won't interrupt me again.");
                Console.WriteLine(" ");
                Console.WriteLine("The border of my world is only 4 units in each direction");
                Console.WriteLine("You should go to the corner of the world, sorry i don't know which one.");
                Console.WriteLine("Thank you.");
                playerWalkSystem2();
            }

            else if(playerLaughing == "b")
            {
                Console.WriteLine("What do you mean by my world isn't flat?");
                Console.WriteLine("Did you really thought your world rules same in my world?");
                Console.WriteLine("The border of my world is only 4 units in each direction");
                Console.WriteLine("I honestly curious about the boundaries of your world.");
                Console.WriteLine("You should go to the corner of the world, sorry i don't know which one.");
                Console.WriteLine("Have a good luck.");
                playerWalkSystem2();
            }

            else if(playerLaughing != "a" || playerLaughing != "b")
            {
                Console.WriteLine("So, if you not want to tell why you laughed, let me continue.");
                Console.WriteLine("The border of my world is only 4 units in each direction");
                Console.WriteLine("You should go to the corner of the world, sorry i don't know which one.");
                playerWalkSystem2();
            }
        }

        static void rememberNameTalking()
        {
            Console.WriteLine("Wait, i know you.");
            Console.WriteLine("Actually i don't know you but i know your name!");
            Console.WriteLine($"{playerName} Is it really you?");
            Console.WriteLine("Type 'A' For Choose : What are you talking about? I Don't know you from anywhere.");
            Console.WriteLine("Type 'B' For Choose : I'm sorry, i couldn't remember you. Can you tell more?");
            Console.WriteLine("Type 'C' For Choose : Heyy, is that really you? How do i supposed to forget you?");
            Console.Write("Please Choose : ");
            string playerRememberChoice = Console.ReadLine().ToLower();
            if (playerRememberChoice == "a")
            {
                Console.WriteLine($"How can you forget me {playerName}?");
                Console.WriteLine("I know it is just a joke.");
                Console.WriteLine("Okey let me give you a secret.");
                Console.WriteLine("There is villager in this world. You should go next to him.");
                Console.WriteLine("Let me tell you how you can go.");
                levelSystem = 1;
                playerWalkSystem();
            }

            else if (playerRememberChoice == "b")
            {
                Console.WriteLine($"{playerName}, did you really forget me?");
                Console.WriteLine("There is no way you forget me.");
                Console.WriteLine("Okey let me give you a secret.");
                Console.WriteLine("There is villager in this world. You should go next to him.");
                Console.WriteLine("I will help you how to go.");
                levelSystem = 1;
                playerWalkSystem();
            }

            else if (playerRememberChoice == "c")
            {
                Console.WriteLine("I knew you would remember me.");
                Console.WriteLine("But, you definitely go to the next of villager.");
                Console.WriteLine("I will tell where does he living.");
                levelSystem = 1;
                playerWalkSystem();
                
            }

            else if (playerRememberChoice != "a" || playerRememberChoice != "b" || playerRememberChoice != "c" )
            {
                Console.WriteLine("Look!");
                Console.WriteLine("Even you must be surprised.");
                Console.WriteLine($"{playerName}, you should go next to villager.");
                Console.WriteLine("I will tell you where the villager living.");
                levelSystem = 1;
                playerWalkSystem();
            }

        }

        static void levelSystemHelper()
        {
            if (levelSystem == 1)
            {
                Console.WriteLine($"{playerName}, You Should Go -[North : 4 / West : 3]- Have Fun.");
            }

            else if (levelSystem == 2)
            {
                Console.WriteLine($"{playerName}, You Should Go -[South : 4 / East : 4]- Be Careful!");
            }
        }

        static void achivedChest()
        {
            Console.WriteLine("After a long time, you found the chest.");
            Console.WriteLine("They told there should be someone here, but you didn't see anyone.");
            Console.WriteLine("You Come Closer To The chest.");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("////////////////////////////////////////////");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("------------------[][][][]------------------");
            Console.WriteLine("-----------------[]------[]-----------------");
            Console.WriteLine("-----------------[]------[]-----------------");
            Console.WriteLine("------------------[][][][]------------------");
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("And you want to open to chest.");
            Console.Write("Write 'Open' for open the chest : ");
            string openCheststr = Console.ReadLine().ToLower();

            if (openCheststr == "open")
            {
                Console.WriteLine("             ////////////////////////////////////////////)");
                Console.WriteLine("        ////////////////////////////////////////////)");
                Console.WriteLine("     ////////////////////////////////////////////)");
                Console.WriteLine("////////////////////////////////////////////");
                Console.WriteLine("----          ________________          ----");
                Console.WriteLine("----          [______________]          ----");
                Console.WriteLine("----                                    ----");
                Console.WriteLine("////////////////////////////////////////////");
                Console.WriteLine("------------------[][][][]------------------");
                Console.WriteLine("-----------------[]------[]-----------------");
                Console.WriteLine("-----------------[]------[]-----------------");
                Console.WriteLine("------------------[][][][]------------------");
                Console.WriteLine("--------------------------------------------");

                Console.WriteLine("1.Finally, you choosed to open chest. Now you can get the item from the chest.");
                Console.WriteLine("2.You reached to item.");
                Console.WriteLine("3.When you touched.");
                Console.WriteLine("4.Something happened!!");
                Console.WriteLine("5.You suddenly felt a hardening at the tip of your finger that you touched.");
                Console.WriteLine("6.That feeling neither hurt nor burned.");
                Console.WriteLine("7.The item was just attracting itself.");
                Console.WriteLine("8.While the object was drawing you towards it, you also felt like time was slowing down.");
                Console.WriteLine("9.Time is slowing down more and more.");
                Console.WriteLine("10.Not even 1 second has passed in the world.");
                Console.WriteLine("11.While people haven't even blinked.");
                Console.WriteLine("12.You had become the object in the chest.");
                Console.WriteLine("13.But you could still think.");
                Console.WriteLine("14.After long thought...");
                Console.WriteLine("15.You finally realized how deceived you had been.");
                Console.WriteLine("16.You spent the infinite potential of your brain to keep their world running.");
                Console.WriteLine("17.They would continue to sustain their world with the energy coming from your brain, created by your thoughts.");
                Console.WriteLine("18.Were you the only one in the chest?");
                Console.WriteLine("19.The End.\nThanks For Playing.");


            }

            else if (openCheststr != "open" && teleportationF == 0)
            {
                Console.WriteLine("--------------------------------------------------------------------------------");            
              Console.WriteLine("Can't you just type open?");
              Console.WriteLine("Do you really need to look for that much detail?");
              Console.WriteLine("Don't you know I can teleport you anywhere on the map?");
              Console.WriteLine("I will give you a last chance. Just type Only OPEN !");
              teleportationF ++;

              achivedChest();

            }

            else if (openCheststr != "open" && teleportationF >= 1)
            {
                numberOfTold ++;
                Console.WriteLine("---------------------------------------------------------------------------------------");
                Console.WriteLine("Huh.");
                Console.WriteLine("People says, you can't wiser.");
                Console.WriteLine("This is not place for you can listen me all day.");
                Console.WriteLine("Actually, it is.");
                Console.WriteLine($"Let me tell, But This is the {numberOfTold} time you have been here, so you know Will you keep continue?");
                Console.WriteLine("---------------------------------------------------------------------------------------");
                Randomized.quoteRandomizer();
                Console.WriteLine("---------------------------------------------------------------------------------------");

                Console.WriteLine("Have fun when you are walking.");
                playerE = -4;
                playerS = -4;
                playerW = 4;
                playerN = 4;
                playerWalkSystem2();
            }
            
        }

        
    }    
}
