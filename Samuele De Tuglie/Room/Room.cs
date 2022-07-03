using Utilities;
using Button;
using System;
using System.Collections.Generic;

namespace RoomArea
{
    /// <summary>
    /// Class that rappresent a Room
    /// </summary>
    public class Room : IRoom
    {
        public Tuple<int, int> Size { get; }
        public Dictionary<Tuple<int, int>, GameButton> Cells { get; }
        public Player Player { get; }
        public List<Tuple<int, int>> Door { get; }
        public List<SimpleEnemy> EnemyList { get; set; }
        public List<Artefact> ArtefactList { get; set; }
        public List<Obstacle> ObstacleList { get; set; }

        /// <summary>
        /// Constructor of the Room
        /// </summary>
        /// <param name="size">The size of the room</param>
        /// <param name="Player">The player of the game</param>
        /// <param name="newPosPlayer">The new position of the player</param>
        public Room(Tuple<int, int> size, Player Player, Tuple<int, int> newPosPlayer)
        {
            Size = size;
            Player = Player;
            Door = GenerateDoor();
            Cells = new Dictionary<Tuple<int, int>, GameButton>();
        }

        /// <summary>
        /// Method to generate the door
        /// </summary>
        /// <returns>A list of tuple that rappresent the door</returns>
        private List<Tuple<int, int>> GenerateDoor()
        {
            List<Tuple<int, int>> tmp = new List<Tuple<int, int>>();
            tmp.Add(new Tuple<int, int>(Size.Item1 - 1, Size.Item2 / 2));
            if (Size.Item2 % 2 == 0)
            {
                tmp.Add(new Tuple<int, int>(Size.Item1 - 1, Size.Item2 / 2 - 1));
            }
            return tmp;
        }

        /// <inheritdoc />
        public bool PlayerOnDoor()
        {
            return Door.Contains(Player.Pos);
        }

        /// <inheritdoc />
        public void RemoveObject(Tuple<int, int> pos)
        {
            if (RoomConstant.SearchEnemy(pos, EnemyList) != null)
            {
                EnemyList.Remove(RoomConstant.SearchEnemy(pos, EnemyList));
            }
            else if (RoomConstant.SearchArtefact(pos, ArtefactList) != null)
            {
                ArtefactList.Remove(RoomConstant.SearchArtefact(pos, ArtefactList));
            }
            else if (Player.Pos.Equals(pos))
            {
                Player = null;
            }
        }

        /// <inheritdoc />
        public void UpdatePosition(Tuple<int, int> oldPos, Tuple<int, int> newPos)
        {
            if (RoomConstant.SearchEnemy(oldPos, EnemyList) != null)
            {
                RoomConstant.SearchEnemy(oldPos, EnemyList).Pos = newPos;
            }
            else if (Player.Pos.Equals(oldPos))
            {
                this.Player.Pos = newPos;
            }
        }
        
        /// <inheritdoc />
        public void AddButtonToCells(Tuple<int, int> pos, GameButton button)
        {
            Cells.Add(pos, button);
        }
    }
}
