public class Solution {
    public IList<int> GrayCode(int n) {
        if(n == 1) return new List<int> { 0, 1 };

        var stageResult = GrayCode(n-1);
        for(int i = stageResult.Count - 1; i >= 0; i--)
            stageResult.Add(stageResult[i] | (int)Math.Pow(2, n-1));

        return stageResult;
    }

    // public void GrayCodeTrack(int n, IList<int> curr, IList<int> result){
    //     if(n == 1) r
    // }
}