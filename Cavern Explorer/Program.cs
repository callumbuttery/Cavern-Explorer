using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cavern_Explorer
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileinfo = File.ReadAllText(@"J:\Uni\Year 3\AI\Coursework\generated30-1.cav");

            Console.WriteLine(fileinfo);
        }
    }
}
