#include <iostream>
#include <vector>
#include <string>

using namespace std;
string addBinary(string a, string b)
{
	string res = "";
    int i = a.length() - 1, j = b.length() - 1;
    int carry = 0;

    while (i >= 0 || j >= 0) {
        int sum = carry;
        if (i >= 0) sum += a[i--] - '0';
        if (j >= 0) sum += b[j--] - '0';
        res = char(sum % 2 + '0') + res;
        carry = sum / 2;
    }

    if (carry > 0) res = '1' + res;

    return res;
}

int main()
{
	string bin1 = "11";
	string bin2 = "1"; // should be 100
	cout << "The Addtion of 11 and 1= " << addBinary(bin1, bin2);

	string bin3 = "1010";
	string bin4 = "1011"; // should be 10101

	cout << "\nThe Addtion of 1010 and 1= " << addBinary(bin3, bin4);
}