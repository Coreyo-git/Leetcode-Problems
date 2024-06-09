#include <iostream>
#include <vector>
#include <string>

using namespace std;
vector<int> plusOne(vector<int> &digits)
{
	int arraySize = digits.size();

	for(int i = arraySize - 1; i >= 0; i--)
	{
		if(digits[i] == 9)
		{
			digits[i] = 0;
		}
		else
		{
			digits[i]+= 1;
			break;
		}
		if(i == 0)
		{
			digits.insert(digits.begin(), 1);
		}
	}

	return digits;
}

int main()
{
	vector<int> digits1 = {1, 2, 3};	// 124
	vector<int> digits2 = {4, 3, 2, 1}; // 4322
	vector<int> digits3 = {9};			// 10
	
	vector<int> plus1 = plusOne(digits1);
	cout << "1) Incrementing by one gives: ";
	for (int i = 0; i < plus1.size(); i++)
	{
		cout << plus1.at(i) << ' ';
	}

	vector<int> plus2 = plusOne(digits2);
	cout << "\n2) Incrementing by one gives: ";
	for (int i = 0; i < plus2.size(); i++)
	{
		cout << plus2.at(i) << ' ';
	}

	vector<int> plus3 = plusOne(digits3);
	cout << "\n 3) Incrementing by one gives: ";
	for (int i = 0; i < plus3.size(); i++)
	{
		cout << plus3.at(i) << ' ';
	}

	// cout<<"\n2) Length of last word: "<<plusOne(digits2);
	// cout<<"\n3) Length of last word: "<<plusOne(digits3);
}