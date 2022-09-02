using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KordamineOOP
{
    class Hiir : Koduloom
    {
        public double kasvu;
        public Hiir(double kasvu, string nimi, string varv, sugu loomaSugu, double kaal = 0, int vanus = 0, bool elav = false) : base(nimi, varv, loomaSugu, kaal, vanus, elav)
        {
            this.kasvu=kasvu;
        }
        public Hiir(Hiir hiir)
        {
            this.kasvu = hiir.kasvu;
            this.nimi = hiir.nimi;
            this.varv = hiir.varv;
            this.loomaSugu = hiir.loomaSugu;
            this.kaal = hiir.kaal;
            this.vanus = hiir.vanus;
            this.elav = hiir.elav;
        }
        public override void print_Info()
        {

            Console.WriteLine("kasvu on {0}, {1}{2} ta on {3} ja tema kaal on {4} ja ta on {5} aastat vana", kasvu, varv, nimi, loomaSugu, kaal, vanus);
        }
        public override void print_Haal()
        {
            Console.WriteLine("");
        }       
        public override List<string> Return_List()
        {

            var End = new List<string>();
            End.Add("\n----------------------------\nHiir");
            End.Add("Kasvu on " + kasvu.ToString());
            End.Add("varv on " + varv.ToString()); 
            End.Add("nimi on " + nimi.ToString());
            End.Add("sugu on " + loomaSugu.ToString());
            End.Add("kaal on " + kaal.ToString());
            End.Add("vanus on " + vanus.ToString()+ "\n----------------------------");
            return (End);
        }

        public void muudaNimi(string uusNimi) { nimi = uusNimi; }
        public void muudaVarv(string uusVarv) { varv = uusVarv; }
        public void muudaSugu(sugu uusSugu) { loomaSugu = uusSugu; }
        public void muudaKaal(double uusKaal) { kaal = uusKaal; }
        public void muudaVanus(int uusVanus) { vanus = uusVanus; }
        public void muudaElav(bool uusElav) { elav = uusElav; }
    }
}
