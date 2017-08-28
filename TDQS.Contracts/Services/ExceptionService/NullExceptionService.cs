#region CLR�汾 4.0.30319.239
// NullExceptionService ��
// ʱ�䣺2011/9/16 11:51:57
// ���ƣ�NullExceptionService
// ��٣�NullObjectģʽ�����������κ�ExceptionService ʱ�������ն����Ա�֤�������쳣��
//
// �����ˣ�����ΰ
// ��Ȩ��2011 ��������ʵ�����¼����ɷ����޹�˾ ��Ȩ����
// ��ע��
// ========================================================
//  ����		�޸���		����
#endregion
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TDQS.Contracts
{
    /// <summary>
    /// NullObjectģʽ�����������κ�ExceptionService ʱ�������ն����Ա�֤�������쳣��
    /// </summary>
    public class NullExceptionService:IExceptionService
    {
        #region ���������

        /// <summary>
        /// ����
        /// </summary>
        public NullExceptionService()
        {
            //
            
            //
        }

        #endregion // ���������

        #region ���з���
        #endregion // ���з���

        #region ��������
        #endregion // ��������

        #region ˽�з���
        #endregion // ˽�з���

        #region ���Լ���˽�б���

        /// <summary>
        /// ����ģʽ�����ؿմ��������쳣����
        /// </summary>
        static readonly NullExceptionService instance = new NullExceptionService();

        /// <summary>
        /// ����ģʽ�����ؿմ��������쳣����
        /// </summary>
        public static NullExceptionService Instance
        {
            get { return instance; }
        }
        #endregion // ���Լ���˽�б���


        #region IExceptionService ��Ա
        /// <summary>
        /// ����ָ�����쳣�������������쳣����
        /// </summary>
        /// <param name="ex">ԭʼ�쳣</param>
        /// <param name="strExHanlderName">�쳣����</param>
        /// <param name="buttons">��Ϣ��ʾ��ť���</param>
        /// <returns>DialogResult���Ի��򷵻ؽ����</returns>
        public DialogResult ProcessExeception(Exception ex, string strExHanlderName, MsgBoxButtons buttons)
        {
            return DialogResult.None;
        }
        /// <summary>
        /// ����ָ�����쳣�������������쳣����
        /// </summary>
        /// <param name="ex">ԭʼ�쳣</param>
        /// <param name="strExHanlderName">�쳣����</param>
        /// <param name="errorString">�Ѻ���ʾ��Ϣ</param>
        /// <param name="buttons">��Ϣ��ʾ��ť���</param>
        /// <returns>DialogResult���Ի��򷵻ؽ����</returns>
        public DialogResult ProcessByErrorString(Exception ex, string strExHanlderName, string errorString, MsgBoxButtons buttons)
        {
            return DialogResult.None;
        }
        /// <summary>
        /// ����ָ�����쳣�������������쳣����
        /// </summary>
        /// <param name="ex">ԭʼ�쳣</param>
        /// <param name="strExHanlderName">�쳣����</param>
        /// <param name="errorCode">�Ѻ���ʾ�쳣����</param>
        /// <param name="buttons">��Ϣ��ʾ��ť���</param>
        /// <returns>DialogResult���Ի��򷵻ؽ����</returns>
        public DialogResult ProcessByErrorCode(Exception ex, string strExHanlderName, string errorCode, MsgBoxButtons buttons)
        {
            return DialogResult.None;
        }

        #endregion

        #region IService ��Ա
        /// <summary>
        /// ����
        /// </summary>
        /// <returns>�Ƿ�</returns>
        public bool Active()
        {
            return false;
        }
        /// <summary>
        /// ����
        /// </summary>
        public void Start()
        {
            
        }
        /// <summary>
        /// ��ͣ
        /// </summary>
        public void Pause()
        {
            
        }
        /// <summary>
        /// ֹͣ
        /// </summary>
        public void Stop()
        {
            
        }

        /// <summary>
        /// �Ƿ��ѡ
        /// </summary>
        /// <returns>�Ƿ�</returns>
        public bool Required()
        {
            return true;
        }
        #endregion

    
    }
}