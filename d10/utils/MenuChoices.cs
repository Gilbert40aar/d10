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
    }
}
