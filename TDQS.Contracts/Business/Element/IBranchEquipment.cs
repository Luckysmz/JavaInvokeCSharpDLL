#region CLR�汾 4.0.30319.239
// ILineEquipment �ӿ�
// ʱ�䣺2011-12-15 10:31:41
// ���ƣ�ILineEquipment
// ��٣�֧·�豸
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
    /// ֧·�豸
    /// </summary>
    public interface IBranchEquipment :IElement
    {
        #region ����

        #endregion // ����

        #region ����

        /// <summary>
        /// �����ڸ�֧·�豸�ϵ���ʼ�ڵ��豸
        /// </summary>
        INodeEquipment StartNodeEquipment 
        { 
            get;
            set; 
        }

        /// <summary>
        /// �����ڸ�֧·�豸�ϵĽ����ڵ��豸
        /// </summary>
        INodeEquipment EndNodeEquipment 
        { 
            get; 
            set; 
        }

        /// <summary>
        /// ���е���̬��֧·�豸 �������翪�ء���ѹ����
        /// </summary>
        bool IsPointShape
        {
            get;
            set;
        }

        #endregion // ����

        #region �¼�
        #endregion // �¼�
    }
}

