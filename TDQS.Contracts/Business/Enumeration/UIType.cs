#region CLR�汾 4.0.30319.269
// UIType ��
// ʱ�䣺2012-5-23 17:48:14
// ���ƣ�UIType
// ��٣���������
//
// �����ˣ�����
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
    /// ��������
    /// </summary>
    public enum UIType : byte
    {
        /// <summary>
        /// ���˵�
        /// </summary>
        MainMenu,
        /// <summary>
        /// ������
        /// </summary>
        Toolbar,
        /// <summary>
        /// �����Ĳ˵�
        /// </summary>
        ContextMenu
    }
}