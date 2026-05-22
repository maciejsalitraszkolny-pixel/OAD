using PaywallGame.Enums;
using PaywallGame.Strategies;

namespace PaywallGame.Factory
{
    public class AccessStrategyFactory
    {
        public IAccessStrategy CreateStrategy(AccessType type)
        {
            return type switch
            {
                AccessType.Free => new FreeAccessStrategy(),
                AccessType.Premium => new PremiumAccessStrategy(),
                AccessType.Level => new LevelAccessStrategy(),
                AccessType.Dlc => new DlcAccessStrategy(),
                _ => new FreeAccessStrategy()
            };
        }
    }
}