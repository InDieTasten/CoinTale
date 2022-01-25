using CoinTale.ComponentSystem;
using CoinTale.ComponentSystem.Naming;

namespace CoinTale.Entities
{
    public class Player : Entity
    {
        public Player()
        {
            Components.Add(new NameComponent(this, "Laura"));
        }
    }
}
