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
            Koer koer = new Koer(Koer.toug.Mops, " ", " ", Koduloom.sugu.isane, 0, 0, true);
            Hiir hiir = new Hiir(18, " ", " ", Koduloom.sugu.isane, 0, 0, true);

           int g = 0;
            foreach (String s in BigList)
            {
                if (g == 6) { g = 0; }
                if (s == "Koer" || g > 0 && g !=6 ) { 
                switch (s)
                {    
                        case var _ when s.Contains("Kasvu on"):
                            koer.muudaVarv(s.Replace(" Kasvu on ", ""));
                            break;
                        case var _ when s.Contains("varv on"):
                            koer.muudaVarv(s.Replace(" varv on ", ""));
                            break;     
                        case var _ when s.Contains("nimi on"):
                            koer.muudaNimi(s.Replace(" nimi on ", ""));
                            break;
                        case var _ when s.Contains("sugu on"):
                            koer.muudaNimi(s.Replace(" sugu on ", ""));
                            break;
                        case var _ when s.Contains("kaal on"):
                            koer.muudaNimi(s.Replace(" kaal on ", ""));
                            break;
                        case var _ when s.Contains("vanus on"):
                            koer.muudaNimi(s.Replace(" vanus on ", ""));
                            break;
                }
                    g++;
                    koer.print_Info();
                }
                else if (s == "Hiir" || g > 0 && g != 6)
                {
                    switch (s)
                    {
                        case var _ when s.Contains("Kasvu on"):
                            koer.muudaVarv(s.Replace(" Kasvu on ", ""));
                            break;
                        case var _ when s.Contains("varv on"):
                            koer.muudaVarv(s.Replace(" varv on ", ""));
                            break;
                        case var _ when s.Contains("nimi on"):
                            koer.muudaNimi(s.Replace(" nimi on ", ""));
                            break;
                        case var _ when s.Contains("sugu on"):
                            koer.muudaNimi(s.Replace(" sugu on ", ""));
                            break;
                        case var _ when s.Contains("kaal on"):
                            koer.muudaNimi(s.Replace(" kaal on ", ""));
                            break;
                        case var _ when s.Contains("vanus on"):
                            koer.muudaNimi(s.Replace(" vanus on ", ""));
                            break;
                    }
                    g++;
                    hiir.print_Info();
                }

            }
        }
    }
}