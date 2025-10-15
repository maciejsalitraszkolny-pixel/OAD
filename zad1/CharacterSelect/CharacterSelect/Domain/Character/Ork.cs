using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class Ork : Entity.Character
{
    private const int AttackMultiplier = 3;
    public Ork(string name) : base(name, CharacterClass.Ork)
    {
        Health = 200;
        Strength = 20;
        Intelligence = 2;
        Agility = 2;
        Speed = 30;
        Dexterity = 0;
        Mana = 0;
        Main_Stat = Strength;
        Attack = this.Main_Stat * AttackMultiplier;
        Skill_Attack = 67;
        Skill_Cooldown = 80 + czas;
        nazwa_specjal_atk = "Wojenny_Ryk";

    }
}