using CharacterSelect.Domain.Character;
using CharacterSelect.Domain.Entity;
using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Application.Factory;

public static class CharacterFactory
{
    public static Character Create(CharacterClass cls, string? name)
    {
        return cls switch
        {
            CharacterClass.Warrior => new Warrior(name ?? "Warrior"),
            CharacterClass.Mage    => new Mage(name ?? "Mage"),
            CharacterClass.Rogue   => new Rogue(name ?? "Rogue"),
            CharacterClass.Ork   => new Ork(name ?? "Ork"),
            CharacterClass.Archer   => new Archer(name ?? "Archer"),
            CharacterClass.Druid   => new Druid(name ?? "Druid"),
            _ => throw new ArgumentOutOfRangeException(nameof(cls), "Nieznana klasa postaci.")
        };
    }
}