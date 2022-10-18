namespace Solutions._1700_1800
{
    public class _1791_FindCenterofStarGraph
    {
        public int FindCenter(int[][] edges)
        {
            if (edges[0][0] == edges[1][0] || edges[0][0] == edges[1][1])
            {
                return edges[0][0];
            }

            return edges[0][1];
        }
    }
}