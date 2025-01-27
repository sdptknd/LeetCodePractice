public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        var sortedNums = nums.ToList();
        sortedNums.Sort();
        var closest = sortedNums[0] + sortedNums[1] + sortedNums[2];

        for(int i = 0; i < sortedNums.Count - 2; i++){
            for(int j = i + 1, k = sortedNums.Count - 1; j < k;){
                var sum = sortedNums[i] + sortedNums[j] + sortedNums[k];
                if(sum == target) return sum;
                if(Math.Abs(target - sum) < Math.Abs(target - closest)) closest = sum;
                if(sum < target) j++;
                else k--;
            }
        }

        return closest;
    }
}