#region CLR�汾 4.0.30319.239
// IElementEx �ӿ�
// ʱ�䣺2012-3-21 13:54:18
// ���ƣ�IElementEx
// ��٣�Ԫ����չ����
//
// �����ˣ�����
// ��Ȩ��Copyright (C) 2012 ��������ʵ�����¼����ɷ����޹�˾ ��Ȩ����
// ��ע��
// ========================================================
//  ����		�޸���		����
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDQS.Contracts
{
    /// <summary>
    /// Ԫ����չ�������ڱ���Ԫ������չ���ԣ���Tool��Command���ơ�
    /// </summary>
    public interface IElementEx
    {
        #region ����
        #endregion // ����

        #region ����
        /// <summary>
        /// ģ�����ID(��Ԫ��ģ�����ID��ͬ)
        /// </summary>
        string ID { get; set; }
        /// <summary>
        /// ������������
        /// </summary>
        string ToolName { get; set; }
        /// <summary>
        /// ���������
        /// </summary>
        string CommandName { get; set; }
        #endregion // ����

        #region �¼�
        #endregion // �¼�
    }
}

