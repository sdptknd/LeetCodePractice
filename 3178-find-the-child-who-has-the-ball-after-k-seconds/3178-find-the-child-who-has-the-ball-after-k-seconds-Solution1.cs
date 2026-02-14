public class Solution {
    public int NumberOfChild(int n, int k) {
        var lastRoundSeconds = k % ((n - 1) * 2);

        if(lastRoundSeconds <= n - 1){  //left to right
            return lastRoundSeconds;
        }else{  //riht to left
            // var countFromRight = lastRoundSeconds - (n - 1);
            return (2 * (n - 1)) - lastRoundSeconds;
        }
    }
}