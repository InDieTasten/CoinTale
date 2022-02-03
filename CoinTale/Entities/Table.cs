using CoinTale.ComponentSystem;
using CoinTale.ComponentSystem.Naming;

namespace CoinTale.Entities
{
    public class Table : Entity
    {
        public Table()
        {
            Components.Add(new NameComponent(this, "Regulars table"));
        }
    }
}
