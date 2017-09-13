using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MartiniGlassApp
{
    class MartiniProgram
    {
        static char GlassSymbol = '0';
        static char SpaceSymbol = ' ';
        static char HandleSymbol = '|';
        static char BottomSymbol = '=';

        static void Main(string[] args)
        {
            Console.WriteLine("\nHow big would you like your Martini glass? ");
            var size = Convert.ToInt32(Console.ReadLine());

            //Set the size of the top of the glass
            var topGlassSize = (size * 2) - 1;

            //Keep track of side spacing for handle
            int sideSpacing = 0;

            for (int i = 0; i < size; i++)
            {
                var glassRow = new string(GlassSymbol, topGlassSize);

                //Add Spacing after first row
                if (i != 0)
                {
                    var spacing = new string(SpaceSymbol, i);
                    glassRow = (spacing + glassRow + spacing);
                }

                Console.WriteLine(glassRow);

                topGlassSize = topGlassSize - 2;
                sideSpacing = i;
            }

            AddMartiniGlassBottom((size * 2) - 1, size, sideSpacing);

            Console.Write("\nPress any key to exit...");
            Console.ReadKey(true);

        }

        /// <summary>
        /// Loop through and add handle and bottom of Martini Glass
        /// </summary>
        /// <param name="glassBottomSize">Size of Bottom of Martini Glass</param>
        /// <param name="holdCount">Size of Handle</param>
        /// <param name="sideSpacing">Line handle in center of glass</param>
        static void AddMartiniGlassBottom(int glassBottomSize, int holdCount, int sideSpacing)
        {
            for (int i = 0; i < holdCount; i++)
            {
                var spacing = new string(SpaceSymbol, sideSpacing);
                Console.WriteLine(spacing + new string(HandleSymbol, 1) + spacing);
            }

            Console.WriteLine(new string(BottomSymbol, glassBottomSize));

            var test = string.Empty;
        }
    }
}
