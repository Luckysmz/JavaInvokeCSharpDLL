#region CLR�汾 4.0.30319.239
// IValidateResultFrm �ӿ�
// ʱ�䣺2012-5-11 14:04:17
// ���ƣ�IEditPanel 
// ��٣���·����У�������ڽӿ�
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
    /// ��·����У�������ڽӿ�
    /// </summary>
    public interface IValidateResultFrm
    {
        #region ����

        /// <summary>
        /// ��ʾ��֤���
        /// </summary>
        /// <param name="view">��ͼ����</param>
        /// <param name="errPropertDic_Illegal">�Ƿ�����Ԫ������</param>
        /// <param name="errPropertDic_Abnormal">�쳣����Ԫ������</param>
        /// <param name="algorithmFunctionNum">�㷨��ڱ��</param>
        void ShowValidateResult(IView view, Dictionary<IElement, List<string>> errPropertDic_Illegal,
            Dictionary<IElement, List<string>> errPropertDic_Abnormal, int algorithmFunctionNum);

        #endregion // ����

        #region ����
        #endregion // ����

        #region �¼�
        #endregion // �¼�
    }
}

