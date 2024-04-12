namespace trilha_net_explorando_desafio.Models;

public class Suite
{
    public string Type { get; set; }
    public int Capacity { get; set; }
    public decimal DailyValue { get; set; }

    public Suite(string type, int capacity, decimal dailyValue)
    {
        Type = type;
        Capacity = capacity;
        DailyValue = dailyValue;
    }
}