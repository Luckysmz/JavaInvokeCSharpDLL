#region CLR�汾 4.0.30319.225
// IXmlProvider �ӿ�
// ʱ�䣺2011-11-16 10:29:39
// ���ƣ��������ݹ�Ӧ��
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
    /// �������ݹ�Ӧ�߽ӿ�
    /// </summary>
    public interface IConfigProvider
    {
        #region ����
        #endregion // ����

        #region ����

        /// <summary>
        /// ��ȡͨ������ֵ�����ҵ�������
        /// </summary>
        /// <param name="index">����ֵ</param>
        /// <returns>����</returns>
        object this[object index]
        {
            get;
        }

        #endregion // ����

        #region �¼�
        #endregion // �¼�
    }
}

