//-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+
//	mian.h�ļ�
//	2017-8-23 16:44:19
//	������Ҫ��java���õķ������÷�����java�ӿ��ڲ���������һ��
//	Ԥ�������Ŀ���Ǳ�¶�������ⲿ���á�
//-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+
/***********************��������************************************************/
#ifdef MYLIBAPI  
#else  
#define  MYLIBAPI  extern "C" __declspec(dllimport)      
#endif 


MYLIBAPI char* Do(char* connStr, char* dept, char* gchid);
MYLIBAPI int add(int a, int b);

//-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+
//	main.cpp�ļ�
//	2017-8-23 16:44:06
//	ʵ��ͷ�ļ��ڵĺ�����ʵ�ֶ�c#��̬���ӿ�ĵ��á�
//	���������ֺ�java�ӿ��ڲ�������һ�¡�
//	�������Ͷ�Ӧ��ϵ���ʣ�http://blog.csdn.net/lovesomnus/article/details/45073343
//-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+
#include "stdio.h" 
#include <string>
#include <iostream>
using namespace std;
using namespace System;
using namespace TDYH;
/*****************************************������Start******************************************************************/

char* Do(char* connStr, char* dept, char* gchid)
{
	TDYHDecorator ^tdyh;
	tdyh =gcnew TDYHDecorator();
	String ^connString = gcnew String(connStr);
	String ^deptString = gcnew String(dept);
	String ^gchidString = gcnew String(gchid);
	String ^ result = tdyh->Do(connString,deptString,gchidString);
	char* out = (char*)(void*)System::Runtime::InteropServices::Marshal::StringToHGlobalAnsi(result);
	return out;
}

int add(int a, int b)
{
	return a + b;
}
/*****************************************������End******************************************************************/
