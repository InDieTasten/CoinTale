using CoinTale.ComponentSystem;
using CoinTale.ComponentSystem.Naming;
using CoinTale.Entities;

namespace CoinTale.World.Distinct
{
    public class TavernOfHope : Entity
    {
        public TavernOfHope()
        {
            Components.Add(new NameComponent(this, "Tavern of Hope"));
            ChildEntities.Add(new Player());
            ChildEntities.Add(new Table());
        }
    }
}
