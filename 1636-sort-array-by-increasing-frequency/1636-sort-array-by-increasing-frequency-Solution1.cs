public class Solution {
    public int[] FrequencySort(int[] nums) {
        var occurances = new Dictionary<int, int>();

        foreach(var num in nums) occurances[num] = occurances.GetValueOrDefault(num, 0) + 1;

        var occuranceSorted = occurances.GroupBy(kv => kv.Value, kv => kv.Key).OrderBy(g => g.Key);

        var ans = new List<int>();

        foreach(var group in occuranceSorted){
            foreach(var num in group.OrderDescending()) 
                ans.AddRange(Enumerable.Repeat(num, group.Key));
        }

        return ans.ToArray();
    }
}