#region CLR�汾 4.0.30319.225
// IGridOperat �ӿ�
// ʱ�䣺2011-11-28 15:26:48
// ���ƣ�IGridOperat �ӿ�
// ��٣��������ӿ�
//
// �����ˣ�����ΰ
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
    /// �������ӿ�
    /// </summary>
    public interface IGridOperat
    {
        #region ����
        /// <summary>
        /// ɾ����¼��
        /// </summary>
        void Delete();
        /// <summary>
        /// ����¼�¼
        /// </summary>
        void Add();
        /// <summary>
        /// ����
        /// </summary>
        void Save();

        /// <summary>
        /// ����״̬ True:�Ѿ����棬False:û����
        /// </summary>
        bool IsSave();
        #endregion // ����

        #region ����
        #endregion // ����

        #region �¼�
        #endregion // �¼�
    }
}

