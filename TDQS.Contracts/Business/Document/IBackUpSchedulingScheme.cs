#region CLR�汾 4.0.30319.296
// IBackUpSchedulingScheme �ӿ�
// ʱ�䣺2013/6/7 14:32:38
// ���ƣ��Զ����ݵ����������
// ��٣�
//
// �����ˣ�����ƽ
// ��Ȩ��Copyright (C) 2013 ��������ʵ�����¼����ɷ����޹�˾ ��Ȩ����
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
    /// �Զ����ݵ����������
    /// </summary>
    public interface IBackUpSchedulingScheme
    {
        #region ����
        #endregion // ����

        #region ����
        #endregion // ����

        #region �¼�

        /// <summary>
        /// ִ��һ�α��ݵ�ʱ��
        /// </summary>
        event EventHandler IndeedExcute;

        /// <summary>
        /// ִ��һ�μٱ��ݵ�ʱ��
        /// </summary>
        event EventHandler UnIndeedExcute;

        /// <summary>
        /// ����
        /// </summary>
        void Active();

        /// <summary>
        /// ��Լ
        /// </summary>
        void UnActive();

        #endregion // �¼�
    }
}

