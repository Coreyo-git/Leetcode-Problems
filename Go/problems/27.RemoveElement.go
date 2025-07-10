package problems

func RemoveElement(nums []int, val int) (int, []int) {
	p1 := 0 // Read Pointer
	p2 := 0 // Write Pointer

	// loop read pointer through whole array
	for p1 < len(nums) {
		// if value at read pointer is not equal to the val continue
		if nums[p1] != val {
			// Move first good element to start of sorted section
			nums[p2] = nums[p1]
			// increment to next slot for non val ints
			p2++
		}

		p1++
	}
	// return p2 because it's index the exact count of elements that were kept
	// which is the next spot in the array for a good/ non val element
	return p2, nums
}
