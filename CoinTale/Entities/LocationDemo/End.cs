using CoinTale.ComponentSystem;
using CoinTale.ComponentSystem.Location;

namespace CoinTale.Entities
{
    public class End : Entity
    {
        public End()
        {
            Components.Add(new LocationComponent(this)
                .AddNavigableLocation<RoomA>("Room A")
                .AddNavigableLocation<RoomB>("Room B"));
        }
    }
}
