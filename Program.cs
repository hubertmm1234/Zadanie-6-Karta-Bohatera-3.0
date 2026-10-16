namespace Zadanie_6._Karta_bohatera_3._0_PPGR_3;

class Program
{
    static void Main(string[] args)
    {
        const int plecakLiczbaMiejsc = 10;
        int liczbaPrzedmiotow = 0;
        
        bool przesteganieMiejscPlecaku = true;
        bool mamMiejsceWplecaku = true;
        bool gotowoscDoWyprawy = false;
        
        
        Console.WriteLine("Karta Bohatera 3.0!");
        Console.WriteLine("");
        Console.Write("Podaj imie bohatera: ");
        string imieBohatera = Console.ReadLine();

        Console.Write("Maksymalne Punkty Zycia: ");
        int MaxZycie = int.Parse(Console.ReadLine());

        Console.Write("Podaj aktualne zycie Bohatera: ");
        int aktualneZycieBohatera = int.Parse(Console.ReadLine());

        Console.Write("Podaj podstawowe obrazenia Broni: ");
        int podstawoweObrazenia = int.Parse(Console.ReadLine());

        Console.Write("Podaj premie do sily (Dodaje sie do ataku): ");
        int podstawowePremieDoSily = int.Parse(Console.ReadLine());

        Console.Write("Podaj mnozik ataku specjalnego: ");
        double mnozikataku = double.Parse(Console.ReadLine());

        Console.Write("Podaj Liczbe podstawowych atakow: ");
        int liczbaPodAtakowe = int.Parse(Console.ReadLine());




        Console.Write("Posiadasz Kompas?: (true/false) ");
        bool kompas = bool.Parse(Console.ReadLine());

        Console.Write("Posiadasz mape?:  (true/false) ");
        bool mapa = bool.Parse(Console.ReadLine());

        do
        {
            Console.WriteLine("Podaj liczbe przedmiotow w plecaku (Plecak ma 10 miejsc!)");
            liczbaPrzedmiotow = int.Parse(Console.ReadLine());

            if (plecakLiczbaMiejsc < liczbaPrzedmiotow)
            {
                przesteganieMiejscPlecaku = false;
                Console.Clear();
                Console.WriteLine("Podales za duzo liczbe przedmiotow!");
            }

            if (plecakLiczbaMiejsc >= liczbaPrzedmiotow)
                przesteganieMiejscPlecaku = true;

        } while (przesteganieMiejscPlecaku == false);


        double atakSpecjalny = mnozikataku * podstawoweObrazenia;
        double laczneObrazenia = liczbaPodAtakowe * (podstawoweObrazenia + podstawowePremieDoSily) + atakSpecjalny;
        
        Console.WriteLine("+==========================================+");
        Console.WriteLine("|             KARTA BOHATERA               |");
        Console.WriteLine("+==========================================+");
        Console.WriteLine("| Bohater: " + imieBohatera + "\t \t \t   |");
        Console.WriteLine("| Zdrowie: " + aktualneZycieBohatera + "/" + MaxZycie + " (" +
                          aktualneZycieBohatera * 100 / MaxZycie + "% )" + " \t \t   |");
        Console.WriteLine("| Zwykly atak: " + podstawoweObrazenia + "\t \t \t   |");
        Console.WriteLine("| Atak Specjalny: " + atakSpecjalny + "\t \t \t   |");
        Console.WriteLine("| Laczne zadane obrazenia: " + laczneObrazenia + "\t \t   |");
        Console.WriteLine("+==========================================+");

        if (aktualneZycieBohatera <= 0)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("„Bohater nie żyje.”");
            return;
        }
        Console.WriteLine("|\t INFORMACJE O ZDROWIU BOHATERA \t |");

        if (aktualneZycieBohatera == MaxZycie)
        {
            Console.WriteLine("| Bohater ma Pelen Zdrowie!");
        }
        else if (aktualneZycieBohatera < MaxZycie)
        {
                //ma niski poziom zdrowia, gdy żyje i ma mniej niż 25 punktów,
                if (aktualneZycieBohatera <= MaxZycie / 4)
                {
                    Console.WriteLine("| Bohater ma niski poziom zdrowia!");
                }
        }


            
            if (liczbaPrzedmiotow < plecakLiczbaMiejsc)
            {
                mamMiejsceWplecaku = true;
            }
            else
            {
                mamMiejsceWplecaku = false;
            }
            
            Console.WriteLine("| Miejsce w plecaku: " + mamMiejsceWplecaku + "\t \t   |");
            Console.WriteLine("+==========================================+");
            if (kompas && mapa)
            {
                gotowoscDoWyprawy = true;
            }
            Console.WriteLine("");
            Console.WriteLine("Wcisnij cokolwiek by kontynuowac");
            Console.ReadLine();
            
            while (aktualneZycieBohatera > 0)
            {
                Console.Clear();
                Console.WriteLine("Wybierz akcje");
                Console.WriteLine("1.Sprawdz Stan");
                Console.WriteLine("2.Rozpcznij Wyprawe");
                Console.WriteLine("3.Przygotuj Miksture");
                Console.WriteLine("4.Odpocznij");
                int akcjaBohatera = int.Parse(Console.ReadLine());

                switch (akcjaBohatera)
                {
                    case 1:
                        Console.WriteLine("+==========================================+");
                        Console.WriteLine("|             KARTA BOHATERA               |");
                        Console.WriteLine("+==========================================+");
                        Console.WriteLine("| Bohater: " + imieBohatera + "\t \t \t   |");
                        Console.WriteLine("| Zdrowie: " + aktualneZycieBohatera + "/" + MaxZycie + " (" + aktualneZycieBohatera * 100 / MaxZycie + "% )" + " \t \t   |");
                        Console.WriteLine("| Zwykly atak: " + podstawoweObrazenia + "\t \t \t   |");
                        Console.WriteLine("| Atak Specjalny: " + atakSpecjalny + "\t \t \t   |");
                        Console.WriteLine("| Laczne zadane obrazenia: " + laczneObrazenia + "\t \t   |");
                        Console.WriteLine("+==========================================+");
                        
                        Console.WriteLine("");
                        Console.WriteLine("Wcisnij cokolwiek by kontynuowac");
                        Console.ReadLine();
                        
                        break;
                    case 2:
                        if (gotowoscDoWyprawy)
                        {
                            Console.WriteLine("Rozpoczynasz Wyprawe!");
                        }
                        else
                        {
                            Console.WriteLine("Nie jestes gotowy do wyprawy!");
                        }
                        
                        Console.WriteLine("");
                        Console.WriteLine("Wcisnij cokolwiek by kontynuowac");
                        Console.ReadLine();
                        
                        break;
                    case 3:
                        Console.WriteLine("Przgotowujesz Misksture!");
                        
                        Console.WriteLine("");
                        Console.WriteLine("Wcisnij cokolwiek by kontynuowac");
                        Console.ReadLine();
                        
                        break;
                    case 4:
                        Console.WriteLine("Odpoczywasz");
                        
                        Console.WriteLine("");
                        Console.WriteLine("Wcisnij cokolwiek by kontynuowac");
                        Console.ReadLine();
                        break;
                }
                
                
            }
            
        
    }
}