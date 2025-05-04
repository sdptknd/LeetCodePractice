public class Solution {
    public int SingleNumber(int[] nums) {
        var extraNum = new HashSet<int>();

        foreach(var num in nums){
            if(extraNum.Contains(num)) extraNum.Remove(num);
            else extraNum.Add(num);
        }

        return extraNum.First();
    }
}