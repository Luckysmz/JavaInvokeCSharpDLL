#region CLR�汾 4.0.30319.239
// ToolMetadata ��
// ʱ�䣺2011-11-15 13:14:03
// ���ƣ�ToolMetadata
// ��٣����л�ͼ���ߵ�Metadata��
//
// �����ˣ�����
// ��Ȩ��2011 ��������ʵ�����¼����ɷ����޹�˾ ��Ȩ����
// ��ע��
// ========================================================
//  ����		�޸���		����
#endregion
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;

namespace TDQS.Contracts
{
    /// <summary>
    /// ���в������ߵ�Ԫ������
    /// </summary>
    [MetadataAttribute]
    public class ToolMetadata : Attribute
    {
        #region ���������

        /// <summary>
        /// ����
        /// </summary>
        public ToolMetadata()
        {
        }

        #endregion // ���������

        #region ���з���
        #endregion // ���з���

        #region ��������
        #endregion // ��������

        #region ˽�з���
        #endregion // ˽�з���

        #region ���Լ���˽�б���
        /// <summary>
        /// ID: ���ߵ�IDֵ�� 
        /// </summary>
        public long ID { get; set; }

        /// <summary>
        /// Name: �������ơ�
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Name: Ԫ�����ơ�
        /// </summary>
        public string ElementName { get; set; }

        /// <summary>
        /// ElementType: Ԫ������
        /// </summary>
        public ElementType ElementType { get; set; }

        #endregion // ���Լ���˽�б���

    }

    /// <summary>
    /// ����ToolMetadata�����View
    /// </summary>
    public interface IToolMetadataView
    {
        /// <summary>
        /// ID: ���ߵ�IDֵ�� 
        /// </summary>
        long ID { get; }

        /// <summary>
        /// Name: �������ơ�
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Name: Ԫ�����ơ�
        /// </summary>
        string ElementName { get; }

        /// <summary>
        /// ElementType: Ԫ������
        /// </summary>
        ElementType ElementType { get; }
    }

}