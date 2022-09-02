using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KordamineOOP
{
    internal class WriteList
    {
        public static void WriteToListHiir(Hiir hiir)
        {

            var list = new List<string>();
            list = hiir.Return_List();
            string path = @"C:\Users\opilane\source\repos\Georgi Gluhhov TARpv20\KordamineOOP\list.txt";



            using (StreamWriter writer = new StreamWriter(path, true))
            {
                foreach (String s in list)
                    writer.WriteLine(s);
            }

        }
        public static void WriteToListKoer(Koer koer)
        {

            var list = new List<string>();
            list = koer.Return_List();
            string path = @"C:\Users\opilane\source\repos\Georgi Gluhhov TARpv20\KordamineOOP\list.txt";



            using (StreamWriter writer = new StreamWriter(path, true))
            {
                foreach (String s in list)
                    writer.WriteLine(s);
            }

        }
    }
}
