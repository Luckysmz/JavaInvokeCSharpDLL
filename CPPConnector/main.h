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


MYLIBAPI char* Do(char* connStr,char* dept,char* gchid); //��Ӻ������� #pragma once
