using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KordamineOOP
{
    internal class WriteList
    {
        static string path = @"..\..\..\list.txt";
        public static void WriteToListHiir(Hiir hiir)
        {
            var list = hiir.Return_List();


            using (StreamWriter writer = new StreamWriter(path, true))
            {
                foreach (String s in list)
                    writer.WriteLine(s);
            }

        }
        public static void WriteToListKoer(Koer koer)
        {

            var list = koer.Return_List();


            using (StreamWriter writer = new StreamWriter(path, true))
            {
                foreach (String s in list)
                    writer.WriteLine(s);
            }


        }
        public static void ReadList()
        {
            var BigList = new List<String>();
            List<String> list = new List<String>(); 
            foreach (string line in System.IO.File.ReadLines(path))
            {
                if (line != "!")
                {
                    list.Add(line);
                }
                else 
                {
                    BigList.AddRange(list);
                    list.Clear();
                }
            }
            foreach(string item in BigList)
            {
                Console.WriteLine(item);    
            }

    

        }
    }
}