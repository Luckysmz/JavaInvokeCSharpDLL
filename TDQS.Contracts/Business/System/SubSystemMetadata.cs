#region CLR�汾 4.0.30319.269
// SubSystemMetadata ��
// ʱ�䣺2012-5-17 10:14:10
// ���ƣ�SubSystemMetadata
// ��٣�������ϵͳ�����Metadata
//
// �����ˣ�����
// ��Ȩ��Copyright (C) 2012 ��������ʵ�����¼����ɷ����޹�˾ ��Ȩ����
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
    /// ������ϵͳ�����Ԫ������
    /// </summary>
    [MetadataAttribute]
    public class SubSystemMetadata : Attribute
    {
        #region ���������
        #endregion // ���������

        #region ���з���
        /// <summary>
        /// ID: ��ϵͳ��IDֵ
        /// </summary>
        public long ID { get; set; }

        /// <summary>
        /// Name: ��ϵͳ������
        /// </summary>
        public string Name { get; set; }
        #endregion // ���з���

        #region ��������
        #endregion // ��������

        #region ˽�з���
        #endregion // ˽�з���

        #region ���Լ���˽�б���
        #endregion // ���Լ���˽�б���

    }

    /// <summary>
    /// ����SubSystemMetadata�����View
    /// </summary>
    public interface ISubSystemMetadataView
    {
        /// <summary>
        /// ID: ��ϵͳ��IDֵ
        /// </summary>
        long ID { get; }


        /// <summary>
        /// Name: ��ϵͳ������
        /// </summary>
        string Name { get; }
    }
}