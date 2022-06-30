namespace Utilities
{
    /// <summary>
    /// Class to model a pair of value
    /// </summary>
    /// <typeparam name="A">The type of the first value</typeparam>
    /// <typeparam name="B">The type of the second value</typeparam>
    public class Pair<A, B>
    {
        /// <summary>
        /// The first value of the pair
        /// </summary>
        public A X { get; set; }
        
        /// <summary>
        /// The second value of the pair
        /// </summary>
        public B Y { get; set; }

        /// <summary>
        /// The constructor of the pair
        /// </summary>
        /// <param name="x"> The first value of the pair</param>
        /// <param name="y"> The second value of the pair</param>
        public Pair(A x, B y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Method to revert the value of a pair
        /// </summary>
        /// <param name="pair"> The pair to be reverted</param>
        /// <returns> A new Pair with the value of the pair given inverted</returns>
        public static Pair<B, A> revertPair(Pair<A, B> pair)
        {
            return new Pair<B, A>(pair.Y, pair.X);
        }

        public override int GetHashCode()
        {
            int prime = 31;
            int result = 1;
            result = prime * result + ((X == null) ? 0 : X.GetHashCode());
            result = prime * result + ((Y == null) ? 0 : Y.GetHashCode());
            return result;
        }

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
            Pair<A, B> other = (Pair<A, B>)obj;
            if (X == null)
            {
                if (other.X != null)
                {
                    return false;
                }
            }
            else if (!X.Equals(other.X))
            {
                return false;
            }
            if (Y == null)
            {
                if (other.Y != null)
                {
                    return false;
                }
            }
            else if (!Y.Equals(other.Y))
            {
                return false;
            }
            return true;
        }

        public override string ToString()
        {
            return "Pair [x=" + X + ", y=" + Y + "]";
        }
    }
}
