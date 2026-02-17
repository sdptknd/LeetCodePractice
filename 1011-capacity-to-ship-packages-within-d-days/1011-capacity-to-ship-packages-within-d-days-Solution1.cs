public class Solution {
    public int ShipWithinDays(int[] weights, int days) {
        int max = 1, sum = 0;

        foreach(var weight in weights){
            max = Math.Max(weight, max);
            sum += weight;
        }

        int left = max, right = sum;

        while(left <= right){
            var middle = left + ((right - left) / 2);
            if(PossibleToShip(weights, middle, days)) right = middle - 1;
            else left = middle + 1;
        }

        return left;
    }

    private bool PossibleToShip(int[] weights, int capacity, int days){
        int currLoad = 0, requiredDays = 0;

        foreach(var weight in weights){
            currLoad += weight;
            if(currLoad > capacity){
                requiredDays++;
                currLoad = weight;
            }
        }

        if(currLoad > 0) requiredDays++;

        Console.WriteLine($"capacity: {capacity}, requiredDays: {requiredDays}");
        return requiredDays <= days;
    }
}