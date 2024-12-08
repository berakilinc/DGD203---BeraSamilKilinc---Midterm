    namespace PathWayer
    {
      public static class PathList
      {
        //Mixed Map Limitation For Make Life Easier, (Can Usaible When Locatins Had Same Maximum Map Limitations)
        public static int mapSizeLimiter = 4;

        //Map Limitation Of Ways, North South West East
        public static int mapMaxNSize = 4;
        public static int mapMaxSSize = 4;
        public static int mapMaxWSize = 4;
        public static int mapMaxESize = 4;

        //Player Current Location, North South West East
        public static int pCurrentLocN = 0;
        public static int pCurrentLocS = 0;
        public static int pCurrentLocW = 0;
        public static int pCurrentLocE = 0;

                                // public static float playerLocation = 0.000f;

                                // public static string playerLocationStr = playerLocation.ToString("0.000");

                                // public static void pLocateN()
                                // {
                                //     char playerLocationN = playerLocationStr[0];
                                // }
                                // public static void pLocateS()
                                // {
                                //     char playerLocationS = playerLocationStr[2];
                                // }
                                // public static void pLocateW()
                                // {
                                //     char playerLocationW = playerLocationStr[3];
                                // }
                                // public static void pLocateE()
                                // {
                                //     char playerLocationE = playerLocationStr[4];
                                // }
        
        
        
        // Path Information For Which Players Writed Help
        public static void WayHelp()
        {
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("                                               ");
            Console.WriteLine("           Here Ways You Can Choose            ");
            Console.WriteLine("                                               ");
            Console.WriteLine("                    North                      ");
            Console.WriteLine("              West  -----  East                ");
            Console.WriteLine("                    South                      ");
            Console.WriteLine("                                               ");
            Console.WriteLine("-----------------------------------------------");
        }
        // Path Information For Which Players Writed Help



        // All Paths Player Available To Choose _Start ---------------------------
        public static void PathNorth()
        {
            Console.WriteLine("Player Choosed To Continue Way Of 'North'");
        }
        public static void PathWest()
        {
            Console.WriteLine("Player Choosed To Continue Way Of 'West'.");
        }
        public static void PathEast()
        {
            Console.WriteLine("Player Choosed To Continue Way Of 'East'.");
        }
        public static void PathSouth()
        {
            Console.WriteLine("Player Choosed To Continue Way Of 'South'.");
        }
        // All Paths Player Available To Choose _End -----------------------------
      }
    }

    