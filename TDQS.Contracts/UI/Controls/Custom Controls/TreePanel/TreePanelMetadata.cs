#region CLR�汾 4.0.30319.225
// TreePanelMetadata ��
// ʱ�䣺2011-11-28 15:26:48
// ���ƣ�TreePanelMetadata ��
// ��٣�TreePanelԪ������
//
// �����ˣ�����ΰ
// ��Ȩ��2011 ��������ʵ�����¼����ɷ����޹�˾ ��Ȩ����
// ��ע��
// ========================================================
//  ����		�޸���		����
#endregion
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel.Composition;

namespace TDQS.Contracts
{
    /// <summary>
    /// TreePanelԪ������
    /// </summary>
    [MetadataAttribute]
    public class TreePanelMetadata : Attribute
    {
        #region ���������

        /// <summary>
        /// ����
        /// </summary>
        public TreePanelMetadata()
        {
            //
            
            //
        }

        #endregion // ���������

        #region ���з���
        /// <summary>
        /// ID: GridPanel��IDֵ����������.�� 
        /// </summary>
        public long ID { get; set; }
        /// <summary>
        /// Name: GridPanel������. 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// FormName: GridPanel�ĸ���������. 
        /// </summary>
        public string FormName { get; set; }
        #endregion // ���з���

        #region ��������
        #endregion // ��������

        #region ˽�з���
        #endregion // ˽�з���

        #region ���Լ���˽�б���
        #endregion // ���Լ���˽�б���
    }
    /// <summary>
    /// ����TreePanelMetadata�����View
    /// </summary>
    public interface ITreePanelMetadataView
    {
        /// <summary>
        /// ID: GridPanel��IDֵ����������.�� 
        /// </summary>
        long ID { get; }
        /// <summary>
        /// Name: GridPanel������. 
        /// </summary>
        string Name { get; }
        /// <summary>
        /// FormName: GridPanel�ĸ���������. 
        /// </summary>
        string FormName { get; }
    }
}