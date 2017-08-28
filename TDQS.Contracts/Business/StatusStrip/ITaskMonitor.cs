#region CLR�汾 4.0.30319.239
// ITaskMonitor �ӿ�
// ʱ�䣺2011-4-28 17:11:00
// ���ƣ�����������ӿ�
// ��٣���������Ϣ��ص�����������ӿ�,ͨ��ʵ������������ӿ�,��չ������Ľ�����Ϣ
//
// �����ˣ����� ����ֲ����
// ��Ȩ��2011 ��������ʵ�����¼����ɷ����޹�˾ ��Ȩ����
// ��ע��
// ========================================================
//  ����		�޸���		����
// 20110926 ������  1����toolstripitem��ز��������Ƴ�������IToolStripItemManager�ӿ���
#endregion
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TDQS.Contracts
{
    /// <summary>
    /// ��������Ϣ��ص�����������ӿ�,ͨ��ʵ������������ӿ�,��չ������Ľ�����Ϣ��
    /// </summary>
    public interface ITaskMonitor
    {
        #region ����
        

        /// <summary>
        /// ͨ��״̬����֪ͨ�û�һ������Ŀ�ʼ
        /// </summary>
        /// <param name="sTaskName">������</param>
        /// <param name="TotalTaskStep">�����ܽ���</param>
        void StartTask(string sTaskName, int TotalTaskStep);

        /// <summary>
        /// ͨ��״̬����֪ͨ�û�һ������Ŀ�ʼ
        /// ˵�����÷��������������ܽ���δ֪�����
        /// </summary>
        /// <param name="sTaskName">������</param>
        void StartTask(string sTaskName);

        /// <summary>
        /// ���õ�ǰ������
        /// </summary>
        /// <param name="sTaskName">������</param>
        void UpdateTask(string sTaskName);

        /// <summary>
        /// ���õ�ǰ���������+1
        /// </summary>
        void UpdateTask();
        /// <summary>
        /// ���õ�ǰ���������
        /// ˵����������Ȳ��ܳ��� �����ܽ���
        /// </summary>
        /// <param name="TaskStep">�������</param>
        void UpdateTask(int TaskStep);

        /// <summary>
        /// ���õ�ǰ���������
        /// ˵����������Ȳ��ܳ��� �����ܽ���
        /// </summary>
        /// <param name="sTaskName">������</param>
        /// <param name="TaskStep">�������</param>
        void UpdateTask(string sTaskName, int TaskStep);

        /// <summary>
        /// ������ɣ�������ȵ����ܽ���
        /// </summary>
        void TaskDone();

        /// <summary>
        /// ȡ������
        /// </summary>
        void CancelTask();

       
        #endregion // ����

        #region ����
        #endregion // ����

        #region �¼�
        #endregion // �¼�

        #region ԭIXStatusListener��Ա
        #region ����

        /// <summary>
        /// �����ǰ״̬�������������
        /// </summary>
        void Clear();

        /// <summary>
        /// StatusService(״̬����) ���õ�ǰ״̬Ϊ �������� ״̬
        /// </summary>
        void Ready();

        /// <summary>
        /// StatusService(״̬����) ���һ����Ϣ��״̬��������
        /// </summary>
        /// <param name="sMessage">��Ϣ</param>
        void Message(string sMessage);

        /// <summary>
        /// StatusService(״̬����) ���һ����Ϣ��״̬��������
        /// </summary>
        /// <param name="sName">��Ϣ����</param>
        /// <param name="sMessage">��Ϣ</param>
        void Message(string sName, string sMessage);

        /// <summary>
        /// StatusService(״̬����) ���һ�����浽״̬��������
        /// </summary>
        /// <param name="sMessage">����</param>
        void Warn(string sMessage);

        /// <summary>
        /// StatusService(״̬����) ���һ�����浽״̬��������
        /// </summary>
        /// <param name="sName">��������</param>
        /// <param name="sMessage">����</param>
        void Warn(string sName, string sMessage);

        /// <summary>
        /// StatusService(״̬����) ���һ������״̬��������
        /// </summary>
        /// <param name="sMessage">����</param>
        void Error(string sMessage);

        /// <summary>
        /// StatusService(״̬����) ���һ������״̬��������
        /// </summary>
        /// <param name="sName">��������</param>
        /// <param name="sMessage">����</param>
        void Error(string sName, string sMessage);

        #endregion // ����

        #region ����

        /// <summary>
        /// ��Ϣ����
        /// </summary>
        string NameString
        {
            get;
        }

        /// <summary>
        /// ��Ϣ
        /// </summary>
        string MessageString
        {
            get;
        }

        #endregion
        #endregion
    }
}