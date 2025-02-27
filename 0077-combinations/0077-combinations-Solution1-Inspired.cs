public class Solution {
    public IList<IList<int>> Combine(int n, int k) {
        var result = new List<IList<int>>();
        BackTrackAndCombine(1, n, k, new List<int>(), result);
        return result;
    }

    public void BackTrackAndCombine(int start, int end, int k, IList<int> currCombo, IList<IList<int>> allCombos){
        // Console.WriteLine($"start: {start}, end: {end}, k: {k}");
        if(k == 0) {
            allCombos.Add(currCombo.ToList());
            return;
        }

        for(int i = start; i <= end - k + 1; i++){
            currCombo.Add(i);
            BackTrackAndCombine(i+1, end, k-1, currCombo, allCombos);
            currCombo.RemoveAt(currCombo.Count - 1);
        }
    }
}