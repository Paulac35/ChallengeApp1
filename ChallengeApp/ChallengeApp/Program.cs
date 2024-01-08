// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// " Kobieta poniżej 30 lat"
// " Ewa , lat 33"
// " Niepełnoletni mężczyzna "

bool Woman = true;
int age = 33;
string name = "Ewa";

if (Woman == true && age < 33)
{
    Console.WriteLine("Kobieta poniżej 30lat");

}

else if (name == "Ewa" && age == 33) 
{

    Console.WriteLine("Ewa , lat 33");
}

else if (Woman = false && age < 18) 

{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
