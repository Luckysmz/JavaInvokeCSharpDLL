#region CLR�汾 4.0.30319.239
// IDockWindow �ӿ�
// ʱ�䣺2011-12-6 9:34:26
// ���ƣ�IDockWindow
// ��٣�ͣ����
//
// �����ˣ�����
// ��Ȩ��2011 ��������ʵ�����¼����ɷ����޹�˾ ��Ȩ����
// ��ע��
// ========================================================
//  ����		�޸���		����
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WinFormsUI.Docking;

namespace TDQS.Contracts
{
    /// <summary>
    /// ͣ�����ӿ�
    /// </summary>
    public interface IDockWindow
    {
        #region ����

        /// <summary>
        /// ����ͣ����
        /// </summary>
        void Activate();

        #endregion // ����

        #region ����

        /// <summary>
        /// Dockʵ��
        /// </summary>
        DockContent Instance
        {
            get;
        }

        /// <summary>
        /// ��Դ����
        /// </summary>
        string PrpResourceName
        {
            get;
            set;
        }

        /// <summary>
        /// ��Դģʽ
        /// </summary>
        ResourceMode PrpResourceMode
        {
            get;
            set;
        }

        /// <summary>
        /// ͣ�����Ƿ񼤻�
        /// </summary>
        bool IsActivated
        {
            get;
        }

        #endregion // ����

        #region �¼�
        #endregion // �¼�
    }
}

