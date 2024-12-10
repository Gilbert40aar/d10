using d10.utils;
using  System.Security.Cryptography.X509Certificates;

namespace d10
{
    class Program
    {
        // Dette er globale variabler
        public static bool exit = true;
        public static string filename = "d10file.txt";
        public static string[] entries = {};

        static void Main(string[] args)
        {
            // Her initialiserer vi vores DrawMenu klasse
            // og tildeler de nødvendige værdier.
            DrawMenu _menu = new DrawMenu(1, 1, 80, 25, "D10 Fancy Menu");
            CreateFile();
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
                Case(choice); // Her udføres det valgte menu punkt.
            } while (exit);
            
            
        }

        /// <summary>
        /// Denne metode opretter en txt fil hvis denne ikke findes
        /// i forvejen.
        /// </summary>
        public static void CreateFile()
        {
            if (!File.Exists(filename))
            {
                File.Create(filename);
            }
        }

        /// <summary>
        /// Denne metode afvikler det valgte menupunkt.
        /// </summary>
        /// <param name="choice"></param>
        public static void Case(string? choice)
        {
            switch (choice)
            {
                case "1":
                    WriteToFile();
                    break;
                case "2":
                    ReadFromFile();
                    break;
                case "3":
                    SearchInFile();
                    break;
                case "4":
                    break;
                case "5":
                    exit = false;
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Denne metode skriver data til en fil.
        /// Dataen kommer fra brugerens input.
        /// Vi bruger File klassen som er en del af Visual Studio.
        /// </summary>
        public static void WriteToFile()
        {
            string? fullname, email, phone, entry;
            Console.Clear();
            Console.Write("Enter fullname: ");
            fullname = Console.ReadLine();
            Console.Write("Enter Email: ");
            email = Console.ReadLine();
            Console.Write("Enter Phone: ");
            phone = Console.ReadLine();

            entry = $"{phone} {fullname} {email}";
            File.AppendAllText(filename, entry + Environment.NewLine);
            //entries.Append(entry);
            //File.WriteAllLines(filename, entries);

        }

        public static void ReadFromFile()
        {
            Console.Clear();
            entries = File.ReadAllLines(filename);
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
            entries = File.ReadAllLines(filename);
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
