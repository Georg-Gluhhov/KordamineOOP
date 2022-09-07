using KordamineOOP;
using static KordamineOOP.WriteList;

Koer koer = new Koer(Koer.toug.Mops, " Kiot", " punane ", Koduloom.sugu.isane, 35.5, 7, true);
koer.print_Info();




Koer veelkoer = new Koer(koer);
veelkoer.muudaNimi("Murka");
veelkoer.muudaVarv("kollane");
veelkoer.muudaSugu(Koduloom.sugu.isane);
veelkoer.muudaKaal(31.1);
veelkoer.muudaVanus(3);
veelkoer.muudaElav(true);
veelkoer.print_Info();




Hiir hiir = new Hiir(18, " Kiot", " punane ", Koduloom.sugu.isane, 35.5, 7, true);
hiir.print_Info();


WriteToListHiir(hiir);
WriteToListKoer(koer);
WriteToListKoer(veelkoer);
ReadList();

