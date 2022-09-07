﻿using System;
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
            int Split = 0;
            List<String> list = new List<String>(); 
            foreach (string line in System.IO.File.ReadLines(path))
            {
                if (line != "!")
                {
                    list.Add(line);
                }
                else 
                {
                    Split+=1;
                    BigList.AddRange(list);
                    list.Clear();
                }
            }

            int g = 0;
            foreach (String s in BigList)
            {
                if (g == 6) { g = 0; }
                if (s == "Koer") { Koer koer = new Koer(Koer.toug.Mops, " ", " ", Koduloom.sugu.isane, 0, 0, true); }
                else if( s=="Hiir") { Hiir hiir = new Hiir(18, " ", " ", Koduloom.sugu.isane, 0, 0, true); }
                if (s == "Koer" || g > 0 && g !=6 ) { 
                switch (s)
                {
                        case var _ when s.Contains("Kasvu on"):
                            Console.WriteLine(s);
                            break;
                        case var _ when s.Contains("varv on"):
                            Console.WriteLine(s);
                            break;     
                        case var _ when s.Contains("nimi on"):
                            Console.WriteLine(s);
                            break;
                        case var _ when s.Contains("sugu on"):
                            Console.WriteLine(s);
                            break;
                        case var _ when s.Contains("kaal on"):
                            Console.WriteLine(s);
                            break;
                        case var _ when s.Contains("vanus on"):
                            Console.WriteLine(s);
                            break;
                }
                    g++;
                }
                else if (s == "Hiir" || g > 0 && g != 6)
                {
                    switch (s)
                    {
                        case var _ when s.Contains("Kasvu on"):
                            Console.WriteLine(s);
                            break;
                        case var _ when s.Contains("varv on"):
                            Console.WriteLine(s);
                            break;
                        case var _ when s.Contains("nimi on"):
                            Console.WriteLine(s);
                            break;
                        case var _ when s.Contains("sugu on"):
                            Console.WriteLine(s);
                            break;
                        case var _ when s.Contains("kaal on"):
                            Console.WriteLine(s);
                            break;
                        case var _ when s.Contains("vanus on"):
                            Console.WriteLine(s);
                            break;
                    }
                    g++;
                }

            }
        }
    }
}