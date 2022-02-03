using CoinTale.ComponentSystem;

namespace CoinTale.Entities
{
    public class RootEntity : Entity
    {
        public RootEntity()
        {
            ChildEntities.Add(new Start());
            ChildEntities.Add(new RoomA());
            ChildEntities.Add(new RoomB());
            ChildEntities.Add(new End());
        }
    }
}
