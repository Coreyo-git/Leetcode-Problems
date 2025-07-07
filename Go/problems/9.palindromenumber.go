package problems
import (
	"strconv"
)

// Given an integer x, return true if x is a palindrome, and false otherwise.

func IsPalindrome(x int) bool {
	// convert to string
	xString := strconv.Itoa(x)

	// loop string with 2 iterators start / end and compare
	for i, j := 0, len(xString) - 1; i < j; i, j = i+1, j-1 {
		// if they aren't equal the string can't be reversed as a palindrome
		if xString[i] != xString[j] {
			return false
		}
	}
	return true
}

// Constraints:
//	 	-231 <= x <= 2^31 - 1
