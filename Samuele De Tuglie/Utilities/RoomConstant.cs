using System.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Utilities
{
    public class RoomConstant
    {
        public static readonly Color ATTACK_HIGHLIGHT = Color.Red;
        public static readonly Color MOVE_HIGHLIGHT = Color.Blue;
        public static readonly Color ENEMY_RANGE = Color.FromArgb(153, 50, 204);

        public static readonly Color BASIC_CELL_COLOR = Color.Gray;
        public static readonly Color DOOR_CELL_COLOR = Color.FromArgb(110, 38, 14);
        
        public const int FORBIDDEN_ZOMBIE_SPAWN = 3;
        
        public static readonly Tuple<int,int> MAX_DIM = new Tuple<int, int>(10,10);
        
        public static readonly Tuple<int, int> MIN_DIM = new Tuple<int, int>(5, 5);

        public const Image BUTTON_IMAGE = null;
        
        private RoomConstant() { }

        /// <summary>
        /// Method to search a enemy inside a list
        /// </summary>
        /// <param name="pos">The position of the enemy</param>
        /// <param name="enemyList">The List to search in</param>
        /// <returns>The enemy at that position otherwise null</returns>
        public static SimpleEnemy SearchEnemy(Tuple<int, int> pos, List<SimpleEnemy> enemyList)
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

        /// <summary>
        /// Method to search a Artefact inside a list
        /// </summary>
        /// <param name="pos">The position of the artefact</param>
        /// <param name="artefactList">The List to search in</param>
        /// <returns>The artefact at that position otherwise null</returns>
        public static Artefact SearchArtefact(Tuple<int, int> pos, List<Artefact> artefactList)
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
