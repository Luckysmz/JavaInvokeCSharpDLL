#region CLR�汾 4.0.30319.239
// IOutputWindow �ӿ�
// ʱ�䣺2011-11-10 14:04:17
// ���ƣ�IOutputWindow �ӿ�
// ��٣�Output����ToolWindow
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
    /// Output����ToolWindow
    /// </summary>
    public interface IOutputWindow : IToolWindow
    {
        #region ����
        /// <summary>
        /// ���һ��
        /// </summary>
        /// <param name="text"></param>
        void Writeline(string text);
        #endregion // ����

        #region ����
        #endregion // ����

        #region �¼�
        #endregion // �¼�
    }
}

