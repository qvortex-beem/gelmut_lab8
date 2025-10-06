using System.ComponentModel.Design;

class Hero {
    public string Name { get; set; }
    public int Mana { get; set; }
    public int Level { get; set; }
    private int _health;
    private int _maxHealth;

    public Hero(string name, int maxHealth) {
        Name = name;
        Mana = 100;
        Level = 1;
        _maxHealth = maxHealth;
        _health = maxHealth;
    }
    public int Health {
        get => _health;
        set {
            if (value < 0) _health = 0;
            else if (value > _maxHealth) _health = _maxHealth;
            else _health = value;
        }
    }
    public string Status => (_health > 0) ? "жив" : "мертв";

    public void TakeDamage(int damage) {
        if (_health <= 0) {
            Console.WriteLine("Персонаж мертв");
            return;
        }
        Health -= damage;
        Console.WriteLine($"Персонаж {Name} получил {damage} урона. HP: {Health}. Статус: {Status}");
    }

    public void Heal(int amount) {
        if (_health <= 0) {
            Console.WriteLine("Персонаж мертв");
            return;
        }
        Health += amount;
        Console.WriteLine($"Персонаж {Name} исцелен на {amount} HP. HP: {Health}. Статус: {Status}");
    }
}
