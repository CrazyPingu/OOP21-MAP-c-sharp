using EntityObject;
using ObstacleObject;
using RoomArea;
using System;
using System.Collections.Generic;
using Utilities;

namespace GameArea
{
    /// <summary>
    /// The Game Area Controller Class
    /// </summary>
    public class GameAreaController
    {
        
        public Player Player { get; }
        public List<SimpleEnemy> EnemyList { get; }
        public Room Room { get; }
        public List<Obstacle> ObstacleList { get; }

        /// <summary>
        /// The constructor.
        /// </summary>
        /// <param name="player"> The Player</param>
        public GameAreaController(Player player)
        {
            Player = player;
            Room = new RoomFactory(Player).CreateMediumRoom();
            ObstacleList = Room.ObstacleList;
            EnemyList = Room.EnemyList;

        }







        /// <summary>
        /// Method to remove the object in the passed position
        /// </summary>
        /// <param name="pos">The position of the object that we want to remove</param>
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
