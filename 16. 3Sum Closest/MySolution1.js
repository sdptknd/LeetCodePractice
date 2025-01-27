/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number}
 */
var threeSumClosest = function(nums, target) {
    const sortedArray = [...nums].sort((a,b) => a - b);
    let closest = sortedArray[0] + sortedArray[1] + sortedArray[2];
    for(let i = 0; i < sortedArray.length - 2; i++){
        for(let j = i + 1, k = sortedArray.length - 1; j < k;){
            const sum = sortedArray[i] + sortedArray[j] + sortedArray[k];
            if(sum === target) return sum;
            if(Math.abs(target - sum) < Math.abs(target - closest)) closest = sum;
            if(sum < target) j++;
            else k--;
        }
    }

    return closest;
};