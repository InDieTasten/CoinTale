using CoinTale.ComponentSystem;
using CoinTale.ComponentSystem.Location;

namespace CoinTale.Entities
{
    public class RoomA : Entity
    {
        public RoomA()
        {
            Components.Add(new LocationComponent(this)
                .AddNavigableLocation<Start>("Start")
                .AddNavigableLocation<End>("End"));
        }
    }
}
