#region CLR�汾 4.0.30319.239
// ElementMetadata ��
// ʱ�䣺2011-11-10 13:25:09
// ���ƣ�ElementMetadata
// ��٣�����Ԫ����Metadata��
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
    /// Ԫ��Ԫ������
    /// </summary>
    [MetadataAttribute]
    public class ElementMetadata : Attribute
    {
        #region ���������

        /// <summary>
        /// ����
        /// </summary>
  
        #endregion // ���������

        #region ���з���
     
      
        #endregion // ���з���

        #region ��������
        #endregion // ��������

        #region ˽�з���
        #endregion // ˽�з���

        #region ���Լ���˽�б���
        /// <summary>
        /// ID: Ԫ����IDֵ�� 
        /// </summary>
        public long ID { get; set; }
        /// <summary>
        /// Name: Ԫ�������ơ�
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Ԫ������
        /// ����2012.12.4����
        /// </summary>
        public string TableName
        {
            get;
            set;
        }

        /// <summary>
        /// ElementType: Ԫ������
        /// </summary>
        public ElementType ElementType { get; set; }

        #endregion // ���Լ���˽�б���

    }

    /// <summary>
    /// IElementMetadataView�ӿ�
    /// ����ElementMetadata�����View
    /// </summary>
    public interface IElementMetadataView
    {
        /// <summary>
        /// ID
        /// </summary>
        long ID { get; }
        /// <summary>
        /// ���� 
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Ԫ������
        /// ����2012.12.4����
        /// </summary>
        string TableName 
        { 
            get; 
        }
        /// <summary>
        /// Ԫ������
        /// </summary>
        ElementType ElementType { get; }
    }

}