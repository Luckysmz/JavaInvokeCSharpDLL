#region CLR�汾 4.0.30319.17379
// IBackgroundBusiness �ӿ�
// ʱ�䣺2012/4/1 13:45:10
// ���ƣ�IBackgroundBusiness
// ��٣�����ͼ����ӿ�
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
using TDQS.Contracts;
using System.Data;

namespace TDQS.Contracts
{
    /// <summary>
    /// ����ͼ����ӿ�
    /// </summary>
    public interface IBackgroundBusiness
        : ICollection<IBackgroundModel>
    {
        #region ����

        /// <summary>
        /// ����ͼ��ʼ��(����)
        /// </summary>
        /// <param name="database">���ݿ��������</param>
        /// <param name="projectid">���̱��</param>
        /// <param name="docid">�ĵ����</param>
        /// <param name="column">������</param>
        void DeSerialize(IDatabase database, string projectid, string docid, string column);

        /// <summary>
        /// ����ͼ�����ʼ��
        /// </summary>
        /// <param name="itemName">������</param>
        void DeSerialize(string itemName);

        /// <summary>
        /// �������ݱ���ʽ�ı���ͼ����
        /// </summary>
        /// <returns></returns>
        DataTable GetDataTable();

        /// <summary>
        /// ����
        /// </summary>
        void Serialize();

        #endregion // ����

        #region ����
        #endregion // ����

        #region �¼�
        #endregion // �¼�
    }
}

