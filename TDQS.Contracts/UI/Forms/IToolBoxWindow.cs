#region CLR�汾 4.0.30319.239
// IToolBox �ӿ�
// ʱ�䣺2011-11-10 14:04:17
// ���ƣ�IToolBox �ӿ�
// ��٣�ToolBox��ToolWindow
//
// �����ˣ�����
// ��Ȩ��2011 ��������ʵ�����¼����ɷ����޹�˾ ��Ȩ����
// ��ע��
// ========================================================
//  ����		�޸���		����
#endregion
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TDQS.Contracts
{
    /// <summary>
    /// ToolBox��ToolWindow
    /// </summary>
    public interface IToolBoxWindow : IToolWindow
    {
        #region ����
        IToolBox GetNewInstance();
        #endregion // ����

        #region ����
        /// <summary>
        /// ������
        /// </summary>
        IToolBox ToolBox
        {
            get;
            set;
        }
        #endregion // ����

        #region �¼�
        #endregion // �¼�
    }
}

