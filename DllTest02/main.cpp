/**********************************
mian.h�ļ�
2017-8-23 16:44:19
������Ҫ��java���õķ������÷�����java�ӿ��ڲ���������һ��
Ԥ�������Ŀ���Ǳ�¶�������ⲿ���á�
************************/
#ifdef MYLIBAPI  
#else  
#define  MYLIBAPI  extern "C" __declspec(dllimport)      
#endif  


MYLIBAPI int add(int a, int b); //��Ӻ������� 
MYLIBAPI char* Do(char* connStr, char* dept, char* gchid); //��Ӻ������� #pragma once

/**********************************
main.cpp�ļ�
2017-8-23 16:44:06
ʵ��ͷ�ļ��ڵĺ�����ʵ�ֶ�c#��̬���ӿ�ĵ��á�
���������ֺ�java�ӿ��ڲ�������һ�¡�
�������Ͷ�Ӧ��ϵ���ʣ�http://blog.csdn.net/lovesomnus/article/details/45073343
**********************************************/
#include "stdio.h" 
#include <string>
#include <iostream>
using namespace std;
using namespace Common;
using namespace ComLib;
using namespace std;
using namespace System;
using namespace TDYH;

int add(int a, int b) {
	CommonFunction ^common = gcnew CommonFunction();
	int result = common->Add(a, b);
	return result;
}

char* Do(char* connStr, char* dept, char* gchid)
{
	cout << "this is c++ program\r\n";
	TDYHDecorator ^ tdyhDecorator = gcnew TDYHDecorator();
	String ^resultString = tdyhDecorator->Do();
	char* resultChar = (char*)(void*)System::Runtime::InteropServices::Marshal::StringToHGlobalAnsi(resultString);
	return resultChar;
}