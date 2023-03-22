string name = "Ewa";
bool isMale = false;
int age = 33;

if (isMale == false && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (isMale == true && age < 18)
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}
else 
{
    Console.WriteLine("Brak spełniających kryteriów");
}

