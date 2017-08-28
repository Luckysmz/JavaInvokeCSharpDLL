#region CLR�汾 4.0.30319.239
// ICommand �ӿ�
// ʱ�䣺2011-11-10 14:04:17
// ���ƣ�ICommand 
// ��٣�����ҵ������Ľӿ�
//
// �����ˣ�����
// ��Ȩ��2011 ��������ʵ�����¼����ɷ����޹�˾ ��Ȩ����
// ��ע��
// ========================================================
//  ����		�޸���		����
#endregion
using System;
using System.Collections.Generic;

namespace TDQS.Contracts
{
    /// <summary>
    /// ����ҵ������Ľӿ�
    /// </summary>
    public interface ICommand
    {
        #region ����
        /// <summary>
        /// ִ������Զ�ѹundoredoջ����
        /// </summary>
        /// <returns></returns>
        bool Do();

        /// <summary>
        /// ��������undoredoջ���С� 
        /// </summary>
        /// <returns>�����Ƿ�ɹ�</returns>
        ICommand Undo();

        /// <summary>
        /// ��������undoredoջ���С� 
        /// </summary>
        /// <returns>�����Ƿ�ɹ�</returns>
        ICommand Redo();

        /// <summary>
        /// ִ������,��ѹջִ�С�
        /// </summary>
        /// <returns></returns>
        bool Execute();

        /// <summary>
        /// ��ִ������,��ѹջִ�С�
        /// </summary>
        /// <returns></returns>
        bool UnExecute();

        /// <summary>
        /// �ظ�ִ������
        /// </summary>
        /// <returns></returns>
        bool ReExecute();
            

        #endregion // ����

        #region ����
   
        /// <summary>
        /// ��ȡ������
        /// </summary>
        string Name
        {
            get;
        }

        /// <summary>
        /// ��ȡ����ִ�еĴ�����Ϣ
        /// </summary>
        string ErrorMessage
        {
            get;
        }

        #endregion // ����

        #region �¼�

        /// <summary>
        /// ����ִ��ǰ����
        /// </summary>
        event CommandExecutingEventHandler CommandExecuting;

        /// <summary>
        /// ����ִ�к���
        /// </summary>
        event EventHandler CommandExecuted;

        /// <summary>
        /// ����ǰ����
        /// </summary>
        event CommandExecutingEventHandler CommandUnExecuting;

        /// <summary>
        /// ��������
        /// </summary>
        event EventHandler CommandUnExecuted;

        /// <summary>
        /// ����ǰ����
        /// </summary>
        event CommandExecutingEventHandler CommandReExecuting;

        /// <summary>
        /// ��������
        /// </summary>
        event EventHandler CommandReExecuted;

        #endregion // �¼�
    }


    /// <summary>
    /// �����¼�����
    /// </summary>
    public class CommandExecutingEventArgs : EventArgs
    {
        /// <summary>
        /// �Ƿ�ȡ����ǰ�����ִ��
        /// </summary>
        public bool Cancel
        {
            get
            {
                return m_bCancel;
            }
            set
            {
                m_bCancel = value;
            }
        }
        private bool m_bCancel;
    }

    /// <summary>
    /// �����е��¼�������
    /// </summary>
    /// <param name="sender">�����</param>
    /// <param name="e">�������</param>
    public delegate void CommandExecutingEventHandler(ICommand sender, CommandExecutingEventArgs e);

    /// <summary>
    /// ����������¼�����  �ӿ�
    /// </summary>
    public class CommandEventArgs : EventArgs
    {
        /// <summary>
        /// ���캯��
        /// </summary>
        /// <param name="cmd"></param>
        public CommandEventArgs(ICommand cmd)
        {
            this.m_cmd = cmd;
        }

        #region ����
        /// <summary>
        /// ����
        /// </summary>
        public ICommand Command
        {
            get
            {
                return this.m_cmd;
            }
        }
        private ICommand m_cmd;

        #endregion //����
    }
}

