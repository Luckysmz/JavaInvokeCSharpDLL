#region CLR�汾 4.0.30319.17379
// IAttriuteStatus �ӿ�
// ʱ�䣺2012/4/24 15:41:28
// ���ƣ�IAttriuteStatus
// ��٣�����״̬
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
    /// ����״̬
    /// </summary>
    public interface IAttriuteStatus
    {
        #region ����
        #endregion // ����

        #region ����
        /// <summary>
        /// �Ƿ���ʾ��������
        /// </summary>
        bool ShowAllAttribute
        {
            get;
            set;
        }
        /// <summary>
        /// �Ƿ������������
        /// </summary>
        ReadOnlyStatus ReadOnlyAllAttribute
        {
            get;
            set;
        }
        /// <summary>
        /// �Ƿ���ʾ��������
        /// </summary>
        bool ShowMoreAttribute
        {
            get;
            set;
        }

        /// <summary>
        /// ˵����
        /// </summary>
        IExplanationTable ExplanationTable
        {
            get;
        }

        /// <summary>
        /// ��ʾ�������  ���� 2013-9-6
        /// </summary>
        int ShowGroupFilterIndex
        {
            get;
            set;
        }

        #endregion // ����

        #region �¼�
        #endregion // �¼�
    }
}

