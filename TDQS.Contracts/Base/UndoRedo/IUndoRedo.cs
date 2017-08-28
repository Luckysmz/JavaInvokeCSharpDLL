#region CLR�汾 4.0.30319.239
// IUndoRedo �ӿ�
// ʱ�䣺2011-12-6 17:09:12
// ���ƣ�IUndoRedo
// ��٣�UndoRedo ����Command��ջ��ִ�г�������
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
    /// UndoRedo�ӿڡ� ����Command��ջ��ִ�г���������
    /// </summary>
    public interface IUndoRedo
    {
        #region ����
        /// <summary>
        /// ��ն�ջ
        /// </summary>
        void Clear();

        /// <summary>
        /// ѹ��һ������
        /// </summary>
        /// <param name="cmd"></param>
        bool Push(ICommand cmd);

        /// <summary>
        /// �Ƴ�һ������
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns></returns>
        void Remove(ICommand cmd);
        
        /// <summary>
        /// ����
        /// </summary>
        /// <returns>������</returns>
        ICommand Redo();

        /// <summary>
        /// ����
        /// </summary>
        /// <returns>������</returns>
        ICommand Undo();

        #endregion // ����

        #region ����
        /// <summary>
        /// �Ƿ�������
        /// </summary>
        bool CanRedo
        {
            get;
        }

        /// <summary>
        /// �Ƿ��ܳ���
        /// </summary>
        bool CanUndo
        {
            get;
        }

        /// <summary>
        /// ��ǰָ�������,����������������
        /// </summary>
        ICommand CurrentCommand
        {
            get;
        }

        /// <summary>
        /// ����ִ�е�����
        /// </summary>
        ICommand ExecutingCommand
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
        /// ִ������
        /// </summary>
        event EventHandler<CommandEventArgs> CommandDone;

        /// <summary>
        /// ��������
        /// </summary>
        event EventHandler<CommandEventArgs> CommandRedone;

        /// <summary>
        /// ��������
        /// </summary>
        event EventHandler<CommandEventArgs> CommandUndone;

        /// <summary>
        /// ״̬�ı��¼�
        /// </summary>
        event EventHandler StateChanged;

        #endregion // �¼�
    }
}

