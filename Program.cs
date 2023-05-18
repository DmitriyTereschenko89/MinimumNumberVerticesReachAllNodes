namespace MinimumNumberVerticesReachAllNodes
{
    internal class Program
    {
        public class MinimumNumberVerticesReachAllNodes
        {
            public IList<int> FindSmallestSetOfVertices(int n, IList<IList<int>> edges)
            {
                bool[] inComingNode = new bool[n];
                foreach (var edge in edges)
                {
                    inComingNode[edge[1]] = true;
                }
                List<int> smallestSetOfVertices = new();
                for (int node = 0; node < n; ++node)
                {
                    if (!inComingNode[node])
                    {
                        smallestSetOfVertices.Add(node);
                    }
                }
                return smallestSetOfVertices.ToArray();
            }
        }

        static void Main(string[] args)
        {
            MinimumNumberVerticesReachAllNodes minimumNumberVerticesReachAllNodes = new();
            foreach(int n in minimumNumberVerticesReachAllNodes.FindSmallestSetOfVertices(6,
                new int[][] { new int[] { 0, 1 }, new int[] { 0, 2 }, new int[] { 2, 5 }, new int[] { 3, 4 }, new int[] { 4, 2 } }))
            {
                Console.Write(n);
            }
            Console.WriteLine();
            foreach (int n in minimumNumberVerticesReachAllNodes.FindSmallestSetOfVertices(5,
                new int[][] { new int[] { 0, 1 }, new int[] { 2, 1 }, new int[] { 3, 1 }, new int[] { 1, 4 }, new int[] { 2, 4 } }))
            {
                Console.Write(n);
            }
            Console.WriteLine();
        }
    }
}