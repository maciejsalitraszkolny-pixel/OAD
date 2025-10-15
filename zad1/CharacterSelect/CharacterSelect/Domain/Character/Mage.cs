using CharacterSelect.Application;
using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class Mage : Entity.Character
{
    public Mage(string name) : base(name, CharacterClass.Mage)
    {
        Health = 80;
        Strength = 4;
        Intelligence = 16;
        Agility = 10;
        Speed = 20;
        Mana = 50;
        Attack = 20 * 3;
        Skill_Attack = 75;
        Skill_Cooldown = 150 + czas;
    }
}