/**********************************
main.cpp�ļ�
2017-8-23 16:44:06
ʵ��ͷ�ļ��ڵĺ�����ʵ�ֶ�c#��̬���ӿ�ĵ��á�
���������ֺ�java�ӿ��ڲ�������һ�¡�
�������Ͷ�Ӧ��ϵ���ʣ�http://blog.csdn.net/lovesomnus/article/details/45073343
**********************************************/
#include "stdio.h"   
using namespace TDYH;
using namespace System;
char* Do(char* connStr, char* dept, char* gchid)
{
	TDYHDecorator ^ tdyhDecorator = gcnew TDYHDecorator();
	String ^resultString = tdyhDecorator->Do();
	char* resultChar = (char*)(void*)System::Runtime::InteropServices::Marshal::StringToHGlobalAnsi(resultString);
	return resultChar;
}