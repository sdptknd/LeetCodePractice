public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        var allCombos = new List<IList<int>>();

        for(int i = 0; i <= nums.Length; i++) BackTrackAndCombine(0, nums, i, new List<int>(), allCombos);

        return allCombos;
    }

    public void BackTrackAndCombine(int start, int[] nums, int k, IList<int> currCombo, IList<IList<int>> allCombos){
        if(k == 0) {
            allCombos.Add(currCombo.ToList());
            return;
        }

        if(start > nums.Length - k) return;

        currCombo.Add(nums[start]);
        BackTrackAndCombine(start+1, nums, k-1, currCombo, allCombos);
        currCombo.RemoveAt(currCombo.Count - 1);
        BackTrackAndCombine(start+1, nums, k, currCombo, allCombos);
    }
}