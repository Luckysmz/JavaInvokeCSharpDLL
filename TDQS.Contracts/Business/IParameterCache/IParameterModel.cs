#region CLR�汾 4.0.30319.17379
// IParameterModel �ӿ�
// ʱ�䣺2012/4/19 16:02:11
// ���ƣ�IParameterModel
// ��٣���������ģ�ͽӿ�
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
using System.Data;

namespace TDQS.Contracts
{
    /// <summary>
    /// ��������ģ�ͽӿ�
    /// </summary>
    public interface IParameterModel
    {
        #region ����
        
        #endregion // ����

        #region ����

        /// <summary>
        /// ��������
        /// </summary>
        string ParameterName
        {
            get;
            set;
        }

        /// <summary>
        /// ˢ�±�־
        /// </summary>
        bool Refresh
        {
            get;
            set;
        }

        /// <summary>
        /// ��������
        /// </summary>
        DataTable ParameterData
        {
            get;
            set;
        }

        /// <summary>
        /// ����
        /// </summary>
        string Command
        {
            get;
            set;
        }
        /// <summary>
        /// ������ID
        /// ����ϵͳ��_0000_000000000000000000000000�͹��̼�
        /// </summary>
        string ParameterID
        {
            get;
            set;
        }

        #endregion // ����

        #region �¼�
        #endregion // �¼�
    }
}

