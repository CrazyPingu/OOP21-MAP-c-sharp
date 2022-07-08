using EntityObject;
using ObstacleObject;
using RandomGenerator;
using RoomArea;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace GameArea
{
    public class GameAreaController
    {

        public Player Player { get; }
        public List<SimpleEnemy> EnemyList { get; }
        public Room Room { get; }
        public List<Obstacle> ObstacleList { get; }

        public GameAreaController(Player player)
        {
            Player = player;
            Room = new RoomFactory(Player).CreateMediumRoom();
            ObstacleList = Room.ObstacleList;
            EnemyList = Room.EnemyList;

        }








        public void RemoveGameObject(Tuple<int, int> pos)
        {
            if (pos != null && RoomConstant.CellsOccupated(ObstacleList, Player, EnemyList, pos))
            { 
                if (RoomConstant.SearchEnemy(pos, EnemyList) != null)
                {
                    EnemyList.Remove(RoomConstant.SearchEnemy(pos, EnemyList));
                }
            }
        }


    }
}
