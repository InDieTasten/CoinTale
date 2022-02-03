using CoinTale.ComponentSystem;
using CoinTale.ComponentSystem.Location;

namespace CoinTale.Entities
{
    public class RoomB : Entity
    {
        public RoomB()
        {
            Components.Add(new LocationComponent(this)
                .AddNavigableLocation<Start>("Start")
                .AddNavigableLocation<End>("End"));
        }
    }
}
