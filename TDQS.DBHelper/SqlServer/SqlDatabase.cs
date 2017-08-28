// PostgreSqlDatabase ��
// ʱ��: 2011-6-2 17:58:13
// ���ƣ�SQL Server������ݿ����
// ��٣��ṩSQL Server������ݲ�������
//
// �����ˣ�������
// ��Ȩ��2011 ��������ʵ�����¼����ɷ����޹�˾ ��Ȩ����
// ��ע��
// ========================================================
//  ����		�޸���		����
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;

namespace TDQS.DBHelper.SqlServer
{
    /// <summary>
    /// SqlDatabase ��
    /// </summary>
   [CLSCompliant(false)] 
    public class SqlDatabase : Database
    {
        #region ���������

        /// <summary>
        /// ����
        /// </summary>
        /// <param name="connctionString">���ݿ������ַ���</param>
        public SqlDatabase(String connctionString)
        {
            Debug.Assert(!string.IsNullOrEmpty(connctionString), "���ݿ�·�� " + connctionString + " �����ڣ�");
            m_connString = connctionString;
            m_dbFactory = SqlClientFactory.Instance;
            m_dbFactory.CreateConnectionStringBuilder().ConnectionString = m_connString;
        }

        #endregion // ���������

        #region ���з���
        #endregion // ���з���

        #region ��������
        #endregion // ��������

        #region ˽�з���
        #endregion // ˽�з���

        #region ���Լ���˽�б���
        #endregion // ���Լ���˽�б���

    }
}