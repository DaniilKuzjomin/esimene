using esimene;

//koer koer = new koer(koer.toug.pudel, "Sharik", "Krasnij", Koduloom.sugu.isane, 15.5, 7, true);
//koer.print_Info();
//koer.print_golos();
//koer veelkoer = new koer(koer);
//veelkoer.muudaNimi("Aleksei");
//veelkoer.print_Info();



Tootaja tootaja = new Tootaja("Polütehnikum", "Õpetaja", "Aleksei", 1972, Isik.sugu.mees, 500, 1600);
//Opilane Opilane = new Opilane("Tallinna Humanitaargümnaasium", 9, "pöhikool", "Maria", 2007, Isik.sugu.naine, 0, 0);
//Kutsekooliopilane Kutsekooliopilane = new Kutsekooliopilane("THK", "Viimsi", 460, 3, 4.2, "Tarkvaraarendaja", 2, 60, "TARpv21", "Tarkvaraarendaja", "Daniil", 2005, Isik.sugu.mees, 0,0);
tootaja.printInfo();
//Kutsekooliopilane.printInfo();
//Opilane.printInfo();
//Console.WriteLine(" ");



//people.Add(Opilane);
//people.Add(Kutsekooliopilane);


List<Tootaja> tootajad = new List<Tootaja>();
tootajad.Add(tootaja);
StreamWriter to_file = new StreamWriter(@"..\..\..\file.txt", false);
foreach (Tootaja p in tootajad)
{
    p.printInfo();
    to_file.WriteLine($"{p.asutus}, {p.amet}, {p.nimi}, {p.sunniaasta}, {p.InimSugu}, {p.maksuvaba}, {p.palk}") ; 
}
to_file.Close();

StreamReader sr = new StreamReader(@"..\..\..\file.txt");
string text;
while ((text = sr.ReadLine()) != null)
{
    string[] rida = text.Split(',');
    tootajad.Add(new Tootaja(rida[0], rida[1],  rida[2], int.Parse(rida[3]), TextToSugu(rida[4]), double.Parse(rida[5]), double.Parse(rida[6])));
}
sr.Close();

foreach (var item in tootajad)
{
    Console.WriteLine(item.nimi + ", " + item.asutus + ", " + item.amet + ", " + item.sunniaasta + ", " + item.InimSugu + ", " + item.maksuvaba + ", " + item.palk);
}
Console.ReadLine();

Isik.sugu TextToSugu(string andmed)
{
    switch (andmed)
    {
        case "naine":
            return Isik.sugu.naine;
        default:
            return Isik.sugu.mees;
    }
}

//StreamReader sr = new StreamReader(@"..\..\..\file.txt");
//List<string> Lines = new List<string>();
//int n = sr.ReadToEnd().Split(new char[] { '\n' }).Length;

//Console.WriteLine(" ");
//var file = File.ReadAllText(@"..\..\..\file.txt").Split(", ");
//foreach (var item in file)
//{
//    Console.Write(item + ", ");
//}

