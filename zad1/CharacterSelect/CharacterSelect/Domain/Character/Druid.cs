using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class Druid : Entity.Character
{
    private const int AttackMultiplier = 3;
    public Druid(string name) : base(name, CharacterClass.Druid)
    {
        Health = 100;
        Strength = 17;
        Intelligence = 14;
        Agility = 20;
        Speed = 20;
        Dexterity = 40;
        Mana = 40;
        Main_Stat = Agility;
        Attack = this.Main_Stat * AttackMultiplier;
        Skill_Attack = 80;
        Skill_Cooldown = 300 + czas;
        nazwa_specjal_atk = "Przywolanie_Zwierza";
    }
}