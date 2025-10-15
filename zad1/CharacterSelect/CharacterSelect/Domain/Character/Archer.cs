using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class Archer : Entity.Character
{
    public Archer(string name) : base(name, CharacterClass.Archer)
    {
        Health = 90;
        Strength = 7;
        Intelligence = 6;
        Agility = 6;
        Speed = 25;
        Mana = 0;
        Attack = 25 * 3;
        Skill_Attack = 70;
        Skill_Cooldown = 200 + czas;
    }
}