#region CLR�汾 4.0.30319.239
// IDevice �ӿ�
// ʱ�䣺2011-12-15 10:36:20
// ���ƣ�IDevice
// ��٣���ʩ
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

namespace TDQS.Contracts
{
    /// <summary>
    /// ��ʩԪ��
    /// </summary>
    public interface IDevice : IElement
    {
        #region ����
        #endregion // ����

        #region ����

        /// <summary>
        /// ����ʩ�ϰ�������Ԫ��
        /// </summary>
        IElementCollection ChildElements { get; set; }

        #endregion // ����

        #region �¼�
        #endregion // �¼�
    }
}

