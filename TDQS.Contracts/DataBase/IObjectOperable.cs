#region CLR�汾 4.0.30319.239
// IObjectOperable �ӿ�
// ʱ�䣺2011/10/9 12:03:29
// ���ƣ�IObjectOperable
// ��٣����룬���£�ɾ�����󣬲��Ҹ��µ����ݿ�
//
// �����ˣ�����ΰ
// ��Ȩ��2010 ��������ʵ�����¼����ɷ����޹�˾ ��Ȩ����
// ��ע��
// ========================================================
//  ����		�޸���		����
#endregion
using System;
using System.Collections.Generic;
using System.Data.Common;

namespace TDQS.Contracts
{
    /// <summary>
    /// ���룬���£�ɾ�����󣬲��Ҹ��µ����ݿ�
    /// </summary>
    public interface IObjectOperable
    {
        #region ����
        /// <summary>
        /// ����һ���������ݿ�
        /// </summary>
        /// <param name="o">����</param>
        bool Insert(object o);

        /// <summary>
        /// ���¶������ݿ�
        /// </summary>
        /// <param name="o">����</param>
        /// <returns>�����Ƿ�ɹ�</returns>
        bool Update(object o);

        /// <summary>
        /// �����ݿ���ɾ��һ������
        /// </summary>
        /// <param name="o">����</param>
        /// <returns>�����Ƿ�ɹ�</returns>
        bool Delete(object o);
        #endregion // ����

        #region ����

        /// <summary>
        /// ��ȡ����������
        /// </summary>
        DbTransaction Transaction
        {
            get;
            set;
        }

        #endregion // ����

        #region �¼�
        #endregion // �¼�
    }
}

