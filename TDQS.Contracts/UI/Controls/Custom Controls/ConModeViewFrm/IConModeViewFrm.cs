#region CLR�汾 4.0.30319.239
// IValidateResultFrm �ӿ�
// ʱ�䣺2012-8-29 14:04:17
// ���ƣ�IConModeViewFrm 
// ��٣���ѹ����ģʽ�쳣�������������ڽӿ�
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
    /// ��ѹ����ģʽ������ڽӿ�
    /// </summary>
    public interface IConModeViewFrm
    {
        #region ����

        /// <summary>
        /// ��ʾУ����
        /// </summary>
        /// <param name="view">��ͼ</param>
        /// <param name="errPropertDic_Illegal">�쳣�����ֵ�</param>
        void ShowConModeResult(IView  view, Dictionary<string, List<IElement>> errElementDic);

        #endregion // ����

        #region ����
        #endregion // ����

        #region �¼�
        #endregion // �¼�
    }
}

