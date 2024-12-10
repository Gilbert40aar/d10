using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d10.utils
{
    class FileHandler
    {
        public static string? FileName { get; set; }

        public FileHandler(string? _filename)
        {
            FileName = _filename;
        }

        /// <summary>
        /// Denne metode opretter en txt fil hvis denne ikke findes
        /// i forvejen.
        /// </summary>
        public static void CreateFile()
        {
            if (!File.Exists(FileName))
            {
                File.Create(FileName);
            }
        }

        public static string WriteToFile(List<string> entries)
        {
            try
            {
                foreach(var item in entries)
                {
                    File.AppendAllText(FileName, item + Environment.NewLine);
                }
                
                return "Jubii det gik godt...";
            }
            catch (Exception err)
            {
                return err.Message;
            }
        }
    }
}
