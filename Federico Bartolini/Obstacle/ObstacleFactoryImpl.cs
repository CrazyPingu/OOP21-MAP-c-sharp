using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObstacleObject

{
    public class ObstacleFactoryImpl : IObstacleFactory
    {
        public Obstacle CreatePebble(Tuple<int, int> pos)
        {
            return new Obstacle(pos, "rock", null);
        }

        public Obstacle CreateRock(Tuple<int, int> pos)
        {
            return new Obstacle(pos, "pebble", null);
        }
    }
}
