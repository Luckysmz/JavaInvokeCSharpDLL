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
MYLIBAPI int mul(int a, int b); //��Ӻ������� 

#include "stdio.h"    
#include <string>
using namespace Common;
using namespace ComLib;
using namespace std;



int add(int a, int b) {
	CommonFunction ^common = gcnew CommonFunction();
	int result = common->Add(a, b);
	return result+1;
}
int mul(int a, int b)
{
	Utils ^u = gcnew Utils();
	return u->multi(a,b);
}