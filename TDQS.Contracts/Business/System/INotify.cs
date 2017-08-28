#region CLR�汾 4.0.30319.239
// INotify �ӿ�
// ʱ�䣺2011-11-29 11:01:11
// ���ƣ�INotify
// ��٣�Notify֪ͨ/����ģʽ��ͨ��֪ͨ����ִ�в�����ͨ���¼������˽⶯����������һ��������
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

namespace TDQS.Contracts
{
    /// <summary>
    /// Notify֪ͨ/����ģʽ�ӿڡ�ͨ��֪ͨ����ִ�в�����ͨ���¼������˽⶯����������һ��������
    /// </summary>
    public interface INotify
    {
        #region ����
        /// <summary>
        /// ֪ͨ����
        /// </summary>
        /// <param name="obj">����</param>
        /// <param name="Action">����</param>
        void Notify(Object obj, NotifyAction Action);
        #endregion // ����

        #region ����
        #endregion // ����

        #region �¼�
        /// <summary>
        /// �����¼�
        /// </summary>
        event MonitorEventHandler Monitor;
        #endregion // �¼�
    }

    /// <summary>
    /// �¼�����
    /// </summary>
    public class NotifyEventArgs : EventArgs
    {
        /// <summary>
        /// ֪ͨ��������
        /// </summary>
        public NotifyAction NotifyAction
        {
            get
            {
                return m_NotifyAction;
            }
            set
            {
                m_NotifyAction = value;
            }
        }
        private NotifyAction m_NotifyAction;
    }

    /// <summary>
    /// ֪ͨö��
    /// </summary>
    public enum NotifyAction : byte
    {
        /// <summary>
        /// ����
        /// </summary>
        Added = 0,
        /// <summary>
        /// ɾ��
        /// </summary>
        Deleting = 1,
        /// <summary>
        /// ����
        /// </summary>
        Updated = 2,
        /// <summary>
        /// ����
        /// </summary>
        Saved = 3
    }
    /// <summary>
    /// �������¼�����
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public delegate void MonitorEventHandler(Object sender, NotifyEventArgs e);

}

