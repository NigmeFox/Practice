using System.Collections;

namespace IEnumerable
{
    class MyCollectionInt : IEnumerable<int>
    {
        private int[] array = {2, 3, 4, 5};
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < array.Length; i++)
            {
            
            }
        }

        IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

List<>.Enumerator GetEnumerator()