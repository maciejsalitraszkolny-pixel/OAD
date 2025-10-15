using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class Archer : Entity.Character
{
    private const int AttackMultiplier = 3; 
    public Archer(string name) : base(name, CharacterClass.Archer)
    {
        Health = 90;
        Strength = 7;
        Intelligence = 6;
        Agility = 6;
        Speed = 25;
        Dexterity = 50;
        Mana = 0;
        Main_Stat = Dexterity;
        Attack = this.Main_Stat * AttackMultiplier;
        Skill_Attack = 70;
        Skill_Cooldown = 200 + czas;
        nazwa_specjal_atk = "Deszcz_Strzal";
    }
}