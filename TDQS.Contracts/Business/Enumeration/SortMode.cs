#region CLR�汾 4.0.30319.239
// SortMode �� 
// ʱ�䣺2011/9/25 11:49:34
// ���ƣ�SortMode ��
// ��٣�����׼��
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
    /// ����׼��
    /// </summary>
    public enum SortMode : byte
    {
        /// <summary>
        /// Ĭ��
        /// </summary>
        Null = 1,
        /// <summary>
        /// ����
        /// </summary>
        ASC = 2,
        /// <summary>
        /// ����
        /// </summary>
        DESC = 3
    }
}