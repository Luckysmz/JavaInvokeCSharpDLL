#region CLR�汾 4.0.30319.239
// IControl �ӿ�
// ʱ�䣺2011-11-10 14:04:17
// ���ƣ�IControl 
// ��٣����пؼ�����ʵ�ֵĽӿ�
//
// �����ˣ�����
// ��Ȩ��2011 ��������ʵ�����¼����ɷ����޹�˾ ��Ȩ����
// ��ע��
// ========================================================
//  ����		�޸���		����
#endregion
using System;
using System.Collections.Generic;

namespace TDQS.Contracts
{
    /// <summary>
    /// ���пؼ�����ʵ�ֵĽӿ�
    /// </summary>
    public interface IControl
    {
        #region ����
        void ResourceChanged();
        #endregion // ����

        #region ����
        string       mPrpResourceName { get; set; }
        ResourceMode mPrpResourceMode { get; set; }
        #endregion // ����

        #region �¼�
        #endregion // �¼�
    }
}

