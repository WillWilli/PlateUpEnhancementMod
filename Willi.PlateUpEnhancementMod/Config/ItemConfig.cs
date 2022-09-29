namespace Willi.PlateUpEnhancementMod.Config
{
    public class ItemConfig
    {
        public ItemConfig(string name, int id, int spawnRate)
        {
            Name = name;
            Id = id;
            SpawnRate = spawnRate;
        }

        public string Name { get; private set; }
        public int Id { get; private set; }
        public int SpawnRate { get; private set; }
    }
}
