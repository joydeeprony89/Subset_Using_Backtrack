using System.Collections.Generic;

namespace Subset_Using_Backtrack
{
  class Program
  {
    static void Main(string[] args)
    {
      var nums = new int[] { 1, 2, 3 };
      Program p = new Program();
      p.subsets(nums);
    }

    public IList<IList<int>> subsets(int[] nums)
    {
      var result = new List<IList<int>>();
      Backtrack(nums, result, new List<int>(), 0);
      return result;
    }

    private void Backtrack(int[] nums, List<IList<int>> result, List<int> temp, int start)
    {
      result.Add(new List<int>(temp));
      for (int i = start; i < nums.Length; i++)
      {
        temp.Add(nums[i]);
        Backtrack(nums, result, temp, i + 1);
        temp.RemoveAt(temp.Count - 1);
      }
    }
  }
}
