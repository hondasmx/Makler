public class Company
{
    public readonly string firstName;
    private readonly string secondName;

    public Company(string firstName, string secondName)
    {
        this.firstName = firstName;
        this.secondName = secondName;
    }

    public string FullName()
    {
        return firstName + " " + secondName;
    }

    public override string ToString()
    {
        return "<size=36>" + firstName + "</size>" + "\n" + "<size=24>" + secondName + "</size>";
    }
}