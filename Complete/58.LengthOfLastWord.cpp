#include <iostream>
#include <string>

using namespace std;
int lengthOfLastWord(string s)
{
	// Loop through from the end to the start
	// when not whitespace start counting
	// when whitespace stop counting

	int sLength = s.length() - 1;
	int lengthOfLastWord = 0;
	bool wordFound = false;

	for (int i = sLength; i >= 0; i--)
	{
		if(s[i] != ' ')
		{
			wordFound = true;
			lengthOfLastWord++;
		}
		else if(wordFound == true)
		{
			break;
		}
	}
	return lengthOfLastWord;
}

int main()
{

	string example1 = "Hello World";
	string example2 = "   fly me   to   the moon  ";
	string example3 = "luffy is still joyboy";
	string example4 = "a";

	cout<<"1) Length of last word: "<<lengthOfLastWord(example1);
	cout<<"\n2) Length of last word: "<<lengthOfLastWord(example2);
	cout<<"\n3) Length of last word: "<<lengthOfLastWord(example3);
	cout<<"\n4) Length of last word: "<<lengthOfLastWord(example4);
}