public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        var sorted = nums.Order().ToList();
        var ans = new List<IList<int>>();

        for(var l = 0; l < sorted.Count - 2; l++){
            if(l > 0 && sorted[l-1] == sorted[l]) continue;

            int m = l+1, r = sorted.Count - 1;

            while(m < r){
                long sum = sorted[l] + sorted[m] + sorted[r];
                if(sum == 0){
                    ans.Add(new List<int>{sorted[l], sorted[m], sorted[r]});
                    m++;
                    r--;
                    while(m < sorted.Count && sorted[m-1] == sorted[m]) m++;
                    while(r > 0 && sorted[r+1] == sorted[r]) r--;
                } else if(sum < 0){
                    m++;
                } else {
                    r--;
                }
            }
        }

        return ans;
    }
}