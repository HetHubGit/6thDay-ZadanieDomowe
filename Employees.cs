namespace _6thDay_ZadanieDomowe;
internal class Employee
{
    private List<int> score = new List<int>();
    public string name { get; private set; }
    public string surname { get; private set; }
    public int age { get; private set; }
    public Employee(string name, string surname, int age)
    {
        this.name = name;
        this.surname = surname;
        this.age = age;
    }
    public int Result
    {
        get
        {
            return score.Sum();
        }
    }
    public void AddScore(int number)
    {
        score.Add(number);
    }
}