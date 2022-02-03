namespace CoinTale.ComponentSystem.Location
{
    public class LocationComponent : Component
    {
        private readonly List<NavigationOption> navigationOptions = new();
        public LocationComponent(Entity entity) : base(entity)
        {
        }

        public LocationComponent AddNavigableLocation<TEntity>(string exitName) where TEntity : Entity
        {
            navigationOptions.Add(new NavigationOption(typeof(TEntity), exitName));
            return this;
        }
    }

    public class NavigationOption
    {
        public Type EntityType { get; set; }
        public string ExitName { get; set; }

        public NavigationOption(Type entityType, string exitName)
        {
            EntityType = entityType;
            ExitName = exitName;
        }
    }
}
