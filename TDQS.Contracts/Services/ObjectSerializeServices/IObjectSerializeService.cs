#region CLR�汾 4.0.30319.239
// IDataExchangeService �ӿ�
// ʱ�䣺2011-11-10 14:04:17
// ���ƣ�IDataExchangeService �ӿ�
// ��٣��������л�����
//
// �����ˣ�����ΰ
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
    /// �������л�����
    /// </summary>
    public interface ISerializeService: IService
    {
        #region ����
        /// <summary>
        /// ��ö����Ʋ�����
        /// </summary>
        /// <returns>��ö��������л�������</returns>
        ISerializeHandler GetBinaryHandler();

        /// <summary>
        /// ���Json������
        /// </summary>
        /// <returns>���Json���л�������</returns>
        ISerializeHandler GetJsonHandler();

        /// <summary>
        /// ���Xml������
        /// </summary>
        /// <returns>���Xml���л�������</returns>
        ISerializeHandler GetXmlHandler();
        #endregion // ����

        #region ����

        /// <summary>
        /// ���������
        /// </summary>
        ISerializeHandler ObjectSerializeHandler { get; }
        #endregion // ����

        #region �¼�
        #endregion // �¼�
    }
}

