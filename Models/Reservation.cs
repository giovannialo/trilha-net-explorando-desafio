namespace trilha_net_explorando_desafio.Models;

public class Reservation
{
    public List<Person> Guests { get; set; }
    public Suite Suite { get; set; }
    public int ReservedDays { get; set; }

    public Reservation(Suite suite, int reservedDays)
    {
        Suite = suite;
        ReservedDays = reservedDays;
    }

    public void RegisterGuests(List<Person> guests)
    {
        if (guests.Count > Suite.Capacity)
        {
            throw new Exception($"A capacidade máxima para esta suite é de {Suite.Capacity} pessoa(s).");
        }

        Guests = guests;
    }

    public int GetNumberOfGuests()
    {
        return Guests.Count;
    }

    public decimal CalculateDailyRate()
    {
        return Suite.DailyValue * ReservedDays;
    }
}