public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        int currPos = 0;

        while(currPos < flowerbed.Length && n > 0){
            var next = currPos < (flowerbed.Length - 1) ? flowerbed[currPos+1] : 0;

            if(next == 0 && flowerbed[currPos] == 0) {
                n--;
                currPos += 2;
            }else if(flowerbed[currPos] == 1) currPos += 2;
            else currPos += 1;
        }

        return n <= 0;
    }
}