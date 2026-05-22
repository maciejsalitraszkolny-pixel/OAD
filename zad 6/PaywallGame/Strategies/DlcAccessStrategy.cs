using PaywallGame.Models;

namespace PaywallGame.Strategies
{
    public class DlcAccessStrategy : IAccessStrategy
    {
        public bool CanAccess(Player player) => player.HasDlc;
        public string GetInfo() => "Wymagane DLC";
    }
}