namespace CollectionsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var intList = new List<int>() { 1, 2, 3, 4, 5 };
            var linkedList = new LinkedList<string>();
            var words = new SortedDictionary<int, string>() { { 1, "AUEB"}, { 2, "OPA" } };
            var stack = new Stack<string>();
            var queue = new Queue<string>();
            var charSet = new SortedSet<char>() { 'a', 'b', 'd', 'c'};

            intList.Add(4);
            intList.AddRange([1, 2, 3]);
            intList.Add(5);
            intList.Insert(0, 5);
            intList.RemoveAt(0);
            intList[0] = 3;
            intList[1] = 4;

            intList.Sort();
            intList.Reverse();

            foreach (int i in intList)
            {
                Console.WriteLine(el);
            }

            intList.ForEach(x => Console.WriteLine(x));
            intList.ForEach(Console.WriteLine);

            /*
             * Linked List
             */


        }
    }
}
