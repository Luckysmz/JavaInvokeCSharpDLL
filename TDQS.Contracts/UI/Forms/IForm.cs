#region CLR�汾 4.0.30319.239
// IForm �ӿ�
// ʱ�䣺2011-11-10 14:04:17
// ���ƣ�����ӿ�
// ��٣���������ӿ�
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
using System.Windows.Forms;


namespace TDQS.Contracts
{
    /// <summary>
    /// ��������ӿ�
    /// </summary>
    public interface IForm
    {
        #region ����
        #endregion // ����

        #region ����
        /// <summary>
        /// ����ʵ��
        /// </summary>
        Form Instance { get; }
        /// <summary>
        /// ��Դ����
        /// </summary>
        string PrpResourceName { get; set; }
        /// <summary>
        /// ��Դģʽ
        /// </summary>
        ResourceMode PrpResourceMode { get; set; }
        #endregion // ����

        #region �¼�
        #endregion // �¼�
    }
}



