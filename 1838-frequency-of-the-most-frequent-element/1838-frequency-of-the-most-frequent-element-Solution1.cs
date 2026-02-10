public class Solution {
    public int MaxFrequency(int[] nums, int k) {
        long currSum = 0; 
        int maxRange = 0;
        var sorted = nums.Order().ToList();

        for(int l = 0, r = 0; r < sorted.Count; r++){
            currSum += sorted[r];

            while(currSum + k < ((long)sorted[r] * (r - l + 1))){
                currSum -= sorted[l];
                l++;
            }

            maxRange = Math.Max(maxRange, r - l + 1);
        }

        return maxRange;
    }
}