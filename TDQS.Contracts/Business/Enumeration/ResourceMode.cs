#region CLR�汾 4.0.30319.239
// ResourceMode ��
// ʱ�䣺2011-9-29 14:11:36
// ���ƣ�ResourceMode ��
// ��٣���ԴӦ�÷�ʽ
//
// �����ˣ�����
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
    /// ��ԴӦ�÷�ʽ
    /// </summary>
    public enum ResourceMode : byte
    {
        /// <summary>
        /// δ����
        /// </summary>
        Null  = 0,
        /// <summary>
        /// ����
        /// </summary>
        Common = 1,
        /// <summary>
        /// ����
        /// </summary>
        Self = 2,
        /// <summary>
        /// �ⲿ
        /// </summary>
        Ext = 3
    }
}