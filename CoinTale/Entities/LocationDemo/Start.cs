using CoinTale.ComponentSystem;
using CoinTale.ComponentSystem.Location;

namespace CoinTale.Entities
{
    public class Start : Entity
    {
        public Start()
        {
            Components.Add(new LocationComponent(this)
                .AddNavigableLocation<RoomA>("Room A")
                .AddNavigableLocation<RoomB>("Room B"));
            ChildEntities.Add(new Player());
        }
    }
}
