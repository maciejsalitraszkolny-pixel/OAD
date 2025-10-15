using CharacterSelect.Application;
using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class Rogue : Entity.Character
{
    private const int AttackMultiplier = 3;
    public Rogue(string name) : base(name, CharacterClass.Rogue)
    {
        Health = 95;
        Strength = 9;
        Intelligence = 8;
        Agility = 15;
        Speed = 30;
        Dexterity = 0;
        Mana = 0;
        Main_Stat = Speed;
        Attack = this.Main_Stat * AttackMultiplier;
        Skill_Attack = 70;
        Skill_Cooldown = 60 + czas;
        nazwa_specjal_atk = "Atak_Krytyczny";
    }
}