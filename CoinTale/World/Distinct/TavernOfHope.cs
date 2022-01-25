using CoinTale.ComponentSystem;
using CoinTale.ComponentSystem.Naming;

namespace CoinTale.World.Distinct
{
    public class TavernOfHope : Entity
    {
        public TavernOfHope()
        {
            Components.Add(new NameComponent(this, "Tavern of Hope"));
        }
    }
}
