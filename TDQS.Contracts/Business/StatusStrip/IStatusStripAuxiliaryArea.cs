#region CLR�汾 4.0.30319.239
// IStatusStripAuxiliaryArea �ӿ�
// ʱ�䣺2011/11/17 10:04:57
// ���ƣ�״̬���������������ܽӿ�
// ��٣�
//
// �����ˣ�������
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

namespace TDQS.Contracts
{
    /// <summary>
    /// ״̬���������������ܽӿ�
    /// </summary>
    public interface IStatusStripAuxiliaryArea
    {
        #region ����
        #endregion // ����

        #region ����
        #endregion // ����

        #region �¼�
        /// <summary>
        /// ��׽��ť������¼�
        /// </summary>
        event EventHandler CatchButtonClick;
        /// <summary>
        /// ������ť������¼�
        /// </summary>
        event EventHandler CrossButtonClick;
        /// <summary>
        /// �������߰�ť������¼�
        /// </summary>
        event EventHandler CrossLineButtonClick;
        /// <summary>
        /// ���ᰴť������¼�
        /// </summary>
        event EventHandler PolarAxisButtonClick;
        /// <summary>
        /// ����ť������¼�
        /// </summary>
        event EventHandler LockButtonClick;
        /// <summary>
        /// ȫ����ť������¼�
        /// </summary>
        event EventHandler FullScreenButtonClick;
        /// <summary>
        /// ���ð�ť������¼�
        /// </summary>
        event EventHandler ContextMenuItemClick;

        #endregion // �¼�
    }
}

