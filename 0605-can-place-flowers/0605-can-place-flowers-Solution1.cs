public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        int i = 0, flowers = n;

        while(i < flowerbed.Length){
            if(flowerbed[i] == 1){
                i += 2;
            } else if(i == flowerbed.Length - 1 || flowerbed[i+1] == 0){
                flowers--;
                i += 2;
            } else {
                i++;
            }
        }

        return flowers == 0;
    }
}