#region CLR�汾 4.0.30319.239
// IToolObject �ӿ�
// ʱ�䣺2011-11-8 16:24:40
// ���ƣ�ToolObject
// ��٣����л��ƶ�������ӿ�
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
using System.Drawing;
using System.Linq;
using System.Text;

namespace TDQS.Contracts
{
    /// <summary>
    /// �������߽ӿ�
    /// </summary>
    public interface IToolObject
    {

        #region ����
        /// <summary>
        /// ���ǰ����
        /// </summary>
        /// <param name="aCanvas">����</param>
        /// <param name="isPersistence">�Ƿ��������ķ�ʽ����</param>
        /// <returns>ָʾ�Ƿ�ɹ�����</returns>
        bool Active(ICanvasView canvasView, bool isPersistence = false);

        /// <summary>
        /// ȡ������
        /// </summary>
        /// <returns>�ù����Ƿ��Ѿ���ȡ��</returns>
        bool Cancel();

        /// <summary>
        ///  ж�ع���
        /// </summary>
        /// <returns></returns>
        bool Deactive();


        #endregion // ���з���

        #region ���Լ���˽�б���
        /// <summary>
        /// �Ƿ������
        /// </summary>
        Boolean IsComplete
        {
            get;
        }
        /// <summary>
        /// �Ƿ��Ѽ���
        /// </summary>
        Boolean IsActive
        {
            get;
        }

        /// <summary>
        /// �Ƿ������У���������ֹ�������Գ�����������
        /// </summary>
        Boolean IsRunning
        {
            get;
        }
        /// <summary>
        /// ��������¼�
        /// </summary>
        event EventHandler Done;

        /// <summary>
        /// ���߽����¼�
        /// </summary>
        event EventHandler Doing;

        /// <summary>
        /// ���߿�ʼ�¼�
        /// </summary>
        event EventHandler Start;

        /// <summary>
        /// �Ƿ��������ķ�ʽ����
        /// </summary>
        bool IsPersistence
        {
            get;
            set;
        }
        #endregion // ���Լ���˽�б���

    }
}

