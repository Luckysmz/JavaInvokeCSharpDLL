#region CLR�汾 4.0.30319.239
// GridPanelMetadata ��
// ʱ�䣺2011/10/12 16:10:31
// ���ƣ�GridPanelMetadata 
// ��٣�GridPanelԪ������
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
using System.ComponentModel.Composition;

namespace TDQS.Contracts
{
    /// <summary>
    /// GridPanelMetadata ��
    /// </summary>
    [MetadataAttribute]
    public class GridPanelMetadata : Attribute
    {
        #region ���������

        /// <summary>
        /// ����
        /// </summary>
        public GridPanelMetadata()
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
    /// IGridPanelMetadataView �ӿ�
    /// </summary>
    public interface IGridPanelMetadataView
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