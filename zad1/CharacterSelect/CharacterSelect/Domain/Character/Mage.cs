using CharacterSelect.Application;
using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class Mage : Entity.Character
{
    private const int AttackMultiplier = 3;
    public Mage(string name) : base(name, CharacterClass.Mage)
    {
        Health = 80;
        Strength = 4;
        Intelligence = 16;
        Agility = 10;
        Speed = 20;
        Dexterity = 45;
        Mana = 50;
        Main_Stat = Intelligence;
        Attack = this.Main_Stat * AttackMultiplier;
        Skill_Attack = 75;
        Skill_Cooldown = 150 + czas;
        nazwa_specjal_atk = "Ognista_Kula";
    }
}