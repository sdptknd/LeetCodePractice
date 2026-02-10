public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        var sorted = nums.Order().ToList();
        Console.WriteLine(string.Join(',',sorted));
        var collection = new List<IList<int>>();

        for(int i = 0; i <= sorted.Count - 3; i++){
            if(i > 0 && sorted[i-1] == sorted[i]) continue;

            int j = i + 1, k = sorted.Count - 1;

            while(j < k){
                long sum = (long) sorted[i] + sorted[j] + sorted[k];
                if(sum == 0){
                    collection.Add(new List<int> {sorted[i], sorted[j], sorted[k]});
                    j++;
                    k--;
                    while(j < sorted.Count && sorted[j] == sorted[j-1]) j++;
                    while(k > 0 && sorted[k] == sorted[k+1]) k--;
                } else if(sum < 0){
                    j++;
                } else {
                    k--;
                }
            }
        }
        return collection;
    }
}


// -1 0 1 2 -1 -4
// -4 -1 -1 0 1 2
//. 0. 1. 2.3 4 5
