public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        long totalEffectiveGas = 0;
        long currEffectiveGas = 0;
        var i = 0;
        var ithEffectiveGas = gas[i] - cost[i];

        for(var j = 0; j < gas.Length; j++){
            var effectiveGas = gas[j] - cost[j];
            totalEffectiveGas += effectiveGas;
            currEffectiveGas += effectiveGas;

            if(ithEffectiveGas < 0 || currEffectiveGas < 0){
                while(i < j){
                    currEffectiveGas -= ithEffectiveGas;
                    if(ithEffectiveGas >= 0 && currEffectiveGas >= 0) break;
                    i++;
                    ithEffectiveGas = gas[i] - cost[i];
                }
            }
            // Console.WriteLine($"i: {i}, j: {j}, effectiveGas: {effectiveGas}, currEffectiveGas: {currEffectiveGas}, totalEffectiveGas: {totalEffectiveGas}");
        }

        if(totalEffectiveGas < 0) return -1;

        return i;
    }
}