namespace CoinTale.ComponentSystem.Naming
{
    public class NameComponent : Component
    {
        private object entity;
        private string name;

        public NameComponent(Entity entity, string name)
        {
            this.entity = entity;
            this.name = name;
            NameComponentSystem.NamedEntities.Add(entity);
        }
    }
}
