const { formatTestErrorMessage, isArrayEqual } = require("../TestUtils");

// Given an integer n, return an array ans of length n + 1
// such that for each i (0 <= i <= n), ans[i]
// is the number of 1's in the binary representation of i.

/**
 * @param {number} n
 * @return {number[]}
 */
var countBits = function (n) {
    // Initialize array of length n+1 with all elements set to 0
    let ans = new Array(n + 1).fill(0);
    
	// used to find the most significant bit's position
    let offset = 1; // highest ^2 number

	for (let i = 1; i <= n; i++) {
        // If i is a power of 2, update offset to i
        if (offset * 2 === i) {
            offset = i;
		}
		// Calculate the number of 1's
		// i - offset flips the MSB to 0
        ans[i] = 1 + ans[i - offset];
    }

    return ans;
};

// Example 1:

// Input: n = 2
// Output: [0,1,1]
// Explanation:
// 0 --> 0
// 1 --> 1
// 2 --> 10

let test1Input = 2;
let test1Expected = [0, 1, 1];
let test1Output = countBits(test1Input);

if (!isArrayEqual(test1Expected, test1Output)) {
    console.log(formatTestErrorMessage(1, test1Expected, test1Output));
}

// Example 2:

// Input: n = 5
// Output: [0,1,1,2,1,2]
// Explanation:
// 0 --> 0
// 1 --> 1
// 2 --> 10
// 3 --> 11
// 4 --> 100
// 5 --> 101

let test2Input = 5;
let test2Expected = [0, 1, 1, 2, 1, 2];
let test2Output = countBits(test2Input);

if (!isArrayEqual(test2Expected, test2Output)) {
    console.log(formatTestErrorMessage(2, test2Expected, test2Output));
}
