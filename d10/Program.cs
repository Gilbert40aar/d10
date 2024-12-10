using d10.utils;

namespace d10
{
    class Program
    {
        // Dette er globale variabler
        public static bool exit = true;
        public static string filename = "d10file.txt";
        public static List<string> entries = new List<string>();

        static void Main(string[] args)
        {
            // Her initialiserer vi vores DrawMenu klasse
            // og tildeler de nødvendige værdier.
            DrawMenu _menu = new DrawMenu(1, 1, 80, 25, "D10 Fancy Menu");
            FileHandler fileHandler = new FileHandler(filename);
            FileHandler.CreateFile();
            string[] menu = {
                    "1. Write to file",
                    "2. Read from file",
                    "3. Search in file",
                    "4. Delete from file",
                    "5. Exit"
                };
            // Her intitialserer vi vores menu punkter.
            // Vi sender vores array med menuvalg med over.
            MenuChoices _choices = new MenuChoices(menu);
            do
            {
                Console.Clear();
                DrawMenu.MakeMenu(); //Her tegnes menuen
                string? choice;
                MenuChoices.WriteMenu(); // Her udskrives menupunkter
                Console.WriteLine();
                Console.CursorLeft = 3;
                Console.Write("Select your choice: ");
                choice = Console.ReadLine();
                MenuChoices.Case(choice); // Her udføres det valgte menu punkt.
            } while (exit);
            Console.WriteLine(FileHandler.WriteToFile(entries));
            Thread.Sleep(3000);
            
            
        }
                
        /// <summary>
        /// Denne metode skriver data til en fil.
        /// Dataen kommer fra brugerens input.
        /// Vi bruger File klassen som er en del af Visual Studio.
        /// </summary>
        public static void ReadFromFile()
        {
            Console.Clear();
            entries = File.ReadAllLines(filename).ToList();
            foreach (var item in entries)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        public static void SearchInFile()
        {
            Console.Clear();
            Console.Write("Search for: ");
            string? search = Console.ReadLine();
            entries = File.ReadAllLines(filename).ToList();
            foreach (var line in entries)
            {
                if(line.Substring(0,8) == search)
                {
                    Console.WriteLine(line);
                }
            }
            Console.ReadKey();
        }

    }
}
