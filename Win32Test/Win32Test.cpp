// Win32Test.cpp : �������̨Ӧ�ó������ڵ㡣
//

#include "stdafx.h"
#include <iostream>
using namespace std;
using namespace TDYH;
using namespace System;
using namespace LibDemo;

int main()
{
	Function ^ f = gcnew Function();
	printf_s("c# result:%d",f->intTest(3));
	while (1);
}

