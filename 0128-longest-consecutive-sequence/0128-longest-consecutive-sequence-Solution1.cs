public class Solution {
    public int LongestConsecutive(int[] nums) {
        var ordered = nums.Order().ToList();

        // Console.WriteLine($"{string.Join(',', ordered)}");

        var maxSequence = 0;
        var currSequence = 1;

        for(var i = 1; i < ordered.Count; i++){
            if(ordered[i] == ordered[i-1]) continue;
            if(ordered[i] - ordered[i-1] == 1){
                // Console.WriteLine($"prev: {ordered[i-1]} curr: {ordered[i]} curr: {currSequence}");
                currSequence++;
            }else{
                maxSequence = Math.Max(maxSequence, currSequence);
                currSequence = 1;
            }
        }
        maxSequence = Math.Max(maxSequence, currSequence);

        return maxSequence;
    }
}