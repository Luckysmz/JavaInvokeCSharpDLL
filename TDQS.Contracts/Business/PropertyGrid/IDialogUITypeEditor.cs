#region CLR�汾 4.0.30319.17379
// IDialogUITypeEditor �ӿ�
// ʱ�䣺2012/08/02 17:24:08
// ���ƣ�IDialogUITypeEditor
// ��٣�������༭���ӿ�
//
// �����ˣ�������
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
    /// ������༭���ӿ�
    /// </summary>
    public interface IDialogUITypeEditor
    {
        #region ����
        #endregion // ����

        #region ����
        /// <summary>
        /// ���
        /// </summary>
        string Result
        {
            get;
        }
        /// <summary>
        /// ����
        /// </summary>
        string parameter
        {
            get;
        }
        #endregion // ����

        #region �¼�
        #endregion // �¼�
    }
}

