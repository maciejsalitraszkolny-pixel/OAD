using System;
using PaywallGame.Models;
using PaywallGame.Strategies;

namespace PaywallGame.Services
{
    public class PaywallService
    {
        private readonly IAccessStrategy _strategy;

        public PaywallService(IAccessStrategy strategy)
        {
            _strategy = strategy;
        }

        public void CheckAccess(Player player)
        {
            Console.Write($"Gracz {player.Name} [{_strategy.GetInfo()}] -> ");
            if (_strategy.CanAccess(player))
                Console.WriteLine("DOSTEP PRZYZNANY");
            else
                Console.WriteLine("ZABLOKOWANE");
        }
    }
}