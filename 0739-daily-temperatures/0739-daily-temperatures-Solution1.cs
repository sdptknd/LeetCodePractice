public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var answer = new int[temperatures.Length];
        var decreasingStack = new Stack<int>();
        for(var indx = temperatures.Length - 1; indx >= 0; indx--){
            // Console.WriteLine($"indx: {indx}, stack: {string.Join(',', decreasingStack)}");
            while(decreasingStack.Count > 0 && temperatures[decreasingStack.Peek()] <= temperatures[indx]){
                decreasingStack.Pop();
            }
            var warmerDayWait = 0;
            if(decreasingStack.Count > 0) warmerDayWait = decreasingStack.Peek() - indx;
            answer[indx] = warmerDayWait;
            decreasingStack.Push(indx);
        }
        return answer;
    }
}