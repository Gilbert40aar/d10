using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d10.utils
{
    class MenuChoices
    {
        public static string[] Entries { get; set; }

        public MenuChoices()
        {
            
        }

        public MenuChoices(string[] _entry)
        {
            Entries = _entry;
        }

        /// <summary>
        /// Denne metode placere vores menupunkter indenfor vores
        /// menues design. Dette gøres dynamisk.
        /// </summary>
        public static void WriteMenu()
        {
            for (int i = 0; i < Entries.Length; i++) 
            {
                Console.SetCursorPosition(DrawMenu.X + 2, DrawMenu.Y + 2 + i);
                Console.WriteLine(Entries[i]);
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
                    Program.WriteToFile();
                    break;
                case "2":
                    Program.ReadFromFile();
                    break;
                case "3":
                    Program.SearchInFile();
                    break;
                case "4":
                    break;
                case "5":
                    Program.exit = false;
                    break;
                default:
                    break;
            }
        }
    }
}
