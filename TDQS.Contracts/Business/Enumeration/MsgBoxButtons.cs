#region CLR�汾 4.0.30319.239
// MessageBoxButtons ��
// ʱ�䣺2011-11-9 17:54:55
// ���ƣ�MessageBoxButtons
// ��٣���Ϣ��ʾ��ť���
//
// �����ˣ�����ΰ
// ��Ȩ��2011 ��������ʵ�����¼����ɷ����޹�˾ ��Ȩ����
// ��ע��
// ========================================================
//  ����		�޸���		����
#endregion
using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace TDQS.Contracts
{
    /// <summary>
    /// ��Ϣ��ʾ��ť���
    /// </summary>
    public enum MsgBoxButtons : byte
    {
        /// <summary>
        /// ��ȷ����
        /// </summary>
        OK = 1,
        /// <summary>
        /// ��ȷ�����͡�ȡ����
        /// </summary>
        OKCancel = 2,
        /// <summary>
        /// ���ǡ������񡱺͡�ȡ����
        /// </summary>
        YesNoCancel = 3,
        /// <summary>
        /// ���ǡ��͡���
        /// </summary>
        YesNo = 4,
        /// <summary>
        /// ����ֹ���������ԡ��͡����ԡ�
        /// </summary>
        AbortRetryIgnore = 5,
        /// <summary>
        /// �����ԡ��͡�ȡ����
        /// </summary>
        RetryCancel = 6,
        /// <summary>
        /// ���������͡��˳���
        /// </summary>
        ContinueQuit = 7
    }
}