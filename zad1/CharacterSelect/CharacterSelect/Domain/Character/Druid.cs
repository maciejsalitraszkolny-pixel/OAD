using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class Druid : Entity.Character
{
    public Druid(string name) : base(name, CharacterClass.Druid)
    {
        Health = 100;
        Strength = 17;
        Intelligence = 14;
        Agility = 20;
        Speed = 20;
        Mana = 40;
        Attack = 20 * 3;
        Skill_Attack = 80;
        Skill_Cooldown = 300 + czas;
    }
}