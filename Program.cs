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

Console.Write("Punkty życia: ");
int zycie=int.Parse(Console.ReadLine()!);
Console.Write("Liczba mikstur: ");
int mikstury=int.Parse(Console.ReadLine()!);
Console.Write("Ma klucz(true or false): ");
bool klucz=bool.Parse(Console.ReadLine()!);
Console.Write("Ma mapę: ");
bool mapa=bool.Parse(Console.ReadLine()!);

bool zyje=zycie>=100;
Console.WriteLine($"Żyje: {zyje}");