#region CLR�汾 4.0.30319.239
// IVisionMng �ӿ�
// ʱ�䣺2011/12/7 15:58:12
// ���ƣ���MEF��ʹ�õ���Ұ����ӿ�
// ��٣�
//
// �����ˣ�������
// ��Ȩ��2011 ��������ʵ�����¼����ɷ����޹�˾ ��Ȩ����
// ��ע��
// ========================================================
//  ����		       �޸���		����
//20120117     ������        ���Ӷ�
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TDQS.Contracts
{
    /// <summary>
    /// MEF��Ұ�ӿ�
    /// </summary>
    public interface IVisionMng
    {
        #region ����
        /// <summary>
        /// ����ToolStripItem
        /// </summary>
        /// <returns></returns>
        ToolStripItem GetToolStripItem();

        /// <summary>
        /// ������ܰ�ť����
        /// </summary>
        void OnButtonClick();
        #endregion // ����

        #region ����

        /// <summary>
        /// ��־λ
        /// </summary>
        bool Flag
        {
            get;
            set;
        }
        #endregion // ����

        #region �¼�
        /// <summary>
        /// �����ť�¼�
        /// </summary>
        event MouseEventHandler RightButtonClick;
        #endregion // �¼�
    }
}

