using System.Collections.Generic;

namespace Solutions._900_1000
{
    public class _997_FindTheTownJudge
    {
        public int FindJudge(int n, int[][] trust)
        {

            List<int> possibleJudges = new List<int>();
            possibleJudges.Add(trust[0][1]);

            int trustedCount = 0;
            int judge = 0;
            int judgesCount = 0;

            for (int i = 1; i < trust.Length; i++)
            {
                if (!possibleJudges.Contains(trust[i][1]))
                {
                    possibleJudges.Add(trust[i][1]);
                }
            }

            for (int j = 0; j < possibleJudges.Count; j++)
            {
                for (int i = 0; i < trust.Length; i++)
                {

                    if (trust[i][0] == possibleJudges[j] && j != possibleJudges.Count-1)
                    {
                        i = 0;
                        j++;
                        trustedCount = 0;
                    }
                    else if (trust[i][1] == possibleJudges[j])
                        trustedCount++;
                    if (i == trust.Length-1 && trustedCount == n - 1)
                    {
                        judge = possibleJudges[j];
                        judgesCount++;
                        trustedCount = 0;
                    }
                }

                
            }

            if (judgesCount == 1)
            {
                return judge;
            }
            else
                return -1;


            /*for (int j = 0; j < possibleJudges.Count; j++)
            {
                for (int i = 0; i < trust.Length; i++)
                {

                    if (trust[i][0] == possibleJudges[j])
                    {
                        possibleJudges.Remove(possibleJudges[j]);
                        if (possibleJudges.Count == 0)
                            return -1;
                    }
                    else if (trust[i][1] == possibleJudges[j])
                        trustedCount++;
                }

                if (trustedCount != n - 1)
                {
                    possibleJudges.Remove(possibleJudges[j]);
                    if (possibleJudges.Count == 0)
                        return -1;
                }
            }

            if (possibleJudges.Count == 1)
            {
                return possibleJudges[0];
            }
            else
                return -1;
        }*/

        }
    }
}