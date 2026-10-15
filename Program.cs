//Zad.1
/*
string imie="Maks";
char symbol='@';
double poziom=2;
int zloto=20;
double wagaPlecaka=7.5;
bool czyMaMape=true;
Console.WriteLine("=== EKWIPUNEK ===");
Console.WriteLine($"Imię (string): {imie}");
Console.WriteLine($"Symbol (char): {symbol}");
Console.WriteLine($"Poziom (double): {poziom}");
Console.WriteLine($"Złoto (int): {zloto}");
Console.WriteLine($"Waga (double): {wagaPlecaka} kg");
Console.WriteLine($"Ma mapę (bool): {czyMaMape}");
Console.WriteLine();
poziom=5;
zloto=50;
wagaPlecaka=10;
Console.WriteLine($"Symbol (char): {symbol}");
Console.WriteLine($"Poziom (double): {poziom}");
Console.WriteLine($"Złoto (int): {zloto}");
Console.WriteLine($"Waga (double): {wagaPlecaka} kg");
Console.WriteLine($"Ma mapę (bool): {czyMaMape}");
*/

//Zad.2
/*
int doswiadczenie=40;
int zloto=10;
int trening=1;
Console.WriteLine("Wartość początkowe:");
Console.WriteLine($"Doświadczenie: {doswiadczenie}");
Console.WriteLine($"Złoto: {zloto}");
doswiadczenie+=25;
Console.WriteLine($"Doświadczenie: {doswiadczenie}");
doswiadczenie*=2;
Console.WriteLine($"Doświadczenie: {doswiadczenie}");
zloto-=8;
Console.WriteLine($"Złoto: {zloto}");
zloto+=15;
Console.WriteLine($"Złoto: {zloto}");
trening++;
Console.WriteLine($"Trening: {trening}");
*/

//Zad.3
/*
Console.Write("Liczba racji żywnościowych: ");
int racje=int.Parse(Console.ReadLine()!);
Console.Write("Liczba członków drużyny: ");
int druzyna=int.Parse(Console.ReadLine()!);
Console.Write("Liczba dni wyprawy :");
int dni=int.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.WriteLine($"Ilość racji jaką dostanie każdy członek drużyny: {racje/druzyna}");
Console.WriteLine($"Ilość racji jaka zostanie po podziale: {racje%druzyna}");
Console.WriteLine($"Dzienna ilość racji dla drużyny: {racje/dni}");
Console.WriteLine($"Dzienna porcja racji dla jednej osoby: {(racje/dni)/druzyna}");
*/

//Zad.4
/*
Console.Write("Punkty życia: ");
int zycie = int.Parse(Console.ReadLine()!);
Console.Write("Liczba mikstur: ");
int mikstury = int.Parse(Console.ReadLine()!);
Console.Write("Ma klucz(true or false): ");
bool klucz = bool.Parse(Console.ReadLine()!);
Console.Write("Ma mapę(true or false): ");
bool mapa = bool.Parse(Console.ReadLine()!);

bool zyje = zycie > 0;
bool maPelneZdrowie = zycie == 100;
bool maZaopatrzenie = mikstury > 0;
bool maPrzedmiatNawigacyjny = klucz || mapa;
bool gotowyDoWyprawy = zyje && maZaopatrzenie && maPrzedmiatNawigacyjny;
bool wymagaLeczenia = zycie != 100;

Console.WriteLine();
Console.WriteLine($"Żyje: {zyje}");
Console.WriteLine($"Ma pełne zdrowie: {maPelneZdrowie}");
Console.WriteLine($"Wymaga leczenia: {wymagaLeczenia}");
Console.WriteLine($"Ma zaopatrzenie: {maZaopatrzenie}");
Console.WriteLine($"Ma klucz lub mapę: {maPrzedmiatNawigacyjny}");
Console.WriteLine($"Gotowy do wyprawy: {gotowyDoWyprawy}");
*/

//Zad.5
/*
Console.Write("Imie: ");
string imie = Console.ReadLine()!;
Console.Write("Maksymalne punkty życia: ");
int maksymalnePunktyZycia = int.Parse(Console.ReadLine()!);
Console.Write("Aktualne punkty życia: ");
int aktualnePunktyZycia = int.Parse(Console.ReadLine()!);
Console.Write("Postawowe obrażenia broni: ");
int podstawoweObrazeniaBroni = int.Parse(Console.ReadLine()!);
Console.Write("Obrażenia do siły: ");
int premiaDoSily = int.Parse(Console.ReadLine()!);
Console.Write("Mnożnik ataku specjalnego: ");
double mnoznikAtakuSpecjalnego = double.Parse(Console.ReadLine()!);
Console.Write("Liczba wykonanych ataków:");
int liczbaWykonanychAtakow = int.Parse(Console.ReadLine()!);
int zwyklyAtak = podstawoweObrazeniaBroni + premiaDoSily;
int atakSpecjalny = Convert.ToInt32(zwyklyAtak * mnoznikAtakuSpecjalnego);
int laczneZadaneObrazenia = ((liczbaWykonanychAtakow * zwyklyAtak) + atakSpecjalny);
int procentPozostalegoZycia = (int)Math.Round((double)(100 * aktualnePunktyZycia) / maksymalnePunktyZycia);
bool zyje = aktualnePunktyZycia != 0;
bool maPelneZdrowie = aktualnePunktyZycia == maksymalnePunktyZycia;
Console.WriteLine("========== RAPORT Z WALKI ==========");
Console.WriteLine($"Bohater: {imie}");
Console.WriteLine($"Zdrowie: {aktualnePunktyZycia}/{maksymalnePunktyZycia} ({procentPozostalegoZycia:F2}%)");
Console.WriteLine($"Zwykły atak: {zwyklyAtak}");
Console.WriteLine($"Atak specjalny: {atakSpecjalny}");
Console.WriteLine($"Łączne zadane obrażenia: {laczneZadaneObrazenia}");
Console.WriteLine($"Żyje: {zyje}");
Console.WriteLine($"Pełne zdrowie: {maPelneZdrowie}");
*/

//Zad.6 - Karta bohatera 2.0
Console.Write("Podaj swoje imie: ");
string imie = Console.ReadLine()!;
Console.Write("Podaj swój znacznik na mapie: ");
char znacznik = char.Parse(Console.ReadLine()!);
Console.Write("Podaj ilość punktów zdrowia: ");
double punktyZycia = double.Parse(Console.ReadLine()!);
Console.Write("Podaj maksymalne zdrowie: ");
int maksymalneZdrowie = int.Parse(Console.ReadLine()!);
double procentZdrowia = (punktyZycia / maksymalneZdrowie) * 100;
Console.Write("Podaj ilość siły: ");
int punktySily = int.Parse(Console.ReadLine()!);
Console.Write("Podaj premię do broni: ");
int premiaBroni = int.Parse(Console.ReadLine()!);
int zwykleObrazenia = punktySily + premiaBroni;
Console.Write("Podaj mnożnik ataku specjalnego: ");
double mnoznikAtakuSpecjalnego = double.Parse(Console.ReadLine()!);
int atakSpecjalny = Convert.ToInt32(zwykleObrazenia * mnoznikAtakuSpecjalnego);
Console.Write("Podaj zajętą ilość miejsc w plecaku: ");
int zajeteMiejscaWPlecaku = int.Parse(Console.ReadLine()!);
Console.Write("Podaj maksymalną ilość miejsc w plecaku: ");
int maksmalneMiejsceWPlecaku = int.Parse(Console.ReadLine()!);
int wolneMiejsceWPlecaku = maksmalneMiejsceWPlecaku - zajeteMiejscaWPlecaku;
Console.Write("Podaj czy masz mapę(true or false): ");
bool mapa = bool.Parse(Console.ReadLine()!);
Console.Write("Podaj czy masz kompas(true or false): ");
bool kompas = bool.Parse(Console.ReadLine()!);
bool maPrzedmiatNawigacyjny = mapa || kompas;
Console.Write("Podaj ilość złota jaką aktualnie posiadasz: ");
int iloscZlota = int.Parse(Console.ReadLine()!);
Console.Write("Podaj ile osób liczy druzyna: ");
int liczbaCzlonkowDruzyny = int.Parse(Console.ReadLine()!);
Console.Write("Podaj ilość wygranego zlota: ");
int wygranegoZlota = int.Parse(Console.ReadLine()!);
iloscZlota += (wygranegoZlota / liczbaCzlonkowDruzyny);
Console.Write("Podaj koszt naprawy: ");
int kosztNaprawy = int.Parse(Console.ReadLine()!);
iloscZlota -= kosztNaprawy;
int zlotoDlaJednejOsoby = wygranegoZlota / liczbaCzlonkowDruzyny;
int zlotoPozostaleWSkarbcu = wygranegoZlota % liczbaCzlonkowDruzyny;
bool zyje = punktyZycia != 0;
bool maPelneZdrowie = punktyZycia == maksymalneZdrowie;
bool wymagaLeczenia = punktyZycia != maksymalneZdrowie;
bool maMiejsceWPlecaku = (maksmalneMiejsceWPlecaku - zajeteMiejscaWPlecaku) > 0;
bool gotowyDowyprawy = zyje && maMiejsceWPlecaku && maPrzedmiatNawigacyjny && wymagaLeczenia;

Console.WriteLine("+================================+");
Console.WriteLine("|          KARTA BOHATERA        |");
Console.WriteLine("+================================+");
Console.WriteLine($"| Bohater: {imie}              {znacznik}   |");
Console.WriteLine("+--------------------------------+");
Console.WriteLine($"| Zdrowie: {punktyZycia}/{maksymalneZdrowie} ({procentZdrowia:F2}%)       |");
Console.WriteLine($"| Siła: {punktySily}                       |");
Console.WriteLine($"| Premia broni: {premiaBroni}                |");
Console.WriteLine($"| Zwykłe obrażenia: {zwykleObrazenia}           |");
Console.WriteLine($"| Mnożnik ataku specjalnego: {mnoznikAtakuSpecjalnego} |");
Console.WriteLine($"| Obrażenia ataku specjalnego: {atakSpecjalny}|");
Console.WriteLine("+--------------------------------+");
Console.WriteLine($"| Plecak: {zajeteMiejscaWPlecaku}/{maksmalneMiejsceWPlecaku}                   |");
Console.WriteLine($"| Wolne miejsca: {wolneMiejsceWPlecaku}               |");
Console.WriteLine($"| Złoto: {iloscZlota}                      |");
Console.WriteLine($"| Liczba członków drużyny: {liczbaCzlonkowDruzyny}     |");
Console.WriteLine($"| Złoto dla jednej osoby: {zlotoDlaJednejOsoby}     |");
Console.WriteLine($"| Złoto pozostałe w skarbcu: {zlotoPozostaleWSkarbcu}   |");
Console.WriteLine("+--------------------------------+");
Console.WriteLine($"| Ma przedmiot nawigacyjny: {maPrzedmiatNawigacyjny} |");
Console.WriteLine($"| Żyje: {zyje}                     |");
Console.WriteLine($"| Ma pełne zdrowie: {maPelneZdrowie}        |");
Console.WriteLine($"| Wymaga leczenia: {wymagaLeczenia}          |");
Console.WriteLine($"| Ma miejsce w plecaku: {maMiejsceWPlecaku}     |");
Console.WriteLine($"| Gotowa do wyprawy: {gotowyDowyprawy}        |");
Console.WriteLine("+================================+");
