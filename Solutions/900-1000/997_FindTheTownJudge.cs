using System.Collections.Generic;

namespace Solutions._900_1000
{
    public class _997_FindTheTownJudge
    {
        public int FindJudge(int n, int[][] trust)
        {
            if (n == 1)
            {
                return 1;
            }
            if (trust.Length == 0)
            {
                return -1;
            }

            List<int> possibleJudges = new List<int>();
            possibleJudges.Add(trust[0][1]);

            List<int> trustGivers = new List<int>();
            trustGivers.Add(trust[0][0]);




            for (int i = 1; i < trust.Length; i++)
            {
                if (!possibleJudges.Contains(trust[i][1]))
                {
                    possibleJudges.Add(trust[i][1]);
                }

                if (!trustGivers.Contains(trust[i][0]))
                {
                    trustGivers.Add(trust[i][0]);
                }
            }

            for (int j = 0; j < possibleJudges.Count; j++)
            {
                for (int i = 0; i < trustGivers.Count; i++)
                {
                    if (possibleJudges.Contains(trustGivers[i]))
                    {
                        possibleJudges.Remove(trustGivers[i]);
                        j--;
                    }
                }
            }

            int judge = -1;
            int judgesCount = 0;
            int trustedCount = 0;

            for (int j = 0; j < possibleJudges.Count; j++)
            {
                for (int i = 0; i < trust.Length; i++)
                {
                    if (trust[i][1] == possibleJudges[j])
                    {
                        trustedCount++;
                    }
                }
                if (trustedCount == n - 1)
                {
                    judge = possibleJudges[j];
                    judgesCount++;
                }
                trustedCount = 0;
            }


            if (judgesCount == 1)
            {
                return judge;
            }
            else
            {
                return -1;
            }
        }
    }
}