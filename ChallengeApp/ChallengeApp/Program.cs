// Zadanie dnia czwartego

string name = "Ewa";
bool isWoman = true;
int age = 33;

if (isWoman == true && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (isWoman == true && age == 33 && name == "Ewa")
{
    Console.WriteLine("Ewa, lat 33");
}
else if (isWoman == false && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else
{
    Console.WriteLine("Nieznana osoba.");
}
    
var keyInfo = Console.ReadKey(true); // w wersji 17.8.0 Visual Studio program zamyka się automatycznie

