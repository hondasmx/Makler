using System;
using Random = UnityEngine.Random;

public class Event
{
    public readonly string eventText;
    public readonly int amount;
    private int minAmount;
    private int maxAmount;

    public Event(string eventText, int minAmount, int maxAmount)
    {
        amount = Random.Range(minAmount, maxAmount);
        this.eventText = amount != 0 ? eventText + Math.Abs(amount) : eventText;
    }
}