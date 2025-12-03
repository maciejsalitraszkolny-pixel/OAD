using System;
using CharacterSelect.Application;
using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Entity;

public abstract class Character
{
    public string Name { get; set; }
    public CharacterClass Class { get; }
    public int Health { get; protected set; }
    public int Strength { get; protected set; }
    public int Intelligence { get; protected set; }
    public int Agility { get; protected set; }
    public int Speed { get; protected set; }
    public int Mana { get; protected set; }
    public int Attack { get; protected set; } 
    
    public int Skill_Attack { get; protected set; } 
    public string Skill_Cooldown { get; protected set; }

    public string czas = " sekund";
    
    public string nazwa_specjal_atk { get; protected set; }
    public int Main_Stat { get; protected set; }
    public int Dexterity { get; protected set; }
    
    
    



    protected Character(string name, CharacterClass @class)
    {
        Name = string.IsNullOrWhiteSpace(name) ? @class.ToString() : name.Trim();
        Class = @class;
    }

    public virtual void Describe()
    {
        Console.WriteLine($"[{Class}] {Name}");
        Console.WriteLine($"  HP: {Health}");
        Console.WriteLine($"  STR: {Strength}  INT: {Intelligence}  AGI: {Agility} MANA : {Mana} SPEED: {Speed} DEX: {Dexterity}");
        Console.WriteLine($"Glowna_Stat: {Main_Stat}"); ;
        Console.WriteLine("\nAkcja: Atak");
        Console.WriteLine($"Atak: {Attack}");
                
        Console.WriteLine($"Akcja Specjalna: {nazwa_specjal_atk}");
        Console.WriteLine($"Atak: {Skill_Attack} Cooldown: {Skill_Cooldown}");
    }
}