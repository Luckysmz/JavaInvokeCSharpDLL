#region CLR�汾 4.0.30319.239
// IVisionModel �ӿ�
// ʱ�䣺2011/12/8 11:00:13
// ���ƣ���Ұ����ģ�ͽӿ�
// ��٣�
//
// �����ˣ�3VELD97PNBO4RT9
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
    /// ��Ұ����ģ�ͽӿ�
    /// </summary>
    public interface IVisionModel
    {
        #region ����
        #endregion // ����

        #region ����
        /// <summary>
        /// ��ȡ��������Ұ��Χ�����Ͻ�X����
        /// </summary>
        string X1
        {
            get;
            set;
        }

        /// <summary>
        /// ��ȡ��������Ұ��Χ�����Ͻ�Y����
        /// </summary>
        string Y1
        {
            get;
            set;
        }

        /// <summary>
        /// ��ȡ��������Ұ��Χ�����½�X����
        /// </summary>
        string X2
        {
            get;
            set;
        }

        /// <summary>
        /// ��ȡ��������Ұ��Χ�����½�Y����
        /// </summary>
        string Y2
        {
            get;
            set;
        }
        

        /// <summary>
        /// ��ȡ�����õ�ǰ��Ұ������
        /// </summary>
        string VisionName
        {
            get;
            set;
        }
        #endregion // ����

        #region �¼�
        #endregion // �¼�
    }
}

