#region CLR�汾 4.0.30319.17379
// ReadOnlyStatus ö��
// ʱ�䣺2012/06/06 9:42:58
// ���ƣ�ReadOnlyStatus
// ��٣����Կ�ֻ������
//
// �����ˣ�������
// ��Ȩ��Copyright (C) 2012 ��������ʵ�����¼����ɷ����޹�˾ ��Ȩ����
// ��ע��
// ========================================================
//  ����		�޸���		����
#endregion
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDQS.Contracts
{
    /// <summary>
    /// ֻ��״̬
    /// </summary>
    public enum ReadOnlyStatus
    {
        /// <summary>
        /// ��
        /// </summary>
        On = 1,
        /// <summary>
        /// ��
        /// </summary>
        Off = 0,
        /// <summary>
        /// �Զ���
        /// </summary>
        Custom = 2
    }
}