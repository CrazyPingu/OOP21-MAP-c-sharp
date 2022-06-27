namespace Utilities
{
    /// <summary>
    /// Class to model a pair of value
    /// </summary>
    /// <typeparam name="X">The type of the first value</typeparam>
    /// <typeparam name="Y">The type of the second value</typeparam>
    public class Pair<X, Y>
    {
        /// <summary>
        /// The first value of the pair
        /// </summary>
        public X First { get; set; }

        /// <summary>
        /// The second value of the pair
        /// </summary>
        public Y Second { get; set; }

        /// <summary>
        /// The constructor of the pair
        /// </summary>
        /// <param name="x"> The first value of the pair</param>
        /// <param name="y"> The second value of the pair</param>
        public Pair(X x, Y y)
        {
            First = x;
            Second = y;
        }

        /// <summary>
        /// Method to revert the value of a pair
        /// </summary>
        /// <param name="pair"> The pair to be reverted</param>
        /// <returns> A new Pair with the value of the pair given inverted</returns>
        public static Pair<X, Y> revertPair(Pair<Y, X> pair)
        {
            return new Pair<X, Y>(pair.Second, pair.First);
        }

        /// <summary>
        /// Method to calculate the hashcode
        /// </summary>
        /// <returns>A new hash code</returns>
        public override int GetHashCode()
        {
            int prime = 31;
            int result = 1;
            result = prime * result + ((First == null) ? 0 : First.GetHashCode());
            result = prime * result + ((Second == null) ? 0 : Second.GetHashCode());
            return result;
        }

        /// <summary>
        /// Method to compare two Pair
        /// </summary>
        /// <param name="obj">The Pair to compare</param>
        /// <returns>True if the pair are equals else false</returns>
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
            if (GetType().Name != obj.GetType().Name)
            {
                return false;
            }
            Pair<X, Y> other = (Pair<X, Y>)obj;
            if (First == null)
            {
                if (other.First != null)
                {
                    return false;
                }
            }
            else if (!First.Equals(other.First))
            {
                return false;
            }
            if (Second == null)
            {
                if (other.Second != null)
                {
                    return false;
                }
            }
            else if (!Second.Equals(other.Second))
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
            return "Pair [x=" + First + ", y=" + Second + "]";
        }
    }
}
