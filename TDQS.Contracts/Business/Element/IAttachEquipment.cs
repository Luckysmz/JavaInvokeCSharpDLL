#region CLR�汾 4.0.30319.239
// IAttachEquipment �ӿ�
// ʱ�䣺2011-12-15 10:39:11
// ���ƣ�IAttachEquipment
// ��٣������豸
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
    /// �����豸
    /// </summary>
    public interface IAttachEquipment :IElement
    {
        #region ����
        #endregion // ����

        #region ����
        /// <summary>
        /// ��֮�����ĸ������豸
        /// </summary>
        INodeEquipment AttachedEquipment { get; set; }
        #endregion // ����

        #region �¼�
        #endregion // �¼�
    }
}

