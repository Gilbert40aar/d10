using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d10.utils
{
    class DrawMenu
    {
        // Dette er properties, da de ligger udenfor en metode.
        public static int X { get; set; }
        public static int Y { get; set; }
        public static int Width { get; set; }
        public static int Height { get; set; }
        public static string? Title { get; set; }

        public DrawMenu()
        {
            
        }

        /// <summary>
        /// Denne Constructor tildeler værdier til vores 
        /// properties som kan bruges i resten af programmet.
        /// Værdierne skrives i Program.cs når vi kalder denne
        /// klasse.
        /// </summary>
        /// <param name="_x"></param>
        /// <param name="_y"></param>
        /// <param name="_width"></param>
        /// <param name="_height"></param>
        /// <param name="_title"></param>
        public DrawMenu(int _x, int _y, int _width, int _height, string _title)
        {
            X = _x;
            Y = _y;
            Width = _width;
            Height = _height;
            Title = _title;
        }

        /// <summary>
        /// Denne metode indeholder de resterende metoder som
        /// færdiggører vores design af menuen.
        /// </summary>
        public static void MakeMenu()
        {
            SetCorners();
            DrawVerticalLine();
            DrawHorizontalLine();
            SetTitle();
        }

        /// <summary>
        /// Denne metode placere hjørnerne til vores menu.
        /// Alt udregnes automatisk, ud fra de værdier som er 
        /// blevet tildelt da klassen blev kaldt.
        /// </summary>
        public static void SetCorners()
        {
            string? topLefCorner = "╔", topRightCorner = "╗", bottomLeftCorner = "╚", bottomRightCorner = "╝";

            Console.SetCursorPosition(X, Y);
            Console.WriteLine(topLefCorner);
            Console.SetCursorPosition(Width - X, Y);
            Console.WriteLine(topRightCorner);
            Console.SetCursorPosition(X, Height - Y);
            Console.WriteLine(bottomLeftCorner);
            Console.SetCursorPosition(Width - X, Height - Y);
            Console.WriteLine(bottomRightCorner);
        }

        /// <summary>
        /// Denne metode og DrawHorizontalLine metoden identiske.
        /// Den eneste lille forskel der er, er om det er
        /// X eller Y værdien der skal uderegnes på.
        /// </summary>
        public static void DrawVerticalLine()
        {
            string? verticalLine = "║";

            for(int i = Y; i < Height - 2; i++)
            {
                Console.SetCursorPosition(X, Y + i);
                Console.WriteLine(verticalLine);
                Console.SetCursorPosition(Width - X, Y + i);
                Console.WriteLine(verticalLine);
            }
        }

        public static void DrawHorizontalLine()
        {
            string? horizontalLine = "═";

            for(int i = X; i < Width - 2; i++)
            {
                Console.SetCursorPosition(X + i, Y);
                Console.WriteLine(horizontalLine);
                Console.SetCursorPosition(X + i, Height - Y);
                Console.WriteLine(horizontalLine);
            }
        }

        /// <summary>
        /// Denne metode udregner Titlens position udfra
        /// titlens længde, og menuens bredde.
        /// </summary>
        public static void SetTitle()
        {
            int length = Title.Length;
            Console.SetCursorPosition((Width - length) / 2, Y + 1);
            Console.WriteLine(Title);
        }
    }
}
