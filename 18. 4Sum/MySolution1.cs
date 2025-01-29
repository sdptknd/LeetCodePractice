public class Solution {
    public IList<IList<int>> FourSum(int[] nums, int target) {
        var sortedNums = nums.ToList();
        sortedNums.Sort();
        var quadruplets = new List<IList<int>>();

        for(int i = 0; i < sortedNums.Count - 3; i ++){
            if(i > 0 && sortedNums[i] == sortedNums[i-1]) continue;
            for(int j = sortedNums.Count - 1; i < j - 2; j--){
                if(j < sortedNums.Count - 1 && sortedNums[j] == sortedNums[j+1]) continue;
                for(int k = i + 1, l = j - 1; k < l;){
                    var sum = (long)sortedNums[i] + sortedNums[j] + sortedNums[k] + sortedNums[l];
                    if(sum == target){
                        quadruplets.Add(new List<int>{
                            sortedNums[i], sortedNums[j], sortedNums[k], sortedNums[l]
                        });
                        do{ k++; }while(sortedNums[k] == sortedNums[k-1] && k < l);
                    }else if(sum < target) k++;
                    else l--;
                }
            }
        }
        return quadruplets;
    }
}