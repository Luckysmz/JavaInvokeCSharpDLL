#region CLR�汾 4.0.30319.225
// IXmlHandler �ӿ�
// ʱ�䣺2011-11-16 10:12:33
// ���ƣ����ò�����
// ��٣�
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
using System.Xml;

namespace TDQS.Contracts
{
    /// <summary>
    /// ���ò����߽ӿ�
    /// </summary>
    public interface IConfigHandler
    {
        #region ����

        /// <summary>
        /// ��������
        /// </summary>
        /// <param name="index">����ֵ</param>
        /// <param name="data">����</param>
        /// <returns>�Ƿ񱣴�ɹ�</returns>
        bool Save(object index, object data);

        /// <summary>
        /// ���ݳ���
        /// </summary>
        /// <param name="index">����ֵ</param>
        /// <returns>����</returns>
        object Out(object index);

        /// <summary>
        /// ������Դ��ȡ���ݼ�
        /// </summary>
        /// <param name="source">����Դ</param>
        void ReadFrom(object source);

        /// <summary>
        /// �����ݼ�д����������
        /// </summary>
        /// <param name="carrier">����</param>
        void WriteTo(object carrier);

        /// <summary>
        /// �������ݼ�
        /// </summary>
        void Clear();

        #endregion // ����

        #region ����
        /// <summary>
        /// XmlDocument����
        /// </summary>
        XmlDocument Document { get; }
        #endregion // ����

        #region �¼�
        #endregion // �¼�
    }
}

