using trilha_net_explorando_desafio.Models;

var giovanni = new Person("Giovanni", "Oliveira");
var dayane = new Person("Dayane", "Ferreira");

var guests = new List<Person>() { giovanni, dayane };

var suite = new Suite("Premium", 2, 140.00M);

var reservation = new Reservation(suite, 10);

try
{
    reservation.RegisterGuests(guests);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine($"Suite: {suite.Type}");
Console.WriteLine($"Total de hóspedes: {reservation.GetNumberOfGuests()}");
Console.WriteLine($"Valor total: {reservation.CalculateDailyRate():C}");