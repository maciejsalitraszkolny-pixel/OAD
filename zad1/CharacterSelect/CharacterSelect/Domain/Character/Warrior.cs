using CharacterSelect.Application;
using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class Warrior : Entity.Character
{
    private const int AttackMultiplier = 3;
    public Warrior(string name) : base(name, CharacterClass.Warrior)
    {
        Health = 120;
        Strength = 14;
        Intelligence = 6;
        Agility = 8;
        Speed = 20;
        Dexterity = 0;
        Mana = 20;
        Main_Stat = Strength;
        Attack = this.Main_Stat * AttackMultiplier;
        Skill_Attack = 100;
        Skill_Cooldown = 400 + czas;
        nazwa_specjal_atk = "Zabójcza_Szarża";
    }
}