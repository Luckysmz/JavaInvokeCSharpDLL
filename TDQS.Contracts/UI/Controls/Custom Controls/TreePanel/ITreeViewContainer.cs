#region CLR�汾 4.0.30319.225
// ITreeViewContainer �ӿ�
// ʱ�䣺2011-11-28 15:26:48
// ���ƣ��������ӿ�
// ��٣�
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

namespace TDQS.Contracts
{
    /// <summary>
    /// �������ӿ�
    /// </summary>
    public interface ITreeViewContainer
    {
        #region ����
        #endregion // ����

        #region ����

        /// <summary>
        /// ��ȡ����ʵ��
        /// </summary>
        Control Container
        {
            get;
        }

        /// <summary>
        /// ��ȡ��ָ��
        /// </summary>
        ITreeViewPointer TreeView
        {
            get;
        }

        #endregion // ����

        #region �¼�
        #endregion // �¼�
    }
}

