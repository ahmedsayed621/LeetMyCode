/**
 * @param {number[]} nums
 * @return {number}
 */
var removeDuplicates = function(nums) {
    for(let i=0; i < nums.length - 1;){
      // console.log(nums , i)
     if(nums[i] == nums[i+1] ){
         nums.splice(i,1)
     } else{
         i++
     }
  }  
    console.log(nums)
};