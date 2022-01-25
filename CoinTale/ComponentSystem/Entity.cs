namespace CoinTale.ComponentSystem
{
    public class Entity
    {
        public List<Component> Components { get; set; } = new List<Component>();
        public List<Entity> ChildEntities { get; set; } = new List<Entity>();
    }
}
