#region CLR�汾 4.0.30319.225
// IMender �ӿ�
// ʱ�䣺2011-11-21 13:02:12
// ���ƣ��޸��߽ӿ�
// ��٣��޶��������֤���޸���Ϊ
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

namespace TDQS
{
    /// <summary>
    /// �޸��߽ӿ�
    /// </summary>
    public interface IMender
    {
        #region ����
        /// <summary>
        /// ������֤
        /// </summary>
        /// <param name="data">����</param>
        /// <returns>�Ƿ�Ϸ�</returns>
        bool Check(object data);
        /// <summary>
        /// �����޸�
        /// </summary>
        /// <param name="data">����</param>
        /// <returns>�Ϸ�����</returns>
        object Mend(object data);

        #endregion // ����

        #region ����
        #endregion // ����

        #region �¼�
        #endregion // �¼�
    }
}

