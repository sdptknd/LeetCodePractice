public class Solution {
    public int ShipWithinDays(int[] weights, int days) {
        int minCapacity = 0;
        int maxCapacity = 0;

        foreach(var weight in weights){
            minCapacity = Math.Max(minCapacity, weight);
            maxCapacity += weight;
        }

        // Console.WriteLine(minCapacity);
        // Console.WriteLine(maxCapacity);

        while(minCapacity <= maxCapacity){
            int mid = minCapacity + (maxCapacity - minCapacity) / 2;
            var canShip = CanShip(weights, days, mid);
            // Console.WriteLine($"min: {minCapacity}, max: {maxCapacity}, mid: {mid}, canShip: {canShip}");
            if(canShip) maxCapacity = mid - 1;
            else minCapacity = mid + 1;
        }

        return minCapacity;
    }

    private bool CanShip(int[] weights, int days, int capacity){
        var singleDayShipLoad = 0;
        foreach(var weight in weights){
            if(capacity - singleDayShipLoad < weight){
                days--;
                if(days == 0) return false;
                singleDayShipLoad = 0;
            }
            singleDayShipLoad += weight;
        }

        return true;
    }
}