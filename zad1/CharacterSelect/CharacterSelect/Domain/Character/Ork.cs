using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class Ork : Entity.Character
{
    public Ork(string name) : base(name, CharacterClass.Ork)
    {
        Health = 200;
        Strength = 20;
        Intelligence = 2;
        Agility = 2;
        Speed = 30;
        Mana = 0;
        Attack = 30 * 3;
        Skill_Attack = 67;
        Skill_Cooldown = 80 + czas;

    }
}