public class Solution {
    public int SingleNumber(int[] nums) {
        var visitLog = new Dictionary<int, int>();

        foreach(var num in nums){
            if(visitLog.TryGetValue(num, out var count)){
                if(count == 2) visitLog.Remove(num);
                else visitLog[num] = 2;
            }else{
                visitLog[num] = 1;
            }
        }

        return visitLog.First().Key;
    }
}