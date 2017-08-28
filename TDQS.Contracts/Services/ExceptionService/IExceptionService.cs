#region CLR�汾 4.0.30319.239
// IExceptionService �ӿ�
// ʱ�䣺2011/11/16 10:43:52
// ���ƣ��쳣����
// ��٣��ṩ��Ӧ���쳣��������
//
// �����ˣ�����ΰ
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
    /// �ṩ��Ӧ���쳣��������
    /// </summary>
    public interface IExceptionService:IService
    {
        #region ����
        /// <summary>
        /// ����ָ�����쳣�������������쳣����
        /// </summary>
        /// <param name="ex">ԭʼ�쳣</param>
        /// <param name="strExHanlderName">�쳣����</param>
        /// <param name="buttons">��Ϣ��ʾ��ť���</param>
        /// <returns>�Ի�������</returns>
        DialogResult ProcessExeception(Exception ex, string strExHanlderName, MsgBoxButtons buttons);
        /// <summary>
        /// ����ָ�����쳣�������������쳣����
        /// </summary>
        /// <param name="ex">ԭʼ�쳣</param>
        /// <param name="strExHanlderName">�쳣����</param>
        /// <param name="errorString">�Ѻ���ʾ��Ϣ</param>
        /// <param name="buttons">��Ϣ��ʾ��ť���</param>
        /// <returns>�Ի�������></returns>
        DialogResult ProcessByErrorString(Exception ex, string strExHanlderName, string errorString, MsgBoxButtons buttons);
        /// <summary>
        /// ����ָ�����쳣�������������쳣����
        /// </summary>
        /// <param name="ex">ԭʼ�쳣</param>
        /// <param name="strExHanlderName">�쳣����</param>
        /// <param name="errorCode">�Ѻ���ʾ�쳣����</param>
        /// <param name="buttons">��Ϣ��ʾ��ť���</param>
        /// <returns>�Ի�������</returns>
        DialogResult ProcessByErrorCode(Exception ex, string strExHanlderName, string errorCode, MsgBoxButtons buttons);
        #endregion // ����

        #region ����
        #endregion // ����

        #region �¼�
        #endregion // �¼�
    }
}

