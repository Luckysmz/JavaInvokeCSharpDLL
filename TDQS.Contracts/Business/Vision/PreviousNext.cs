#region CLR�汾 4.0.30319.239
// PreviousNext �ӿ�
// ʱ�䣺2011/11/25 14:03:54
// ���ƣ��������趯������ӿ�
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

namespace TDQS.Contracts
{
    /// <summary>
    /// �������趯������ӿ�
    /// </summary>
    public interface PreviousNext
    {
        #region ����
        /// <summary>
        /// ǰ��
        /// </summary>
        /// <returns></returns>
        bool Previous();

        /// <summary>
        /// ��
        /// </summary>
        /// <returns></returns>
        bool Next();

        /// <summary>
        /// ׷��
        /// </summary>
        void Append();

        #endregion // ����

        #region ����
        #endregion // ����

        #region �¼�
        #endregion // �¼�
    }
}