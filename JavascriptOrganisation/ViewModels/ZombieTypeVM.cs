using ZombieParty.Models;

namespace ZombieParty.ViewModels
{
    public class ZombieTypeVM
    {
        public ZombieType ZombieType { get; set; }
        public List<Zombie> ZombiesList { get; set; } = new List<Zombie>();
        public int ZombiesCount { get; set; }
        public double PointsAverage { get; set; }

    }
}
