/**
 * @param {string} digits
 * @return {string[]}
 */
var letterCombinations = function(digits) {
    //Global Result
    const result = [];
    if(digits.length===0) return [];
    //hash map
    const alpha = {
        '2': 'abc',
        '3':'def',
        '4':'ghi',
        '5':'jkl',
        '6':'mno',
        '7':'pqrs',
        '8':'tuv',
        '9':'wxyz'
    }
    
    //dfs recrsive helper 
    const dfs = (i , digits , slate)=>
    {
        if(i===digits.length)
            {
                //base case
                result.push(slate.join(''));
                return;
            }
        //dfs recrsive case
        let chars = alpha[digits[i]];
        for(let char of chars){
            slate.push(char);
            dfs(i+1,digits,slate);
            slate.pop();
        }
    }
    
    dfs(0,digits , [])
    
    return result;
};