using Base;
class PersonInBaseNamespace {
    string name;
    Company company;
    public PersonInBaseNamespace(string name, Company company)
    {
        this.name = name;
        this.company = company;
    }
    public void Print()
    {
        Console.WriteLine($"Имя: {name}");
        company.Print();
    }
}

