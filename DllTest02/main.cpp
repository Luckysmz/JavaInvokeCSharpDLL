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







MYLIBAPI char* Get(char* str);

MYLIBAPI int OutTest();
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
	return "this is c++ tip.";
	cout << "this is c++ program" << endl;

	TDYHDecorator ^tdyh;
	tdyh =gcnew TDYHDecorator();
	String ^connString = gcnew String(connStr);
	String ^deptString = gcnew String(dept);
	String ^gchidString = gcnew String(gchid);
	String ^ result = tdyh->Do(connString,deptString,gchidString);
	char* out = (char*)(void*)System::Runtime::InteropServices::Marshal::StringToHGlobalAnsi(result);

	//String ^resultString = tdyhDecorator->Do();
	//char* resultChar = (char*)(void*)System::Runtime::InteropServices::Marshal::StringToHGlobalAnsi(resultString);
	//char * resultChar = (char*)(void*)System::Runtime::InteropServices::Marshal::StringToHGlobalAnsi(connString);
	return out;//"this is win32 c++ test result.\r\n";
}

/*****************************************������End******************************************************************/
