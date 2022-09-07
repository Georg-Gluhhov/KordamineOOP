using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KordamineOOP
{
    class Koer : Koduloom
    {
        public enum toug { Mops, Foxtier };
        public toug Toug;
        public Koer(toug Toug, string nimi, string varv, sugu loomaSugu, double kaal = 0, int vanus = 0, bool elav = false) : base(nimi, varv, loomaSugu, kaal, vanus, elav)
        {
            this.Toug = Toug;   
        }
        public Koer(Koer koer)
        {
            this.Toug = koer.Toug;
            this.nimi = koer.nimi;
            this.varv = koer.varv;
            this.loomaSugu = koer.loomaSugu;
            this.kaal = koer.kaal;
            this.vanus = koer.vanus;
            this.elav = koer.elav;
        }
        public override void print_Info()
        {
            Console.WriteLine("{0}{1}{2} ta on {3} ja tema kaal on {4} ja ta on {5} aastat vana", Toug, varv, nimi, loomaSugu, kaal, vanus);
        }
        public override void print_Haal()
        {
            Console.WriteLine("");
        }
        public override List<string> Return_List()
        {

            var End = new List<string>();
            End.Add("Koer");
            End.Add("Kasvu on " + Toug.ToString());
            End.Add("varv on " + varv.ToString());
            End.Add("nimi on " + nimi.ToString());
            End.Add("sugu on " + loomaSugu.ToString());
            End.Add("kaal on " + kaal.ToString());
            End.Add("vanus on " + vanus.ToString() + "\n!");
            return (End);
        }
        public void muudaNimi(string uusNimi) { nimi = uusNimi; }   
        public void muudaVarv(string uusVarv) { varv = uusVarv; }
        public void muudaSugu(sugu uusSugu) { loomaSugu = uusSugu; }
        public void muudaKaal(double uusKaal) { kaal = uusKaal; }
        public void muudaVanus(int uusVanus) {vanus = uusVanus; }
        public void muudaElav(bool uusElav) { elav=uusElav; }

    }
}
