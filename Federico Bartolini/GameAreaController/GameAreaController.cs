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

namespace GameAreaController
{
    public class GameAreaController
    {

        private Player _player { get; }
        private List<SimpleEnemy> EnemyList { get; }
        private Room room;
        private List<Obstacle> ObstacleList;

        public GameAreaController(Player player)
        {
            _player = player;
            room = new RoomFactory(_player).CreateMediumRoom();
            ObstacleList = room.ObstacleList;
            EnemyList = room.EnemyList;

        }








        public void RemoveGameObject(Tuple<int, int> pos)
        {
            if (pos != null && RoomConstant.CellsOccupated(ObstacleList, _player, EnemyList, pos))
            {
                if (RoomConstant.SearchEnemy(pos, EnemyList) != null)
                {
                    EnemyList.Remove(RoomConstant.SearchEnemy(pos, EnemyList));
                }
            }
        }


    }
}
