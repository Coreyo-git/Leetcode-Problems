var assert = require("assert").strict;

/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number}
 */
var searchInsert = function(nums, target) {
    // sets the minimum 
    let start = 0;
    let end = nums.length - 1;
    let guess;
    
    while(start <= end){
        guess = Math.floor(start + (end - start) / 2);

        if(nums[guess] === target) return guess;

        else if(nums[guess] < target) {
            start = guess + 1;
            guess = start;
        }
        else {
            end = guess - 1;
        }
    }
    return guess;
};

let case1 = [1,3,5,6];
let case2 = [1, 3];

try {
    assert.equal(searchInsert(case1, 5), 2);
	assert.equal(searchInsert(case1, 2), 1);
	assert.equal(searchInsert(case1, 7), 4);
	assert.equal(searchInsert(case2, 2), 1);
	assert.equal(searchInsert(case1, 0), 0);
} catch (error) {
    console.log("Error: ", error);
}
