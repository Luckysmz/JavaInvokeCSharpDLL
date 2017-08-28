#region CLR�汾 4.0.30319.17379
// IParameterCache �ӿ�
// ʱ�䣺2012/4/19 15:45:41
// ���ƣ�IParameterCache
// ��٣�������������ӿ�
//
// �����ˣ�������
// ��Ȩ��Copyright (C) 2012 ��������ʵ�����¼����ɷ����޹�˾ ��Ȩ����
// ��ע��
// ========================================================
//  ����		�޸���		����
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace TDQS.Contracts
{
    /// <summary>
    /// ������������ӿ�
    /// </summary>
    public interface IParameterCache
    {
        #region ����

        /// <summary>
        /// �������Ʒ��ع��̼��Ļ������
        /// </summary>
        /// <param name="parameterName">��������</param>
        /// <param name="paramID">����ID</param>
        /// <returns>������󣬲�����ʱ����null</returns>
        DataTable GetParameterCache(string parameterName, string paramID);

        /// <summary>
        /// ָ�����ƵĹ��̼�����Դ���ݸı�
        /// </summary>
        /// <param name="parameterName">��������</param>
        /// <param name="paramID">����ID</param>
        void ChangeParameter(string parameterName, string paramID);

        /// <summary>
        /// �������Ʒ��ع��̼��Ļ������
        /// </summary>
        /// <param name="parameterName">��������</param>
        /// <param name="paramID">����ID</param>
        /// <returns>������󣬲�����ʱ����null</returns>
        DataTable GetParameterCache(string parameterName);

        /// <summary>
        /// ָ�����ƵĹ��̼�����Դ���ݸı�
        /// </summary>
        /// <param name="parameterName">��������</param>
        void ChangeParameter(string parameterName);

        /// <summary>
        /// ��ȡ��������������
        /// </summary>
        /// <param name="entID">����ID</param>
        /// <param name="parameterName">��������</param>
        /// <returns>������󣬲�����ʱ����null</returns>
        DataTable GetEntParameterCache(string entID, string parameterName);

        /// <summary>
        /// ָ�����ƵĲ��������ݸı�
        /// </summary>
        /// <param name="entID">����ID</param>
        /// <param name="parameterName">��������</param>
        void ChangeEntParameter(string entID,string parameterName);

        #endregion // ����

        #region ����
        #endregion // ����

        #region �¼�
        #endregion // �¼�
    }
}

