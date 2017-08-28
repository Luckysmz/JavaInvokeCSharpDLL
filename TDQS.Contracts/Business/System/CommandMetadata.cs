#region CLR�汾 4.0.30319.239
// CommandMetadata ��
// ʱ�䣺2011-11-10 14:04:17
// ���ƣ�CommandMetadata 
// ��٣�����Command�����Metadata
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
using System.ComponentModel.Composition;
using System.Windows.Forms;
using System.Reflection;
using System.Resources;

namespace TDQS.Contracts
{
    /// <summary>
    /// ����Command�����Ԫ������
    /// </summary>
    [MetadataAttribute]
    public class CommandMetadata : Attribute
    {
        #region ���������

        /// <summary>
        /// ����
        /// </summary>
        #endregion // ���������

        #region ���з���
        /// <summary>
        /// ID: �����IDֵ�������������˵���Ԥ��1-20���� �ļ�Ϊ"101", ����Ϊ"2001"�� 
        /// </summary>
        public long ID { get; set; }

        /// <summary>
        /// Name: ��������ƣ���Ϊ�����Ψһ��ʶ����Ӧ�ظ���
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// ResMode: ��Դ����, ��ֵ����: "Null" "Common" "Self" "Ext"
        /// </summary>
        public ResourceMode ResMode { get; set; }

        /// <summary>
        /// MenuName:�����˵�������
        /// </summary>
        public string MenuName { get; set; }

        /// <summary>
        /// SubMenuName: �������˵�������
        /// </summary>
        public string SubMenuName { get; set; }

        /// <summary>
        /// MenuText: �˵����ı�
        /// </summary>
        public string MenuText { get; set; }

        /// <summary>
        /// ToolBtnName: ��������ť���ƣ�ע������Դ������ͬ����װ����Դ��
        /// </summary>
        public string ToolBtnName { get; set; }

        /// <summary>
        /// ToolBtnText: ��������ť�ı�
        /// </summary>
        public string ToolBtnText { get; set; }

        /// <summary>
        /// CheckFunction: Check������
        /// </summary>
        public string CheckFunction { get; set; }

        /// <summary>
        /// EnableFunction: Enable������
        /// </summary>
        public string EnableFunction { get; set; }

        /// <summary>
        /// VisibleFunction: Visible������
        /// </summary>
        public string VisibleFunction { get; set; }
        /// <summary>
        ///DBClickFunction: ˫��������
        /// </summary>
        public string DBClickFunction { get; set; }

        /// <summary>
        /// ��ݼ�
        /// </summary>
        public string ShortcutKey { get; set; }

        /// <summary>
        /// �������
        /// </summary>
        public string ShortcutCommand { get; set; }

        /// <summary>
        /// ��ȡ������ȫ���ȼ�״̬
        /// </summary>
        public bool GlobalShortcut { get; set; }

        /// <summary>
        /// ������������
        /// </summary>
        public int Row { get; set; }

        /// <summary>
        /// ���������ڵ������ռ䣬Ϊ��ʱ��Ϊ����ϵͳͬ����
        /// </summary>
        public string NameSpace { get; set; }
        #endregion // ���з���

        #region ��������
        #endregion // ��������

        #region ˽�з���
        #endregion // ˽�з���

        #region ���Լ���˽�б���
        #endregion // ���Լ���˽�б���

    }

    /// <summary>
    /// ����CommandMetadata�����View
    /// </summary>
    public interface ICommandMetadataView
    {
        /// <summary>
        /// ID: �����IDֵ�������������˵���Ԥ��1-20���� �ļ�Ϊ"101", ����Ϊ"2001"�� 
        /// </summary>
        long ID { get; }

        /// <summary>
        /// Name: ��������ƣ���Ϊ�����Ψһ��ʶ����Ӧ�ظ���
        /// </summary>
        string Name { get; }

        /// <summary>
        /// ResMode: ��Դ����, ��ֵ����: "Null" "Common" "Self" "Ext"
        /// </summary>
        ResourceMode ResMode { get; }

        /// <summary>
        /// MenuName:�����˵������ƣ�ע������Դ������ͬ����װ����Դ��
        /// </summary>
        string MenuName { get; }

        /// <summary>
        /// SubMenuName: �������˵�������
        /// </summary>
        string SubMenuName { get; }

        /// <summary>
        /// MenuText: �˵����ı�
        /// </summary>
        string MenuText { get; }

        /// <summary>
        /// ToolBtnName: ��������ť���ƣ�ע������Դ������ͬ����װ����Դ��
        /// </summary>
        string ToolBtnName { get; }

        /// <summary>
        /// ToolBtnText: ��������ť�ı�
        /// </summary>
        string ToolBtnText { get; }

        /// <summary>
        /// Check������
        /// </summary>
        string CheckFunction { get; }

        /// <summary>
        /// Enable������
        /// </summary>
        string EnableFunction { get; }

        /// <summary>
        /// Visible������
        /// </summary>
        string VisibleFunction { get; }
        /// <summary>
        ///DBClickFunction: ˫��������
        /// </summary>
        string DBClickFunction { get; }

        /// <summary>
        /// ��ݼ�
        /// </summary>
        string ShortcutKey { get; }

        /// <summary>
        /// �������
        /// </summary>
        string ShortcutCommand { get; }

        /// <summary>
        /// ��ȡ�Ƿ�Ϊȫ���ȼ�
        /// </summary>
        bool GlobalShortcut { get; }

        /// <summary>
        /// ������������
        /// </summary>
        int Row { get; }

        /// <summary>
        /// ���������������ռ�����
        /// </summary>
        string NameSpace { get; }
    }

}