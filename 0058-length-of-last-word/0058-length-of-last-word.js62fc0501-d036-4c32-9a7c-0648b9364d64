/**
 * @param {string} s
 * @return {number}
 */
var lengthOfLastWord = function(s) {
    const trimmed = s.trimRight();

    let count = 0;
    for(let i = trimmed.length - 1; i >= 0 && trimmed[i] != ' '; i--) count++;

    return count;
};