using PaywallGame.Models;

namespace PaywallGame.Strategies
{
    public class FreeAccessStrategy : IAccessStrategy
    {
        public bool CanAccess(Player player) => true;
        public string GetInfo() => "Darmowy dostep";
    }
}