public class Solution {
    public IList<IList<int>> FourSum(int[] nums, int target) {
        var sortedNums = nums.ToList();
        sortedNums.Sort();
        var quadruplets = new List<IList<int>>();

        for(int i = 0; i < sortedNums.Count - 3; i ++){
            if(i > 0 && sortedNums[i] == sortedNums[i-1]) continue;
            for(int j = i+1; j < sortedNums.Count - 2; j++){
                if(j > i+1 && sortedNums[j] == sortedNums[j-1]) continue;
                var targetSum = (long)target - sortedNums[i] - sortedNums[j];
                for(int k = j+1, l = sortedNums.Count - 1; k < l;){
                    var sum = (long)sortedNums[k] + sortedNums[l];
                    if(sum == targetSum){
                        quadruplets.Add(new List<int>{
                            sortedNums[i], sortedNums[j], sortedNums[k], sortedNums[l]
                        });
                        do{ k++; } while(k < l && sortedNums[k] == sortedNums[k-1]);
                        do{ l--; } while(k < l && sortedNums[l] == sortedNums[l+1]);
                    }else if(sum < targetSum) k++;
                    else l--;
                }
            }
        }
        return quadruplets;
    }
}