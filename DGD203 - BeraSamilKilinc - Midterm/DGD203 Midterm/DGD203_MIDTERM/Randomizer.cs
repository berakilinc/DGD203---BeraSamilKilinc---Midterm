using System;

namespace Randomizer
{
    public static class Randomized
    {
        public static void villagerTextRandomizer()
        {
            Random villagerRefuse = new Random();
            int aVilRefuse = villagerRefuse.Next(1,3);

            if (aVilRefuse == 1)
            {
                Console.WriteLine("Is it really that easy to say no?");
                Console.WriteLine("You will refuse that easy, and able to continue your way with forgetting everything?");
                Console.WriteLine("I will try again, i hope you will help me this time...");
            }

            else if (aVilRefuse == 2)
            {
                Console.WriteLine("Ok, I know you don't need to help me.");
                Console.WriteLine("But, what you lost if you try to help?");
                Console.WriteLine("You maybe just sayed no, without even think, but, what you thinking am i? Just nothing? Just line of some code?");
                Console.WriteLine("You know, if i do not here, and not want any help, how do you thinking you can continue your fun? Are you really thinking you have choice anything but saying yes?");
                Console.WriteLine("I hope you got the main point. And let me ask you once more.");
            }
        }

        public static void failTypeRandomizer()
        {
            Random failTypeRandom = new Random();
            int afailTypeRandom = failTypeRandom.Next(1,4); 

            if (afailTypeRandom == 1)
            {
                Console.WriteLine("Sorry, i didn't knew you are not from this world.");
                Console.WriteLine("But, i think you can understand me, if i say once more...");
            }

            else if (afailTypeRandom == 2)
            {
                Console.WriteLine("WgszHAvsT YgvOskU MvdEAbzN?");
                Console.WriteLine("Let me ask again, What you mean?");
            }

            else if (afailTypeRandom == 3)
            {
                Console.WriteLine("Sorry, i can't speak chinese.");
                Console.WriteLine("But if you accept to take back my item, for me, why do i not learn?");
                Console.WriteLine("Its a good deal, isn't it?");
                Console.WriteLine("Then, let me repeat once more.");
            }
        }
        public static void quoteRandomizer()
        {
            Random quoteRandomizer = new Random();
            int quoteRandom = quoteRandomizer.Next(1,9);

            if (quoteRandom == 1)
            {
                Console.WriteLine("I don't care that they stole my idea . . I care that they don't have any of their own");
            }

            else if (quoteRandom == 2)
            {
                Console.WriteLine("The present is theirs; the future, for which I really worked, is mine.");
            }

            else if (quoteRandom == 3)
            {
                Console.WriteLine("If your hate could be turned into electricity, it would light up the whole world.");
            }

            else if (quoteRandom == 4)
            {
                Console.WriteLine("Imagination is the Discovering Faculty, pre-eminently.");
            }

            else if (quoteRandom == 5)
            {
                Console.WriteLine("A person who never made a mistake never tried anything new.");
            }

            else if (quoteRandom == 6)
            {
                Console.WriteLine("Learn from yesterday, live for today, hope for tomorrow.");
            }

            else if (quoteRandom == 7)
            {
                Console.WriteLine("The important thing is not to stop questioning. Curiosity has its own reason for existing.");
            }

            else if (quoteRandom == 8)
            {
                Console.WriteLine("Let the future tell the truth, and evaluate each one according to his work and accomplishments. The present is theirs; the future, for which I have really worked, is mine");
            }
        }
    }
}