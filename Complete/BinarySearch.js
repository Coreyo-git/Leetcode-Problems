var assert = require("assert").strict;

/* Returns either the index of the location in the array,
  or -1 if the array did not contain the targetValue */
var doSearch = function (array, targetValue) {
    var min = 0;
    var max = array.length - 1;
    var guess;

    // console.log(`\n\n\n START`)
    // infinite loop until guess equals targetValue
    while (min <= max) {
        // sum of min + max divide 2 for average == guess index
        guess = Math.floor((min + max) / 2);

        if (array[guess] === targetValue) {
            // console.log(`FINISH \n\n\n`)
            return guess;
        }
        // if the guess is LOWER than the target value
        // set min == guess + 1
        else if (array[guess] < targetValue) {
            min = guess + 1;
            // console.log(
            //     `Guess was lower than targetValue. \nMin increased too: ${min}, value was: ${primes[guess]}`
            // );
        }
        // if the guess is HIGHER than the target value
        // set max == guess - 1
        else {
            max = guess - 1;
            // console.log(
            //     `Guess was higher than targetValue. \nMax decreased too: ${max}, value was: ${primes[guess]}`
            // );
        }
        // console.log(`Current Min: ${min} | Current Max: ${max}`);
    }
};

var primes = [
    2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71,
    73, 79, 83, 89, 97,
];


var result = doSearch(primes, 73);
console.log("Found prime at index " + result);

try {
    assert.equal(doSearch(primes, 73), 20);
} catch (error) {
    console.log("Error: ", error);
}
