// Win32Test.cpp : �������̨Ӧ�ó������ڵ㡣
//

#include "stdafx.h"
using namespace TDYH;
using namespace System;

int main()
{
	TDYHDecorator ^tdyh = gcnew TDYHDecorator();
	String ^ result = tdyh->Do("","","");
	char* out = (char*)(void*)System::Runtime::InteropServices::Marshal::StringToHGlobalAnsi(result);
	printf_s("result:%s",out);
	while (1);
}

