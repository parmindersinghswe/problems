namespace Problems.Library.Medium.RandomizedSet
{
    /// <summary>
    /// Solution for the "Randomized Set" problem.
    /// This class allows insertion, deletion, and random retrieval of elements in constant time.
    /// </summary>
    public class RandomizedSetSolution
    {
        readonly private List<int>? list;
        readonly private Dictionary<int, int>? dict;
        readonly private Random? random;

        /// <summary>
        /// Initializes a new instance of the <see cref="RandomizedSetSolution"/> class.
        /// </summary>
        public RandomizedSetSolution()
        {
            list = new List<int>();
            dict = new Dictionary<int, int>();
            random = new Random();
        }

        /// <summary>
        /// Inserts a value into the set. Returns true if the set did not already contain the specified element.
        /// </summary>
        /// <param name="val">The value to insert.</param>
        /// <returns>true if the element was inserted; false if it was already present.</returns>
        public bool Insert(int val)
        {
            if (dict!.ContainsKey(val))
            {
                return false;
            }
            dict[val] = list!.Count;
            list.Add(val);
            return true;
        }

        /// <summary>
        /// Removes a value from the set. Returns true if the set contained the specified element.
        /// </summary>
        /// <param name="val">The value to remove.</param>
        /// <returns>true if the element was removed; false if it was not present.</returns>
        public bool Remove(int val)
        {
            if (!dict!.ContainsKey(val))
            {
                return false;
            }
            int index = dict[val];
            int lastElement = list![list.Count - 1];
            list[index] = lastElement;
            dict[lastElement] = index;
            list.RemoveAt(list.Count - 1);
            dict.Remove(val);
            return true;
        }

        /// <summary>
        /// Gets a random element from the set.
        /// </summary>
        /// <returns>A random element from the set.</returns>
        public int GetRandom()
        {
            int randomIndex = random!.Next(0, list!.Count);
            return list[randomIndex];
        }
    }
}
