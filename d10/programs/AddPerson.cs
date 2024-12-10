using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d10.programs
{
    class AddPerson
    {
        public static bool isActive { get; set; }

        public AddPerson()
        {
            isActive = true;
            do
            {
                string? fullname, email, phone, entry, choice;
                Console.Clear();
                Console.Write("Enter fullname: ");
                fullname = Console.ReadLine();
                Console.Write("Enter Email: ");
                email = Console.ReadLine();
                Console.Write("Enter Phone: ");
                phone = Console.ReadLine();

                entry = $"{phone} {fullname} {email}";

                Program.entries.Add(entry);
                Console.Write("Do you want to create another person (Y)es or (N)o: ");
                choice = Console.ReadLine();
                if(choice != "Y")
                {
                    isActive = false;
                }
            } while (isActive);
        }
    }
}
