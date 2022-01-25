using CoinTale.ComponentSystem;
using CoinTale.ComponentSystem.Naming;

namespace CoinTale.Entities
{
    public class Table : Entity
    {
        public Table(List<Entity>? childEntities)
        {
            Components.Add(new NameComponent(this, "Regulars table"));
            if (childEntities != null)
            {
                ChildEntities.AddRange(childEntities);
            }
        }
    }
}
