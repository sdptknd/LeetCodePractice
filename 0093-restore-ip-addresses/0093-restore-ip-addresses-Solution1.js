/**
 * @param {string} s
 * @return {string[]}
 */
var restoreIpAddresses = function(s) {
    const result = [];
    backTrack(s, 0, 4, [], result);
    return result;
};

const backTrack = (s, indx, remaining, curr, result) => {
    if(remaining == 0){
        if(indx == s.length) result.push(curr.join('.'));
        return;
    }

    if(indx >= s.length) return;

    let part = s[indx];
    curr.push(part);
    backTrack(s, indx+1, remaining-1, curr, result);
    curr.pop();

    if(part == "0" || indx == s.length-1) return;

    part += s[indx+1];
    curr.push(part);
    backTrack(s, indx+2, remaining-1, curr, result);
    curr.pop();

    if(indx == s.length-2 || part > 25 || (part === "25" && s[indx+2] > 5)) return;

    part += s[indx+2];
    curr.push(part);
    backTrack(s, indx+3, remaining-1, curr, result);
    curr.pop();
}