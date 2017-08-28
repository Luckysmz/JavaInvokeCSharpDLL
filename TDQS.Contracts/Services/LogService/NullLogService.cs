#region CLR�汾 4.0.30319.239
// NullLogService ��
// ʱ�䣺2011-11-10 14:04:17
// ���ƣ�NullLogService 
// ��٣�NullObjectģʽ�����������κ�LogServiceʱ�������ն����Ա�֤�������쳣��
//
// �����ˣ�����
// ��Ȩ��2011 ��������ʵ�����¼����ɷ����޹�˾ ��Ȩ����
// ��ע��
// ========================================================
//  ����		�޸���		����
#endregion
using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace TDQS.Contracts
{
    /// <summary>
    /// NullObjectģʽ�����������κ�LogServiceʱ�������ն����Ա�֤�������쳣�� 
    /// </summary>
    public sealed class NullLogService : ILogService
    {
        #region ���������

        /// <summary>
        /// ����
        /// </summary>
        public NullLogService()
        {
            //
            
            //
        }

        #endregion // ���������

        #region ���з���
        /// <summary>
        /// ����
        /// </summary>
        /// <returns>�����Ƿ�ɹ�</returns>
        public bool Active()
        {
            return false;
        }

        /// <summary>
        /// ����
        /// </summary>
        public void Start() { }

        /// <summary>
        /// ��ͣ
        /// </summary>
        public void Pause() { }

        /// <summary>
        /// ֹͣ
        /// </summary>
        public void Stop() { }

        /// <summary>
        /// ����
        /// </summary>
        /// <returns>�����Ƿ�ɹ�</returns>
        public bool Required()
        {
            return false;
        }

        /// <summary>
        /// �����־���
        /// </summary>
        /// <param name="loggerName">��������</param>
        /// <returns>�մ�����</returns>
        public ILogHandler GetLogger(string loggerName)
        {
            NullLogHandler nullLogHandler = NullLogHandler.Instance;
            return nullLogHandler;
        }
        #endregion // ���з���

        #region ��������
        #endregion // ��������

        #region ˽�з���
        #endregion // ˽�з���

        #region ���Լ���˽�б���
        /// <summary>
        /// ��������
        /// </summary>
        static readonly NullLogService instance = new NullLogService();
        /// <summary>
        /// ���ض���ʵ��
        /// </summary>
        public static NullLogService Instance
        {
            get { return instance; }
        }
        #endregion // ���Լ���˽�б���

    }

    /// <summary>
    /// ʵ��һ���յ�LogHandler�࣬ΪNullLogService�ṩ�ղ����� 
    /// </summary>
    public sealed class NullLogHandler : ILogHandler
    {
        #region ���������

        /// <summary>
        /// ����
        /// </summary>
        public NullLogHandler()
        {
            //
            
            //
        }

        #endregion // ���������

        #region ���з���

        /// <summary>
        /// ����
        /// </summary>
        /// <param name="message">��Ϣ����</param>
        public void Debug(object message) { }

        /// <summary>
        ///  ����
        /// </summary>
        /// <param name="message">��Ϣ����</param>
        /// <param name="exception">�쳣����</param>
        public void Debug(object message, Exception exception) { }
        //public void DebugFormat(string format, object arg0) { }
        //public void DebugFormat(string format, params object[] args) { }
        //public void DebugFormat(string format, object arg0, object arg1) { }

        /// <summary>
        /// ����
        /// </summary>
        /// <param name="message">��Ϣ����</param>
        public void Error(object message) { }

        /// <summary>
        /// ����
        /// </summary>
        /// <param name="message">��Ϣ����</param>
        /// <param name="exception">�쳣����</param>
        public void Error(object message, Exception exception) { }
        //public void ErrorFormat(string format, object arg0) { }
        //public void ErrorFormat(string format, params object[] args) { }
        //public void ErrorFormat(string format, object arg0, object arg1) { }

        /// <summary>
        /// ����
        /// </summary>
        /// <param name="message">��Ϣ����</param>
        public void Fatal(object message) { }

        /// <summary>
        /// ����
        /// </summary>
        /// <param name="message">��Ϣ����</param>
        /// <param name="exception">�쳣����</param>
        public void Fatal(object message, Exception exception) { }
        //public void FatalFormat(string format, object arg0) { }
        //public void FatalFormat(string format, params object[] args) { }
        //public void FatalFormat(string format, object arg0, object arg1) { }

        /// <summary>
        /// ��ϸ
        /// </summary>
        /// <param name="message">��Ϣ����</param>
        public void Info(object message) { }

        /// <summary>
        /// ��ϸ
        /// </summary>
        /// <param name="message">��Ϣ����</param>
        /// <param name="exception">�쳣����</param>
        public void Info(object message, Exception exception) { }
        //public void InfoFormat(string format, object arg0) { }
        //public void InfoFormat(string format, params object[] args) { }
        //public void InfoFormat(string format, object arg0, object arg1) { }
        /// <summary>
        /// ����
        /// </summary>
        /// <param name="message">��Ϣ����</param>
        public void Warn(object message) { }

        /// <summary>
        /// ����
        /// </summary>
        /// <param name="message">��Ϣ����</param>
        /// <param name="exception">�쳣����</param>
        public void Warn(object message, Exception exception) { }
        //public void WarnFormat(string format, object arg0) { }
        //public void WarnFormat(string format, params object[] args) { }
        //public void WarnFormat(string format, object arg0, object arg1) { }

        #endregion // ���з���

        #region ��������
        #endregion // ��������

        #region ˽�з���
        #endregion // ˽�з���

        #region ���Լ���˽�б���

        /// <summary>
        /// ��־���񣨵�ʵ��ģʽ��
        /// </summary>
        static readonly NullLogHandler instance = new NullLogHandler();

        /// <summary>
        /// ��־���񣨵�ʵ��ģʽ��
        /// </summary>
        public static NullLogHandler Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// ��־�������
        /// </summary>
        private void OnLogOutput(object Output)
        {
            if (LogOutput != null)
            {
                LogOutput(Output);
            }
        }
        #endregion // ���Լ���˽�б���

        #region ILogHandler ��Ա

        /// <summary>
        /// ����¼�
        /// </summary>
        public event LogOutputEventHandler LogOutput;

        #endregion
    }

}