using PaywallGame.Enums;
using PaywallGame.Factory;
using PaywallGame.Models;
using PaywallGame.Services;
using PaywallGame.Strategies;

namespace PaywallGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player { Name = "Gracz1", Level = 10, IsPremium = false, HasDlc = false };
            Player player2 = new Player { Name = "Gracz2", Level = 50, IsPremium = true, HasDlc = true };

            AccessStrategyFactory factory = new AccessStrategyFactory();

            IAccessStrategy levelStrategy = factory.CreateStrategy(AccessType.Level);
            PaywallService levelService = new PaywallService(levelStrategy);
            levelService.CheckAccess(player1);
            levelService.CheckAccess(player2);

            IAccessStrategy dlcStrategy = factory.CreateStrategy(AccessType.Dlc);
            PaywallService dlcService = new PaywallService(dlcStrategy);
            dlcService.CheckAccess(player1);
            dlcService.CheckAccess(player2);
        }
    }
}