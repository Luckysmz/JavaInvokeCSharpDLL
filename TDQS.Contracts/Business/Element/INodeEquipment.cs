#region CLR�汾 4.0.30319.239
// INodeEquipment �ӿ�
// ʱ�䣺2011-12-15 10:28:32
// ���ƣ�INodeEquipment
// ��٣��ڵ��豸
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
    /// �ڵ��豸
    /// </summary>
    public interface INodeEquipment :IElement
    {
        #region ����
        #endregion // ����

        #region ����

        /// <summary>
        /// �ڵ��豸���������ӵ��豸����(֧·�������豸)
        /// </summary>
        IElementCollection Elements 
        { 
            get; 
            set; 
        }

        #endregion // ����

        #region �¼�
        #endregion // �¼�
    }
}

