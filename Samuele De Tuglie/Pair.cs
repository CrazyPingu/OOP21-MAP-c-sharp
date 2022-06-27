namespace Utilities
{
    /// <summary>
    /// Class to model a pair of value
    /// </summary>
    /// <typeparam name="X">The type of the first value</typeparam>
    /// <typeparam name="Y">The type of the second value</typeparam>
    internal class Pair<X, Y>
    {
        /// <summary>
        /// The first value
        /// </summary>
        private X _x
        {
            get => _x;
            set => _x = value;
        }

        /// <summary>
        /// The second value
        /// </summary>
        private Y _y
        {
            get => _y;
            set => _y = value;
        }

        /// <summary>
        /// The constructor of the pair
        /// </summary>
        /// <param name="x"> The first value</param>
        /// <param name="y"> The second value</param>
        public Pair(X x, Y y)
        {
            _x = x;
            _y = y;
        }

        /// <summary>
        /// Method to revert the value of a pair
        /// </summary>
        /// <param name="pair"> The pair to be reverted</param>
        /// <returns> Return a new Pair with the value of the pair given inverted</returns>
        public static Pair<X, Y> reverPair(Pair<Y, X> pair)
        {
            return new Pair<X, Y>(pair._y, pair._x);
        }

        /// <summary>
        /// Method to calculate the hashcode
        /// </summary>
        /// <returns>Return a new hash code</returns>
        public override int GetHashCode()
        {
            int prime = 31;
            int result = 1;
            result = prime * result + ((_x == null) ? 0 : _x.GetHashCode());
            result = prime * result + ((_y == null) ? 0 : _y.GetHashCode());
            return result;
        }

        /// <summary>
        /// Method to compare two Pair
        /// </summary>
        /// <param name="obj">The Pair to compare</param>
        /// <returns>Return true if the pair are equals else false</returns>
        public override bool Equals(object obj)
        {
            if (this == obj)
            {
                return true;
            }
            if (obj == null)
            {
                return false;
            }
            if (this.GetType().Name != obj.GetType().Name)
            {
                return false;
            }
            Pair<X, Y> other = (Pair<X, Y>)obj;
            if (_x == null)
            {
                if (other._x != null)
                {
                    return false;
                }
            }
            else if (!_x.Equals(other._x))
            {
                return false;
            }
            if (_y == null)
            {
                if (other._y != null)
                {
                    return false;
                }
            }
            else if (!_y.Equals(other._y))
            {
                return false;
            }
            return true;
        }



        /// <summary>
        /// Method to have a string representation of the pair
        /// </summary>
        /// <returns>Returns a string that rappresent the pair</returns>
        public override string ToString()
        {
            return "Pair [x=" + _x + ", y=" + _y + "]";
        }
    }
}
