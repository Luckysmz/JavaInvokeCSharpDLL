#region CLR�汾 4.0.30319.239
// VisionMetadata �ӿ�
// ʱ�䣺2011/12/7 16:11:09
// ���ƣ���Ұ����Ԫ����
// ��٣�
//
// �����ˣ�������
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

namespace TDQS.Contracts
{
    /// <summary>
    /// ��Ұ����Ԫ����
    /// </summary>
    [MetadataAttribute]
    public class VisionMetadata : Attribute
    {
        #region ����
        #endregion // ����

        #region ����
        /// <summary>
        /// ����id
        /// </summary>
        public long ID
        {
            get;
            set;
        }

        /// <summary>
        /// ��������
        /// </summary>
        public string Name
        {
            get;
            set;
        }

        #endregion // ����

        #region �¼�
        #endregion // �¼�
    }

    /// <summary>
    /// ��ҰԪ����
    /// </summary>
    public interface IVisionMetadata
    {
        /// <summary>
        /// ���
        /// </summary>
        long ID { get; }
        /// <summary>
        /// ����
        /// </summary>
        string Name { get; }
    }
}

