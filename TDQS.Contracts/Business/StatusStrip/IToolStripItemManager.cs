#region CLR�汾 4.0.30319.239
// ITaskMonitor �ӿ�
// ʱ�䣺2011-9-20 16:17:46
// ���ƣ�״̬�����������ӿ�
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
using System.Windows.Forms;

namespace TDQS.Contracts
{
    /// <summary>
    /// ״̬�����������ӿ�
    /// </summary>
    public interface IToolStripItemManager
    {
        #region ����

        /// <summary>
        /// ����һ��״̬��������
        /// </summary>
        /// <param name="item"></param>
        /// <param name="index"></param>
        void AddAdditionalItem(ToolStripItem item, int index = -1);
        
        /// <summary>
        /// �Ƴ�ָ�������Ĺ�����
        /// </summary>
        /// <param name="index"></param>
        void RemoveAdditionalItem(int index = -1);

        /// <summary>
        ///  �������ƻ��״̬��������
        /// </summary>
        /// <param name="itemName"></param>
        /// <returns></returns>
        ToolStripItem GetItemByName(string itemName);

        #endregion // ����

        #region ����
        #endregion // ����

        #region �¼�
        #endregion // �¼�
    }
}