using PaywallGame.Models;

namespace PaywallGame.Strategies
{
    public class LevelAccessStrategy : IAccessStrategy
    {
        public bool CanAccess(Player player) => player.Level >= 20;
        public string GetInfo() => "Wymagany poziom 20";
    }
}