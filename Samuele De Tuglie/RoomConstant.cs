namespace Utilities
{
    public class RoomConstant
    {
        public static Color ATTACK_HIGHLIGHT = Color.Red;
        public static Color MOVE_HIGHLIGHT = Color.Blue;
        public static Color ENEMY_RANGE = Color.FromArgb(153, 50, 204);

        public static Color BASIC_CELL_COLOR = Color.Gray;
        public static Color DOOR_CELL_COLOR = Color.FromArgb(110, 38, 14);

        public static int FORBIDDEN_ZOMBIE_SPAWN = 3;

        
        public static SimpleEnemy SearchEnemy(Pair<int, int> pos, List<SimpleEnemy> enemyList)
        {
            if (enemyList != null && enemyList.Any())
            {
                foreach (SimpleEnemy x in enemyList)
                {
                    if (x.Pos.Equals(pos))
                    {            
                        return x;
                    }
                }
            }
            return null;
        }

        public static Artefact SearchArtefact(Pair<int, int> pos, List<Artefact> artefactList)
        {
            if (artefactList != null && artefactList.Any())
            {
                foreach (Artefact x in artefactList)
                {
                    if (x.Pos.Equals(pos))
                    {
                        return x;
                    }
                }
            }
            return null;
        }
    }
}
