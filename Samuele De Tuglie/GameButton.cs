using Utilities;

namespace Button
{
    /// <summary>
    /// Class to model a Game Button
    /// </summary>
    public class GameButton : RibbonButton
    {
        private readonly (int, int) _buttonDimension;
        private readonly Pair<int, int> _pos;
        private Image _image;
        private Color _color;
        private readonly bool _isDoor;
        private readonly Pair<int, int> _radius;
        private readonly Pair<int, int> _dim;
        private Pen _pen;

        /// <summary>
        /// Constructor of Game Button
        /// </summary>
        /// <param name="buttonDimension">The dimension of the button in pixel</param>
        /// <param name="pos">The position of the button inside the grid</param>
        /// <param name="isDoor">True if the button is a door</param>
        public GameButton((int, int) buttonDimension, Pair<int, int> pos, bool isDoor)
        {
            _isDoor = isDoor;
            _color = RoomConstant.BASIC_CELL_COLOR;
            _radius = new Pair<int, int>(buttonDimension.Item1 / 4, buttonDimension.Item2 / 4);
            _dim = new Pair<int, int>(buttonDimension.Item1 / 2 - _radius.X / 2,
                buttonDimension.Item2 / 2 - _radius.Y / 2);
            _pos = pos;
            _image = null;
            _buttonDimension = buttonDimension;
            Enabled = false;
            _pen = new Pen(_color);
        }

        protected override void OnPaintText(RibbonElementPaintEventArgs e)
        {
            base.OnPaintText(e);
            if (_isDoor)
            {
                _pen.Color = RoomConstant.DOOR_CELL_COLOR;
                e.Graphics.DrawRectangle(_pen, 10, 10, 10, 10);
            }
            else
            {
                e.Graphics.DrawImage(null, 0, 0, _buttonDimension.Item1, _buttonDimension.Item2);
            }
            if (_image != null)
            {
                e.Graphics.DrawImage(_image, 0, 0, _buttonDimension.Item1, _buttonDimension.Item2);
            }
            if (CheckHighlight())
            {
                _pen.Color = _color;
                e.Graphics.DrawEllipse(_pen, _dim.X, _dim.Y, _radius.X, _radius.Y);
            }
        }

        /// <summary>
        /// Method to control if the cell is highlighted
        /// </summary>
        /// <returns>True if the cell is highlighted otherwise false</returns>
        private bool CheckHighlight()
        {
            return _color.Equals(RoomConstant.ATTACK_HIGHLIGHT) || _color.Equals(RoomConstant.MOVE_HIGHLIGHT)
                || _color.Equals(RoomConstant.ENEMY_RANGE);
        }

        /// <summary>
        /// Draw the given Game Object
        /// </summary>
        /// <param name="object">The game object to draw</param>
        public void DrawGameObject(GameObject object)
        {
            _image = object.Image;
        } 

        /// <summary>
        /// Remove the sprite drawn
        /// </summary>
        public void RemoveSprite()
        {
            _image = null;
        }

        /// <summary>
        /// Method to highlight the cell
        /// </summary>
        /// <param name="backgroudColor">backgroundColor the color to place on background</param>
        public void HighlightCell(Color backgroudColor)
        {
            if(backgroudColor != RoomConstant.ENEMY_RANGE)
            {
                Enabled = true;
            }
            _color = backgroudColor;
        }

        /// <summary>
        /// Method to remove the highlight
        /// </summary>
        public void RemoveHighlight()
        {
            Enabled = false;
            _color = RoomConstant.BASIC_CELL_COLOR;
        }
        
    }
}
