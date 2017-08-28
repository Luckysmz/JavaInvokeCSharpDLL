#region CLR�汾 4.0.30319.239
// IXExplanationTable �ӿ�
// ʱ�䣺2011-9-28 17:16:02
// ���ƣ�˵���� �ӿ�
// ��٣����������ݿ���ĳ���˵����, ��˵���� ��������, ������(���ڳ�����ʾ), ˵���ֶεļ���, �����͵���Ϣ��
//
// �����ˣ�����ΰ
// ��Ȩ��2011 ��������ʵ�����¼����ɷ����޹�˾ ��Ȩ����
// ��ע��
// ========================================================
//  ����		�޸���		����
// 2011/12/7 15:42:30, ������, �����ֶ�
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace TDQS.Contracts
{
    /// <summary>
    /// ˵�����¼�������״��Ϣ����
    /// </summary>
    public class ExpTableRecordCascadeInfo
    {
        /// <summary>
        /// ����
        /// </summary>
        public ExpTableRecordCascadeInfo()
        {
            GroupName = string.Empty;
            GroupIndex = 0;
            ParentIndex = 0;
            Children = new List<ExpTableRecordCascadeInfo>();
        }

        /// <summary>
        /// ����
        /// </summary>
        public string GroupName
        {
            get;
            set;
        }

        /// <summary>
        /// ������
        /// </summary>
        public int GroupIndex
        {
            get;
            set;
        }

        /// <summary>
        /// ��������
        /// </summary>
        public int ParentIndex
        {
            get;
            set;
        }

        /// <summary>
        /// ����Ŀ
        /// </summary>
        public List<ExpTableRecordCascadeInfo> Children
        {
            get;
            set;
        }

        /// <summary>
        /// ����Ŀ
        /// </summary>
        public ExpTableRecordCascadeInfo Parent
        {
            get;
            set;
        }
    }

    /// <summary>
    /// ���������ݿ���ĳ���˵����, ��˵���� ��������, ������(���ڳ�����ʾ), ˵���ֶεļ���, �����͵���Ϣ
    /// </summary>
    public interface IExplanationTable
    {
        #region ����

        /// <summary>
        /// �Ƿ�����ֶ�
        /// </summary>
        /// <param name="sFieldName">�ֵ�����</param>
        /// <returns>�Ƿ�����ֶ�</returns>
        bool Contains(string sFieldName);

        /// <summary>
        /// ˵���������
        /// </summary>
        /// <param name="ShowGroupFilterIndex">����������</param>
        void SetGroupFilter(int ShowGroupFilterIndex);

        #endregion

        #region ����

        /// <summary>
        /// ˵�����¼�������״��Ϣ
        /// </summary>
        ExpTableRecordCascadeInfo RecordCascadeInfo
        {
            get;
        }

        /// <summary>
        /// �������ʹ�õ��ֶδ� ��","�ָ� �磺F_ID,F_Name,F_DEC
        /// </summary>
        string OnlineFields
        {
            get;
        }

        /// <summary>
        /// ������ʾ���ֶ� ע�� GroupIndex>0
        /// </summary>
        string DisplayFields
        {
            get;
        }

        /// <summary>
        /// �����������
        /// </summary>
        string[] GetPrimaryKeys
        {
            get;

        }

        /// <summary>
        /// ��������ַ�������������'|'����
        /// </summary>
        /// <returns></returns>
        string GetPrimaryKey
        {
            get;

        }

        /// <summary>
        /// �������
        /// �� �� T_JD ���˵��������Խ����� T_JD
        /// </summary>
        string Name
        {
            get;
            set;
        }

        /// <summary>
        /// ˵���������
        /// �� �� T_JD ���˵��������Խ����� T_JD_EXP
        /// </summary>
        string SchemaName
        {
            get;
        }

        /// <summary>
        /// �������ʾ����
        /// </summary>
        /// �� �� T_JD ���˵��������Խ����� �ڵ�
        string DisplayName
        {
            get;
            set;
        }

        /// <summary>
        /// ��������
        /// </summary>
        string TableRelated
        {
            get;
        }

        /// <summary>
        /// �����ֶ�
        /// </summary>
        string[] FieldRelated
        {
            get;
        }

        /// <summary>
        /// �������, ��˵���ñ���Ԫ����, ���ǲ�����, ���Ǹ��ӱ�򸽼�Ԫ����
        /// </summary>
        XTableType TableType
        {
            get;
        }

        /// <summary>
        /// ��ʾ˳��
        /// </summary>
        int Order
        {
            get;
        }

        /// <summary>
        /// �Ƿ����, ��ָ���ı��ܱ��û�ɾ��
        /// ��ϵͳ�����������
        /// </summary>
        bool BeNeed
        {
            get;
        }


        /// <summary>
        /// ��ȡ���ֶ���Ϊ������˵���ֶ�
        /// ��: this["F_ID"] ����ȡ F_ID ���ֶ�˵��
        /// </summary>
        /// <param name="fieldName">����</param>
        /// <returns>˵����</returns>
        IXExplanationField this[string fieldName]
        {
            get;
        }

        /// <summary>
        /// ��ȡ˵�������ֶεļ���
        /// </summary>
        ICollection<IXExplanationField> Fields
        {
            get;
        }

        /// <summary>
        /// ˵�����Ӧ�������ֵ�
        /// </summary>
        IDbDictionary DbDictionary
        {
            get;
        }

        /// <summary>
        /// ���������
        /// </summary>
        int FreezeCount
        {
            get;
        }

        /// <summary>
        /// ������˵��
        /// </summary>
        string BrowseItems
        {
            get;
        }

        /// <summary>
        /// ������ʾ�������
        /// ��������20090206�����
        /// </summary>
        String OrderBy
        {
            get;
        }

        /// <summary>
        /// ����� 
        /// </summary>
        List<int> GroupFilter
        {
            get;
        }

        #endregion // ����

        #region �¼�
        #endregion // �¼�
    }

    /// <summary>
    /// �������
    /// </summary>
    public enum XTableType : byte
    {
        /// <summary>
        /// δ֪
        /// </summary>
        [Description("δ֪")]
        Unknown = 0,

        /// <summary>
        /// ����
        /// </summary>
        [Description("������")]
        Network = 1,

        /// <summary>
        /// �������ӱ�
        /// </summary>
        [Description("�������ӱ�")]
        AddinationalNetwork = 2,

        /// <summary>
        /// Ԫ���������
        /// </summary>
        [Description("Ԫ��������ݱ�")]
        ElementData = 3,

        /// <summary>
        /// �豸��
        /// </summary>
        [Description("�豸��")]
        Equipment = 4,

        /// <summary>
        /// ��ʩ��
        /// </summary>
        [Description("��ʩ��")]
        EquipmentContainer = 6,

        /// <summary>
        /// ����Ԫ����
        /// </summary>
        [Description("����Ԫ����")]
        AddinationalElement = 7,

        /// <summary>
        /// Ԫ����ϵ��
        /// </summary>
        [Description("Ԫ����ϵ��")]
        ElementRelationship = 8,

        /// <summary>
        /// ������
        /// </summary>
        [Description("������")]
        Parameter = 9,

        /// <summary>
        /// ���ӱ�
        /// </summary>
        [Description("���������")]
        Addinational = 10,

        /// <summary>
        /// �оݱ�
        /// </summary>
        [Description("�оݱ�")]
        Criterion = 13,

        /// <summary>
        /// ����
        /// </summary>
        [Description("����")]
        Report = 14,

        /// <summary>
        /// ������
        /// </summary>
        [Description("������")]
        Zone = 20
    }
}

