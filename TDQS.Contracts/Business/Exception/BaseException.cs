#region CLR�汾 4.0.30319.269
// BaseException ��
// ʱ�䣺2012-6-5 15:45:46
// ���ƣ�BaseException
// ��٣��쳣����
//
// �����ˣ�����
// ��Ȩ��2012 ��������ʵ�����¼����ɷ����޹�˾ ��Ȩ����
// ��ע��
// ========================================================
//  ����		�޸���		����
#endregion
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace TDQS.Contracts
{
    /// <summary>
    /// �쳣����
    /// </summary>
    [Serializable]
    public abstract class BaseException : Exception
    {
        #region ���������
        /// <summary>
        /// �쳣Ĭ�Ϲ���
        /// </summary>
        public BaseException()
            : base()
        {
        }

        /// <summary>
        /// ���ݴ�����Ϣ�ַ��������쳣
        /// </summary>
        /// <param name="message"></param>
        public BaseException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// �����л��쳣����
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        protected BaseException(SerializationInfo info, StreamingContext context) : base(info, context) { }

        /// <summary>
        /// ���ݴ�����Ϣ�ַ������ڲ��쳣�����쳣
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerex"></param>
        public BaseException(string message, Exception innerex) : base(message, innerex) { }

        /// <summary>
        /// ָ��������Ĺ�����
        /// </summary>
        /// <param name="errorCode"></param>
        /// <param name="message"></param>
        public BaseException(string errorCode, string message)
            : base(message)
        {
        }

        /// <summary>
        /// ָ��������Ĺ�����
        /// </summary>
        /// <param name="errorCode"></param>
        /// <param name="message"></param>
        /// <param name="returnTrace"></param>
        public BaseException(string errorCode, string message, string returnTrace)
            : base(message)
        {
        }

        /// <summary>
        /// ָ�������롢������Ϣ�ַ������ڲ��쳣�����쳣
        /// </summary>
        /// <param name="errorCode"></param>
        /// <param name="message"></param>
        /// <param name="innerex"></param>
        public BaseException(string errorCode, string message, Exception innerex)
            : base(message, innerex)
        {
        }

        /// <summary>
        /// ����ָ���쳣�����쳣
        /// </summary>
        /// <param name="ex"></param>
        public BaseException(Exception ex)
            : base("ϵͳ�����쳣����ͨ����־�鿴�ڲ��쳣��Ϣ", ex) { }

        #endregion // ���������

        #region ���з���
        /// <summary>
        /// ���ڷ����л�ȡ������Ϣ
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
        }

        /// <summary>
        /// ���������Ϣ
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Concat(new string[]
                                            {
                                                "Message:", Message, Environment.NewLine,
                                                "ErrorCode:", ErrorCode,Environment.NewLine,
                                                "Source:", Source,Environment.NewLine,
                                                "StackTrace:", StackTrace,Environment.NewLine,
                                            });
        }

   
        #endregion // ���з���

        #region ��������
        #endregion // ��������

        #region ˽�з���
        #endregion // ˽�з���

        #region ���Լ���˽�б���

        /// <summary>
        /// Ӧ�ó�������
        /// </summary>
        public string AppDomainName { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        public string AssemblyName { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public string ClassName { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        public string MethodName { get; set; }

        /// <summary>
        /// Machine Name
        /// </summary>
        public string MachineName { get; set; }

        /// <summary>
        /// Process Id
        /// </summary>
        public int ProcessId { get; set; }

        /// <summary>
        /// Process Name 
        /// </summary>
        public string ProcessName { get; set; }

        /// <summary>
        /// Thread Id
        /// </summary>
        public int ThreadId { get; set; }

        /// <summary>
        /// Reason
        /// </summary>
        public string Reason { get; set; }
        /// <summary>
        /// Error Code
        /// </summary>
        public string ErrorCode { get; set; }

        /// <summary>
        /// System ID
        /// </summary>
        public string SystemID { get; set; }

        /// <summary>
        /// Return Trace
        /// </summary>
        public string ReturnTrace { get; set; }


        /// <summary>
        /// ע�����쳣���͵���������
        /// </summary>
        public abstract string ExceptionDescription
        {
            get;
        }

        #endregion // ���Լ���˽�б���

    }


}