/**
 * @param {number[]} nums
 * @return {number[]}
 */
var runningSum = function(nums) {
    let a = 0;
    let lst = [];
    for(let i=0;i<nums.length;i++)
        {
            a= nums[i]+a;
            lst.push(a)
        }
    return lst;
};