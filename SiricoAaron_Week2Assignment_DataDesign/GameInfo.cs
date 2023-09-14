namespace SiricoAaron_Week2Assignment_DataDesign
{
    public class GameInfo
    {
        //Holds number of games in data
        public int NumOfGames;
        //Holds the genre common amongst the data
        public string CommonGenre;
        //Holds the first map name in the first list of maps
        public string FirstMapName;
        //Holds a list of the longest names in the data
        public string[] LongestNames;
        //Holds a dicitionary that contains the data
        public Dictionary<int, Info> InfoDictionary = new Dictionary<int, Info>();

        public GameInfo()
        {
            //DATA:
            Info Info = new Info();


            MetaData = new List<Info>();
            Info info1 = new Info();
            info1.Id = 0;
            info1.Name = "Monkey Island";
            info1.Genre = "Point & Click";
            info1.MapNames = new string[] { "Guybrush Mansion", "LeChuck Hideout", "Melee Island", "SCUMM Bar" };
            MetaData.Add(info1);

            Info info2 = new Info();
            info2.Id = 1;
            info2.Name = "Mario Odyssey";
            info2.Genre = "Adventure";
            info2.MapNames = new string[] { "Mushroom Kingdom", "Cap Kingdom", "Cloud Kingdom", "Snow Kingdom" };
            MetaData.Add(info2);

            Info info3 = new Info();
            info3.Id = 2;
            info3.Name = "Final Fantasy 10";
            info3.Genre = "Adventure";
            info3.MapNames = new string[] { "Besaid Island", "Bevelle", "Calm Lands", "Baaj Temple" };
            MetaData.Add(info3);

            Info info4 = new Info();
            info4.Id = 3;
            info4.Name = "Valkyra 4";
            info4.Genre = "Tactical RPG";
            info4.MapNames = new string[] { "Battle of Siegval", "Other Kai", "Azure Flame", "Midnight Run" };
            MetaData.Add(info4);
        }
        public List<Info> MetaData { get; set; }

        //Method that counts the number of games in the data
        public int CountGames()
        {
            foreach (Info game in MetaData)
            {
                NumOfGames++;

            }
            Console.WriteLine($"{NumOfGames}");
            return NumOfGames;
        }

        //Method generates the common genre
        public void CommonTitle()
        {
            for (int i = 2; i < MetaData.Count; i++)
            {
                if (MetaData[i].Genre == MetaData[i - 1].Genre)
                {
                    CommonGenre = MetaData[i].Genre;
                }
                else
                    break;
            }
            Console.WriteLine($"The most common genre is: {CommonGenre} ");
        }

        //Method generates the map names with the most characters
        public void MostNumCharacters()
        {
            WordCapture();
            foreach (Info info in MetaData)
            {
                for (int i = 1; i < info.MapNames.Length; i++)
                {
                    if (FirstMapName.Length < info.MapNames[i].Length )
                    {
                        FirstMapName = info.MapNames[i];
                        
                    }
                }

            }
            SameNumCharacters();

        }

        public void SameNumCharacters()
        {

            foreach (Info info in MetaData)
            {
                for (int i = 1; i < info.MapNames.Length; i++)
                {
                    FirstMapName = FirstMapName.Replace(" ", "");

                    if (FirstMapName.Length == info.MapNames[i].Length)
                    {
                        Console.WriteLine(FirstMapName);
                        LongestNames.Append(FirstMapName);
                    }
                }
            }
        }

        public void SortLongestNames()
        { 
            MostNumCharacters();
            PrintLongestName();
        }

        //Method captures first word in map names
        public string WordCapture()
        {

            foreach (Info info in MetaData)
            {
               FirstMapName = info.MapNames[0];
            }
            return FirstMapName;
        }

        public void PrintLongestName()
        {
            foreach (string Name in LongestNames)
            {
                Console.WriteLine(Name);
            }
        }

        //Method captures all data into a dictionary
        public void PrintAllInfo()
            {

                foreach (Info info in MetaData)
                {
                Dictionary<int, Info> InfoDictionary = new Dictionary<int, Info>()
                {
                { info.Id, info }
                };
                }
        }

        //Method prints the map names with z in them
        public void WordsWithZ()
        {
            foreach (Info info in MetaData) 
            {

                for (int i = 1; i < info.MapNames.Length; i++)
                {

                    if (info.MapNames[i].Contains('z'))
                    {
                        Console.WriteLine(info.MapNames[i]);
                    }
                }

            }
        }

    }
}