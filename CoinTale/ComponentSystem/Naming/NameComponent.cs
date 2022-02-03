namespace CoinTale.ComponentSystem.Naming
{
    public class NameComponent : Component
    {
        private string name;

        public NameComponent(Entity entity, string name) : base(entity)
        {
            this.name = name;
            NameComponentSystem.NamedEntities.Add(entity);
        }
    }
}
