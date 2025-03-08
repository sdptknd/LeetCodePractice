public class Solution {
    public IList<IList<int>> SubsetsWithDup(int[] nums) {
        var sortedNums = nums.ToList();
        sortedNums.Sort();
        var result = new List<IList<int>>();
        for(int i = 0; i <= sortedNums.Count; i++)
            UniqueSubset(sortedNums, 0, i, new List<int>(), result);
        return result;
    }

    public void UniqueSubset(IList<int> nums, int currIndx, int length, IList<int> curr, IList<IList<int>> result){
        if(0 == length) {
            result.Add(curr.ToList());
            return;
        }

        if(currIndx > nums.Count - length) return;
        curr.Add(nums[currIndx]);
        UniqueSubset(nums, currIndx+1, length-1, curr, result);
        curr.RemoveAt(curr.Count-1);
        var nextIndx = currIndx + 1;
        while(nextIndx < nums.Count && nums[nextIndx] == nums[nextIndx-1]) nextIndx++;
        UniqueSubset(nums, nextIndx, length, curr, result);
    }
}