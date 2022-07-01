using Utilities;
using Button;

namespace Room
{
    /// <summary>
    /// Class that rappresent a Room
    /// </summary>
    public class Room : IRoom
    {
        public Pair<int, int> Size { get; }
        public Dictionary<Pair<int, int>, GameButton> Cells { get; }
        public Player Player { get; }
        public List<Pair<int, int>> Door { get; }
        public List<SimpleEnemy> EnemyList { get; set; }
        public List<Artefact> ArtefactList { get; set; }
        public List<Obstacle> ObstacleList { get; set; }

        /// <summary>
        /// Constructor of the Room
        /// </summary>
        /// <param name="size">The size of the room</param>
        /// <param name="Player">The player of the game</param>
        /// <param name="newPosPlayer">The new position of the player</param>
        public RoomImpl(Pair<int, int> size, Player Player, Pair<int, int> newPosPlayer)
        {
            Size = size;
            Player = Player;
            Door = GenerateDoor();
        }

        /// <summary>
        /// Method to generate the door
        /// </summary>
        /// <returns>A list of pair that rappresent the door</returns>
        private List<Pair<int, int>> GenerateDoor()
        {
            List<Pair<int, int>> tmp = new List<Pair<int, int>>();
            tmp.Add(new Pair<int, int>(Size.X - 1, Size.Y / 2));
            if (Size.Y % 2 == 0)
            {
                tmp.Add(new Pair<int, int>(Size.X - 1, Size.Y / 2 - 1));
            }
            return tmp;
        }

        /// <inheritdoc />
        public bool PlayerOnDoor()
        {
            return Door.Contains(Player.Pos);
        }

        /// <inheritdoc />
        public void RemoveObject(Pair<int, int> pos)
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
        public void UpdatePosition(Pair<int, int> oldPos, Pair<int, int> newPos)
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

        public void AddButtonToCells(Pair<int, int> pos, GameButton button)
        {
            Cells.Add(pos, button);
        }
    }
}
