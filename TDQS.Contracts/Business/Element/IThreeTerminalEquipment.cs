#region CLR�汾 4.0.30319.239
// IThreeLineEquipment �ӿ�
// ʱ�䣺2012-3-12 11:57:28
// ���ƣ�IThreeLineEquipment
// ��٣���֧·�豸
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

namespace TDQS.Contracts
{
    /// <summary>
    /// ��֧·�豸
    /// </summary>
    public interface IThreeTerminalEquipment :IBranchEquipment
    {
        #region ����
        ///// <summary>
        ///// ����������ϵ��Ϊ��Ԫ���е㣨˫��
        ///// </summary>
        ///// <param name="ele">����Ԫ��</param>
        //void AssociateAsMiddle(IElement ele);
        #endregion // ����

        #region ����
        /// <summary>
        /// �����ڸ�֧·�豸�ϵ��м�ڵ��豸
        /// </summary>
        INodeEquipment MiddleNodeEquipment { get; set; }
        #endregion // ����

        #region �¼�
        #endregion // �¼�
    }
}

