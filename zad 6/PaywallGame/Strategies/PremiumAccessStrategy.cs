using PaywallGame.Models;

namespace PaywallGame.Strategies
{
    public class PremiumAccessStrategy : IAccessStrategy
    {
        public bool CanAccess(Player player) => player.IsPremium;
        public string GetInfo() => "Premium";
    }
}