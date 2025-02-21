/**
 * @param {number} x
 * @return {number}
 */
var mySqrt = function(x) {
    let start = 0;
    let end = x;

    while(start <= end){
        const mid = Math.floor(start + (end - start)/2);
        const midSqr = mid * mid;

        // console.log(start, end, mid, midSqr)
        if(midSqr == x) return mid;
        else if(midSqr > x) end = mid - 1;
        else start = mid + 1;
    }

    return end;
};