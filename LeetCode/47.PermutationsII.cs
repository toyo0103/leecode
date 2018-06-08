using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public partial class Solution
    {
        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            var Result = new List<IList<int>>();

            if (nums.Length == 0)
                return Result;

            Recursive(new List<int>(nums), 0 , Result);

            return Result;
        }

        private void Recursive(List<int> nums, int start, List<IList<int>> result)
        {
            result.Add(nums);
            for (int i = start; i < nums.Count; i++)
            {
                HashSet<int> used = new HashSet<int>();
                if (i == nums.Count - 1)
                {
                    continue;
                }


                for (int j = i + 1; j < nums.Count; j++)
                {
                    if (nums[i] != nums[j])
                    {
                        if (used.Contains(nums[j]))
                        {
                            continue;
                        }
                        else
                        {
                            used.Add(nums[j]);
                        }

                        var SplitLeaft = new List<int>(nums);
                        Swap(SplitLeaft, i, j);
                        Recursive(SplitLeaft, i + 1, result);
                    }
                }
            }
        }

        private void Swap(List<int> nums, int index1,int index2)
        {
            var Temp = nums[index1];
            nums[index1] = nums[index2];
            nums[index2] = Temp;
        }
    }
}
