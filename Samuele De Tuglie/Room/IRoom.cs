using Button;
using System;

namespace Room
{
    /// <summary>
    /// Interface for the creation of a room
    /// </summary>
    public interface IRoom
    {
        /// <summary>
        /// Method to control if the player is on the door
        /// </summary>
        /// <returns>True if the player is on the door otherwise false</returns>
        bool PlayerOnDoor();

        /// <summary>
        /// Method to add a button to the grid
        /// </summary>
        /// <param name="pos">The position of the button</param>
        /// <param name="button">The button to be added</param>
        void AddButtonToCells(Tuple<int, int> pos, GameButton button);

        /// <summary>
        /// Method to remove an object from the game
        /// </summary>
        /// <param name="pos">The position of the object to be removed</param>
        void UpdatePosition(Tuple<int, int> oldPos, Tuple<int, int> newPos);

        /// <summary>
        /// Method to move an object in the game
        /// </summary>
        /// <param name="oldPos">The current position of the object</param>
        /// <param name="newPos">The position that the object will go on</param>
        void RemoveObject(Tuple<int, int> pos);
    }
}