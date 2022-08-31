using KordamineOOP;


Koer koer = new Koer(Koer.toug.Mops, " Kiot", " punane ", Koduloom.sugu.isane, 35.5, 7, true);
koer.print_Info();
koer.print_Haal();
Koer veelkoer = new Koer(koer);
veelkoer.muudaNimi("Murka");
veelkoer.muudaVarv("kollane");
veelkoer.muudaSugu(Koduloom.sugu.isane);
veelkoer.muudaKaal(31.1);
veelkoer.muudaVanus(3);
veelkoer.muudaElav(true);
veelkoer.print_Info();
