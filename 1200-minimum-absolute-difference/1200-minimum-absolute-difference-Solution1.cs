public class Solution {
    public IList<IList<int>> MinimumAbsDifference(int[] arr) {
        var sorted = arr.Order().ToArray();
        var minDiff = int.MaxValue;
        var answer = new List<IList<int>>();

        for(int i = 1; i < sorted.Length; i++){
            var currDiff = sorted[i] - sorted[i-1];

            if(currDiff == minDiff){
                answer.Add(new List<int> {sorted[i-1], sorted[i]});
            }
            
            if(currDiff < minDiff){
                minDiff = currDiff;
                answer.Clear();
                answer.Add(new List<int> {sorted[i-1], sorted[i]});
            }
        }

        return answer;
    }
}