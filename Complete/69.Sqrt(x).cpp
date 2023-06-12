#include <iostream>
#include <vector>
#include <string>

using namespace std;

int MySqrt(int x)
{
	// if x is 0 or negative return 0
	if (x <= 0)
	{
		return 0;
	}

	// start binary search
	int left = 1;
	int right = x;

	// begin bs loop
	while (left <= right)
	{
		// set middle
		int mid = left + (right - left) / 2;

		if (mid == x / mid)
		{
			return mid;
		}
		else if (mid > x / mid)
		{
			right = mid - 1;
		}
		else
		{
			left = mid + 1;
		}
	}
	return right;
}

int main()
{
}