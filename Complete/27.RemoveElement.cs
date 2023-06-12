public class RemoveElement
{
	public int RemoveElement(int[] nums, int val) {
        int endPointer = nums.Length;

        // return 0 value array if 1 num and it's equal to val
        if(endPointer == 1 && nums[0] == val) {nums[0] = 0; return 0;};

		for (int i = nums.Length - 1; i >= 0; i--)
		{
			if (nums[i] == val)
			{
				endPointer--;
				nums[i] = nums[endPointer];			
			}
		}
		return endPointer;
    }
}