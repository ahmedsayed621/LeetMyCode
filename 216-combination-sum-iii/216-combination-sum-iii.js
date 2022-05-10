/**
 * @param {number} k
 * @param {number} n
 * @return {number[][]}
 */
var combinationSum3 = function(k, n) {
    const result = [];
    backtrack([], 1, 0)
    return result;
    
    function backtrack(curr, idx, sum) {
        if (curr.length === k) {
            if (sum === n) result.push(curr.slice());
            return;
        }
        
        for (let i = idx; i < 10; i++) {
            curr.push(i);
            backtrack(curr, i+1, sum+i)
            curr.pop();
        }
    }
};