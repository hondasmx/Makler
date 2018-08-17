public class MarqueeEventText
{
    public string text;
    public float amount;
    public bool affectCompany;

    public MarqueeEventText(string text, float amount, bool affectCompany)
    {
        this.text = text;
        this.amount = amount;
        this.affectCompany = affectCompany;
    }
}