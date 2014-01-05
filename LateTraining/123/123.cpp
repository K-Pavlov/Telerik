// 123.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>
using namespace std;
int _tmain(int argc, _TCHAR* argv[])
{
	string in1;
	string in2;
	string in3;
	string in4;
	bool in1Valid = 1,in2Valid = 1,in3Valid = 1,in4Valid = 1;
	char lastChar = 'k';
	cin>>in1;
	for(char& c : in1)
	{
		if(c == '(')
		{
			if(lastChar == '(')
			{
				in1Valid = 0;
				break;
			}
		}
		if(c == '[')
		{
			if(lastChar == '(')
			{
				in1Valid = 0;
				break;
			}
		}
		if(c == ')')
		{
			if(lastChar == '[')
			{
				in1Valid = 0;
				break;
			}
		}
		if(c == ']')
		{
			if(lastChar == '(')
			{
				in1Valid = 0;
				break;
			}
		}
		lastChar = c;
	}
	cout<<in1Valid<<endl;
	return 0;
}

