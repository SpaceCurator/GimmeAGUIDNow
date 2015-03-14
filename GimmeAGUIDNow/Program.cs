using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GimmeAGUIDNow
{

    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Press Enter for a new GUID");

            Console.WriteLine();

            ConsoleKeyInfo Info;

            do
            {

                Console.WriteLine(Guid.NewGuid());

                Info = Console.ReadKey();

            }
            while(Info.Key == ConsoleKey.Enter);

        }

    }

}
