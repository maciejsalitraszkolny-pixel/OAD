using CharacterSelect.Application;
using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class Rogue : Entity.Character
{
    public Rogue(string name) : base(name, CharacterClass.Rogue)
    {
        Health = 95;
        Strength = 9;
        Intelligence = 8;
        Agility = 15;
        Speed = 30;
        Mana = 0;
        Attack = 20 * 3;
        Skill_Attack = 70;
        Skill_Cooldown = 60 + czas;
    }
}