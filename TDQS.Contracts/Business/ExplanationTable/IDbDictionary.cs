#region CLR�汾 4.0.30319.239
// IXDbDictionary �ӿ�
// ʱ�䣺2011-9-28 17:16:02
// ���ƣ����ݿ��ֵ� �ӿ�
// ��٣����ݿ��ֵ��Ƕ��������ݿ��б��˵��, ���������, ÿ�����˵��, �������ֶε�˵�� ����Ϣ��
//
// �����ˣ�����ΰ
// ��Ȩ��2011 ��������ʵ�����¼����ɷ����޹�˾ ��Ȩ����
// ��ע��
// ========================================================
//  ����		�޸���		����
// 2011/12/7 16:14:46, ������, �����ֶ�
#endregion
using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace TDQS.Contracts
{
    /// <summary>
    /// ���ݿ��ֵ��Ƕ��������ݿ��б��˵��, ���������, ÿ�����˵��, �������ֶε�˵�� ����Ϣ
    /// </summary>
    public interface IDbDictionary
    {
        #region ����

        /// <summary>
        /// ��ѯĳ��(����, ������˵����)�Ƿ��������ֵ��д���
        /// </summary>
        /// <param name="tableName">ĳ��(����, ������˵����)</param>
        /// <returns>�Ƿ��������ֵ��д���</returns>
        bool ContainsTable(string tableName);

        /// <summary>
        /// ��ȡĳ��(����, ������˵����)�ı�����
        /// ��: ���� T_JD ��Ϊ Ԫ���� XTableType.Element
        ///		���� T_ZHN2ZHB ��Ϊ ����Ԫ����
        ///     ���� T_JD_FLOW ��Ϊ ���ӱ�
        /// </summary>
        /// <param name="tableName">ĳ��(����, ������˵����)</param>
        /// <returns>������</returns>
        XTableType GetTableType(string tableName);

        /// <summary>
        /// ��ȡĳ��(����, ������˵����)�ı�˳���ۺ���F_GROUP��F_ORDER��
        /// </summary>
        /// <param name="tableName">ĳ��1(����, ������˵����)</param>
        /// <param name="tableName">ĳ��2(����, ������˵����)</param>
        /// <returns>��˳���ۺ���F_GROUP��F_ORDER��, �� tableName1 �� tableName2 ��ǰ�򷵻� ��������֮Ϊ����</returns>
        int Compare(string tableName1, string tableName2);

        /// <summary>
        /// ��ȡĳ��(����, ������˵����)�ı�˳���ۺ���F_GROUP��F_ORDER��
        /// </summary>
        /// <param name="tableName">ĳ��1(����, ������˵����)</param>
        /// <param name="tableName">ĳ��2(����, ������˵����)</param>
        /// <returns>��˳���ۺ���F_GROUP��F_ORDER��, �� tableName1 �� tableName2 ��ǰ�򷵻� ��������֮Ϊ����</returns>
        int CompareWithoutGROUP(string tableName1, string tableName2);

        /// <summary>
        /// ��ȡĳ���ӱ��Ӧ�ı���
        /// ��: ��ȡ������TA_ZHLFLOW��Ӧ�ı�������T_XLXD
        /// </summary>
        /// <param name="tableName">����</param>
        /// <returns>���ӱ�</returns>
        string GetOnwerTableName(string tableName);

        /// <summary>
        /// ��ȡĳ���Ӧ�ĸ��ӱ�
        /// ��: GetAdditionalTableNames("T_XLXD") �����ذ������������������ڵĸ��ӱ�ļ��� string { "TA_ZHLFLOW" }
        /// </summary>
        /// <param name="tableName">����</param>
        /// <returns>���ӱ�</returns>
        string[] GetAdditionalTableNames(string tableName);

        /// <summary>
        /// ��ȡ�����Ӧ��˵������
        /// ��: GetExplanationTableName("T_JD") ������ T_JD_EXP
        /// </summary>
        /// <param name="tableName">������</param>
        /// <returns>˵������</returns>
        string GetExplanationTableName(string tableName);

        /// <summary>
        /// ��ȡ˵�����Ӧ�ı�����
        /// ��: GetOriginalTableName("T_JD_EXP") ������ T_JD
        /// </summary>
        /// <param name="tableName">˵������</param>
        /// <returns>������</returns>
        string GetOriginalTableName(string tableName);

        /// <summary>
        /// ��ȡ���ݿ������б����ļ���(T_TABLES�еı�)
        /// </summary>
        /// <returns></returns>
        string[] GetAllTableNames();

        /// <summary>
        /// ��ȡ������ĳ���͵����б��� 
        /// </summary>
        /// <param name="tableType">�������</param>
        /// <returns>���б��� </returns>
        string[] GetAllTableNames(XTableType tableType);

        /// <summary>
        /// ��ȡ��Ľ�����ʾʱ������
        /// </summary>
        /// <param name="sTableName">����</param>
        /// <returns>��ʾ�� - ��������</returns>
        string GetTableDisplayName(string sTableName);

        /// <summary>
        /// ��������Ӧ�б�
        /// </summary>
        /// <returns></returns>
        IList<object> GetForeignValueList(IXExplanationField field);

        /// <summary>
        /// ˢ��ĳ˵�������ҷ��ظ�˵�������
        /// �˷�����ǿ���������ɶ�Ӧ��˵�������
        /// </summary>
        /// <param name="tableName">����</param>
        /// <returns>˵����</returns>
        IExplanationTable RefreshTable(string tableName);


        #endregion // ����

        #region ����

        /// <summary>
        /// ˵�����˵����, ��˵����Ľṹ
        /// </summary>
        IExplanationTable ExplanationTableSchema
        {
            get;
        }

        /// <summary>
        /// T_TABLES��˵����
        /// </summary>
        IExplanationTable TablesSchema
        {
            get;
        }

        /// <summary>
        /// ��ȡ�Ա���Ϊ������˵����
        /// ��: this["T_JD"] ����ȡ T_JD���˵����
        /// </summary>
        /// <param name="index">����</param>
        /// <returns>˵����</returns>
        IExplanationTable this[string tableName]
        {
            get;
        }

        /// <summary>
        /// ��ȡ�ֵ���˵����ļ���
        /// </summary>
        ICollection<IExplanationTable> Tables
        {
            get;
        }

        /// <summary>
        /// �����ֵ� ��Ӧ�����ݿ�
        /// </summary>
        IDatabase Database
        {
            get;
        }

        /// <summary>
        /// ����Ϊtrueʱ����ʾ�����ֵ䡰�ࡱ�ˣ���Ҫ��������
        /// </summary>
        bool Dirty
        {
            set;
            get;
        }

        #endregion // ����

    }
}